namespace QueryBatchTool
{
    partial class PopupExportMethod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exportButton = new System.Windows.Forms.Button();
            this.exportMethodGroupBox = new System.Windows.Forms.GroupBox();
            this.csvRadio = new System.Windows.Forms.RadioButton();
            this.excelRadio = new System.Windows.Forms.RadioButton();
            this.exportMethodGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(91, 129);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 30);
            this.exportButton.TabIndex = 1;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_click);
            // 
            // exportMethodGroupBox
            // 
            this.exportMethodGroupBox.Controls.Add(this.csvRadio);
            this.exportMethodGroupBox.Controls.Add(this.excelRadio);
            this.exportMethodGroupBox.Location = new System.Drawing.Point(28, 22);
            this.exportMethodGroupBox.Name = "exportMethodGroupBox";
            this.exportMethodGroupBox.Size = new System.Drawing.Size(200, 67);
            this.exportMethodGroupBox.TabIndex = 2;
            this.exportMethodGroupBox.TabStop = false;
            this.exportMethodGroupBox.Text = "Export Method";
            // 
            // csvRadio
            // 
            this.csvRadio.AutoSize = true;
            this.csvRadio.Location = new System.Drawing.Point(110, 29);
            this.csvRadio.Name = "csvRadio";
            this.csvRadio.Size = new System.Drawing.Size(84, 17);
            this.csvRadio.TabIndex = 1;
            this.csvRadio.TabStop = true;
            this.csvRadio.Text = "CSV (Faster)";
            this.csvRadio.UseVisualStyleBackColor = true;  
            // 
            // excelRadio
            // 
            this.excelRadio.AutoSize = true;
            this.excelRadio.Location = new System.Drawing.Point(31, 29);
            this.excelRadio.Name = "excelRadio";
            this.excelRadio.Size = new System.Drawing.Size(51, 17);
            this.excelRadio.TabIndex = 0;
            this.excelRadio.TabStop = true;
            this.excelRadio.Text = "Excel";
            this.excelRadio.UseVisualStyleBackColor = true;
            // 
            // PopupExportMethod
            // 
            this.AcceptButton = this.exportButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 171);
            this.Controls.Add(this.exportMethodGroupBox);
            this.Controls.Add(this.exportButton);
            this.Name = "PopupExportMethod";
            this.Text = "Export";
            this.Load += new System.EventHandler(this.PopupExportMethod_Load);
            this.exportMethodGroupBox.ResumeLayout(false);
            this.exportMethodGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.GroupBox exportMethodGroupBox;
        private System.Windows.Forms.RadioButton csvRadio;
        private System.Windows.Forms.RadioButton excelRadio;
    }
}