using System;
using System.IO;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
//using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Threading;

//Project reloaded in 2018

namespace QueryBatchTool
{
    public partial class Main : Form 
    {
        public Main()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
     
        private void Form1_Load_1(Object sender, EventArgs e)
        {
            button2VerifyFiles.Enabled = false;
            button3DatabaseConnection.Enabled = false;
            button4RunQuery.Enabled = false;
            button5Exit.Enabled = false;
            button6Kill.Hide();
            progressBar1.Hide();
        }

        protected internal String folderPath { get; set; }
        protected internal String resultsPath { get; set; }
        protected internal static string connectionString;
        protected internal OdbcConnection connection;

        public string formConnection(string driverType, string systemName, string serverName, string port, string database, string username, string password)
        {
            string testResult;
            string driver;

            switch (driverType)
            {
                case "DB2":
                    driver = "{iSeries Access ODBC Driver}";
                    connectionString = "Driver=" + driver + ";" + "Translate = 1" + ";" + "System=" + systemName + ";" + "Uid=" + username + ";" + "Pwd=" + password + ";";
                    break;

                case "PostgreSQL":
                    driver = "{PostgreSQL Unicode}";
                    connectionString = "Driver=" + driver + ";" + "Servername=" + serverName + ";" + "Port="+ port + ";" + "Database=" + database + ";" +"UserName=" + username + ";" + "Password=" + password + ";";
                    break;

                case "SQL Server":
                    driver = "{SQL Server}";
                    connectionString = "Driver=" + driver + ";" + "Server=" + serverName + ";" + "Database=" + database + ";" + "UID=" + username + ";" + "PWD=" + password + ";";
                    break;

                default:
                    driver = "{iSeries Access ODBC Driver}";
                    connectionString = "Driver=" + driver + ";" + "Translate = 1" + ";" + "System=" + systemName + ";" + "Uid=" + username + ";" + "Pwd=" + password + ";";
                    break;
            }

            connection = new OdbcConnection(connectionString);

            try
            {
                connection.Open();
                testResult = "Connection Successful!";
            }

            catch (Exception exc)
            {
                testResult = "Connection Error! \n" + exc.Message; 
            }

            return testResult;
        }
          
        //1.Prepare Files
        private void button1PrepareFiles_Click(object sender, EventArgs e)
        {
            button1PrepareFiles.Enabled = false;
            MessageBox.Show
            ("Please prepare your queries in separate text/sql files and distinct names, using standard characters! After you are done choose the folder where you saved them.","Prepare Files");         
            var folderDialog = new FolderBrowserDialog();
            DialogResult result = folderDialog.ShowDialog();
            folderPath = folderDialog.SelectedPath;
            button2VerifyFiles.Enabled = true;
        }

        //2.Verify Files
        private void button2VerifyFiles_Click(object sender, EventArgs e)
        {
            button2VerifyFiles.Enabled = false;

            string[] files = Directory.GetFiles(folderPath); // count all files
            
            int validFilesCount = 0;
            foreach(string x in files) //count text/sql files
            {

                if (x.Contains(".txt") || x.Contains(".sql"))
                {
                    validFilesCount++;
                }            
            }
            progressBar1.Maximum = validFilesCount; //set progress bar range equal to number of text files
           
            DialogResult dialogResult = MessageBox.Show("There are " + validFilesCount.ToString() +" valid files out of " + files.Length.ToString() + " total files in the selected directory.", "Verify Files", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {    
                button3DatabaseConnection.Enabled = true;
            }
            else if (dialogResult == DialogResult.No)
            {
                button1PrepareFiles.Enabled = true;
            }    
        }

        //3.Database Connection
        private void button3DatabaseConnection_Click(object sender, EventArgs e)
        {
            button3DatabaseConnection.Enabled = false;
            PopupTestConnection popup = new PopupTestConnection();
            popup.Show();
            button4RunQuery.Enabled = true;
        }

        //4.Run Queries
        private void button4RunQueries_Click(object sender, EventArgs e)
        {
            string exportMethod = "Excel";
            PopupExportMethod popupExportMethod = new PopupExportMethod();
            //Call form as Dialog to avoid new instance
            popupExportMethod.ShowDialog();

            if (popupExportMethod.DialogResult == DialogResult.Cancel)
            {
                exportMethod = "CSV";
            }

            button4RunQuery.Enabled = false;
            button6Kill.Show(); //Show Kill Button

            //start looping on new thread to keep UI responsive
            Thread newThread = new Thread(() => LoopFiles(exportMethod));
            newThread.Start();
        }

        //5.Exit
        private void button5Exit_Click(object sender, EventArgs e)
        {
            button5Exit.Enabled = false;
            
            //open Results folder
            if (folderPath != null) { 
            Process.Start(new ProcessStartInfo()
            {
                FileName = resultsPath,
                UseShellExecute = true,
                Verb = "open"
            });
            }

            this.Close(); //Adios
        }

        private void button6Kill_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void LoopFiles(string exportMethod)
        {
            //check if results folder exists, else create it
            resultsPath = Path.Combine(folderPath, "Results");

            if (!Directory.Exists(resultsPath))
            {
                Directory.CreateDirectory(resultsPath);
            }

            //prepare connection and timer
            connection = new OdbcConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Error: Connection not set!");
                button3DatabaseConnection.Invoke(new MethodInvoker(delegate
                {
                    button3DatabaseConnection.Enabled = true;
                    button6Kill.Hide();
                }));
                return;
            }
            
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

                progressBar1.Invoke(new MethodInvoker(delegate
                {
                // Executes the following code on the GUI thread.
                    progressBar1.Show();
                }));
            
            int successfulCount = 0;
            string successfulFiles = "files";
            int failedCount = 0;
            string failedFiles = "files";

            List<string> failedQueries = new List<string>();
            
            //loop through the files, extract query, run query, call excel method
            foreach(string file in Directory.EnumerateFiles(folderPath,"*.*").Where(file => file.ToLower().EndsWith("txt") || file.ToLower().EndsWith("sql")).ToList())

            {
                string query = File.ReadAllText(file); //extract query  

                //get clean file name without extension
                string fileName = Path.GetFileName(file);
                string extensionTXT = ".txt";
                string extensionSQL = ".sql";
                string cleanFileName = "";
                
                //just in case txt/sql files are not filtered           
                 if(fileName.ToLower().EndsWith(".txt"))
                 {
                    cleanFileName = fileName.Remove(fileName.IndexOf(extensionTXT), extensionTXT.Length);
                 }
                        else  if (fileName.ToLower().EndsWith(".sql"))
                        {
                            cleanFileName = fileName.Remove(fileName.IndexOf(extensionSQL), extensionSQL.Length);
                        }
                            else 
                            {
                                cleanFileName = fileName;
                            }

                if (cleanFileName.IndexOf(".") >= 0)
                {
                    cleanFileName = cleanFileName.Replace(".", " ");
                }

                DataTable queryResults = new DataTable();
                OdbcCommand command = new OdbcCommand(query, connection);
                OdbcDataAdapter dataAdapter = new OdbcDataAdapter(command);

                try
                { 
                dataAdapter.Fill(queryResults);

                    switch (exportMethod)
                    {
                        case "Excel":
                            Export_Class.ExportToExcel(queryResults, resultsPath + "\\" + cleanFileName);
                            break;

                        case "CSV":
                            Export_Class.ExportToCSV(queryResults, resultsPath, cleanFileName);
                            break;

                        default:
                            Export_Class.ExportToExcel(queryResults, resultsPath + "\\" + cleanFileName);
                            break;
                    }

                progressBar1.Invoke(new MethodInvoker(delegate
                {
                 //Executes the following code on the GUI thread.
                    progressBar1.PerformStep();
                }));
  
                    successfulCount++;
                }

                catch (Exception)
                {
                    failedCount++;
                    failedQueries.Insert(failedCount-1,cleanFileName);
                }
            }
            
            stopWatch.Stop();
            double duration = stopWatch.ElapsedMilliseconds / 1000;

            if (successfulCount == 1)
            {
                successfulFiles = "file";
            }

            if (failedCount == 1)
            {
                failedFiles = "file";    
            }

            if (failedCount != 0)
            {
                MessageBox.Show(successfulCount.ToString() + " " + successfulFiles +" exported successfully in " + duration.ToString() + " seconds!\n" +failedCount.ToString() + " " + failedFiles +" failed! Check queries.");

                //Failed queries report
                string failedQueriesFile = resultsPath + "\\" + "Failed Queries.txt";
                if (File.Exists(failedQueriesFile))
                {
                    File.WriteAllText(failedQueriesFile, string.Empty);
                }      
                    File.WriteAllLines(failedQueriesFile, failedQueries);
            }
                else
                {
                    MessageBox.Show(successfulCount.ToString() + " " + successfulFiles + " exported successfully in " + duration.ToString() + " seconds!");
                }
                      
            connection.Close();
           
            button6Kill.Invoke(new MethodInvoker(delegate
            {
                //Execute the following code on the GUI thread.
                button6Kill.Hide();
                progressBar1.Hide();
                button5Exit.Enabled = true;
            }));
        }
    }
}
//x