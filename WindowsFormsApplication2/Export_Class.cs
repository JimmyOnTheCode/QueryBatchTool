using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace QueryBatchTool
{
    public static class Export_Class
    {
        public static void ExportToExcel(this DataTable DataTable, string ExcelFilePath = null)
        {
            try
            {
                int ColumnsCount;

                if (DataTable == null || (ColumnsCount = DataTable.Columns.Count) == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                //Load Excel App and create a new workbook
                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Excel.Workbooks.Add();

                //Single Worksheet
                Microsoft.Office.Interop.Excel._Worksheet Worksheet = Excel.ActiveSheet;

                object[] Header = new object[ColumnsCount];

                //Column Headings
                for (int i = 0; i < ColumnsCount; i++)
                    Header[i] = DataTable.Columns[i].ColumnName;

                Microsoft.Office.Interop.Excel.Range HeaderRange = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, ColumnsCount]));
                HeaderRange.Value = Header;
                HeaderRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightSlateGray);
                HeaderRange.Font.Bold = true;

                //Data Cells
                int RowsCount = DataTable.Rows.Count;
                object[,] Cells = new object[RowsCount, ColumnsCount];

                for (int j = 0; j < RowsCount; j++)
                    for (int i = 0; i < ColumnsCount; i++)
                        Cells[j, i] = DataTable.Rows[j][i];

                Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[2, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[RowsCount + 1, ColumnsCount])).Value = Cells;

                //Check File Path
                if (ExcelFilePath != null || ExcelFilePath != "")
                {
                    try
                    {
                        Worksheet.SaveAs(ExcelFilePath);
                        Excel.Quit();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Excel file could not be saved! Check if path is valid!\n" + ex.Message);
                    }
                }
                //If no path is given
                else
                {
                    Excel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(message: "ExportToExcel: \n" + ex.Message);
            }
        }

        public static void ExportToCSV(DataTable queryResults, string resultsPath, string cleanFileName)
        {
            var lines = new List<string>();
            string finalPath = resultsPath + "\\" + cleanFileName + ".csv";

            string[] columnNames = queryResults.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName).
                                              ToArray();

            var header = string.Join(",", columnNames);
            lines.Add(header);

            var valueLines = queryResults.AsEnumerable()
                               .Select(row => string.Join(",", row.ItemArray));
            lines.AddRange(valueLines);

            if (File.Exists(finalPath))
            {
                DialogResult overwrite = MessageBox.Show("File " + finalPath + " already exists! \n Overwrite?", "Overwrite File", MessageBoxButtons.YesNo);
                if(overwrite == DialogResult.Yes)
                {
                    File.WriteAllLines(finalPath, lines.ToArray());
                }
                else
                {
                    return;
                }
            }
            else
            {
                File.WriteAllLines(finalPath, lines.ToArray());
            }   
        }
    }
}
