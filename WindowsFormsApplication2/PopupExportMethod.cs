using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueryBatchTool
{
    public partial class PopupExportMethod : Form
    {
        public PopupExportMethod()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            excelRadio.Checked = true;
        }

        private void PopupExportMethod_Load(object sender, EventArgs e)
        {
            // Method intentionally left empty.
        }

        private void exportButton_click(object sender, EventArgs e)
        {
            //Call form from main as Dialog Result to avoid new instance
            if (excelRadio.Checked == true)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
            this.Close();
        }
    }
}
