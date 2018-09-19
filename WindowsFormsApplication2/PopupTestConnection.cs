using System;
//using System.IO;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.Odbc;

namespace QueryBatchTool
{
    public partial class PopupTestConnection : Form 
    {
        public PopupTestConnection()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            username.Select(); 
        }

        protected internal String driverTypeVar             { get; set; }
        protected internal String systemNameVar             { get; set; }
        protected internal String serverNameVar             { get; set; }
        protected internal String portVar                   { get; set; }
        protected internal String databaseVar               { get; set; }
        protected internal String usernameVar               { get; set; }
        protected internal String passwordVar               { get; set; }
        protected static internal String connectionString   { get; set; }

        Main main = new Main();

        private void PopupTestConnection_Load(object sender, EventArgs e)
        {
            db2Radio.Checked = true;
        }

        private void Port_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void AllCheckBoxes_CheckedChanged(Object sender, EventArgs e)
        {
            string[] db2ControlsToHide = { "serverName", "serverNameLabel", "database", "databaseLabel", "port", "portLabel" };
            string[] pgsqlControlsToHide = { "systemName", "systemNameLabel", };
            string[] sqlServerControlsToHide = { "systemName", "systemNameLabel", "port", "portLabel" };

            foreach (Control control in this.driverTypeBox.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {                       
                        switch (radio.Name)
                        {
                            case "db2Radio":
                                driverTypeVar = "DB2";
                                //this.systemName.Text = "testSystemName"; //use this to pre-fill a certain value for ease of use
                                foreach (Control controlElement in this.Controls)
                                {
                                    if (db2ControlsToHide.Contains(controlElement.Name))
                                    {
                                        controlElement.Visible = false;
                                    }
                                    else
                                        controlElement.Visible = true;
                                }
                                break;

                            case "pgsqlRadio":
                                driverTypeVar = "PostgreSQL";
                                //this.serverName.Text = "testServer"; //use this to pre-fill a certain value for ease of use
                                //this.database.Text = "testDB"; //use this to pre-fill a certain value for ease of use
                                //this.port.Text = "5435"; //use this to pre-fill a certain value for ease of use
                                foreach (Control controlElement in this.Controls)
                                {
                                    if (pgsqlControlsToHide.Contains(controlElement.Name))
                                    {
                                        controlElement.Visible = false;
                                    }
                                    else
                                        controlElement.Visible = true;
                                }
                                break;

                            case "sqlServerRadio":
                                driverTypeVar = "SQL Server";
                                //this.serverName.Text = "testServer"; //use this to pre-fill a certain value for ease of use
                                //this.database.Text = "testDB"; //use this to pre-fill a certain value for ease of use 
                                foreach (Control controlElement in this.Controls)
                                {
                                    if (sqlServerControlsToHide.Contains(controlElement.Name))
                                    {
                                        controlElement.Visible = false;
                                    }
                                    else
                                        controlElement.Visible = true;
                                }
                                break;
                            default: 
                                break;
                        }
                    }
                }
            }
        }

        private void button1ConnectButton_Click(object sender, EventArgs e)
        {
            //get input data
            systemNameVar = this.systemName.Text;
            serverNameVar = this.serverName.Text;
            portVar       = this.port.Text;
            databaseVar   = this.database.Text;
            usernameVar   = this.username.Text;
            passwordVar   = this.password.Text;

            string result = main.formConnection(driverTypeVar, systemNameVar, serverNameVar, portVar, databaseVar, usernameVar, passwordVar);
            MessageBox.Show(result,"Connection Result");

            if (result == "Connection Successful!")
            {
                this.Close();
            }
    
            else if (result == "Connection Error!")
            {
                username.Clear();
                password.Clear();
            }
        }        
    }
}
//x