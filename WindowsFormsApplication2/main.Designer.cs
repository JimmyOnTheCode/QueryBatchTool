namespace QueryBatchTool
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button1PrepareFiles = new System.Windows.Forms.Button();
            this.button2VerifyFiles = new System.Windows.Forms.Button();
            this.button3DatabaseConnection = new System.Windows.Forms.Button();
            this.button4RunQuery = new System.Windows.Forms.Button();
            this.button5Exit = new System.Windows.Forms.Button();
            this.button6Kill = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1PrepareFiles
            // 
            this.button1PrepareFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1PrepareFiles.Location = new System.Drawing.Point(36, 205);
            this.button1PrepareFiles.Name = "button1PrepareFiles";
            this.button1PrepareFiles.Size = new System.Drawing.Size(125, 49);
            this.button1PrepareFiles.TabIndex = 0;
            this.button1PrepareFiles.Text = "1.Prepare Files";
            this.button1PrepareFiles.UseVisualStyleBackColor = true;
            this.button1PrepareFiles.Click += new System.EventHandler(this.button1PrepareFiles_Click);
            // 
            // button2VerifyFiles
            // 
            this.button2VerifyFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2VerifyFiles.Location = new System.Drawing.Point(193, 205);
            this.button2VerifyFiles.Name = "button2VerifyFiles";
            this.button2VerifyFiles.Size = new System.Drawing.Size(125, 49);
            this.button2VerifyFiles.TabIndex = 1;
            this.button2VerifyFiles.Text = "2.Verify Files";
            this.button2VerifyFiles.UseVisualStyleBackColor = true;
            this.button2VerifyFiles.Click += new System.EventHandler(this.button2VerifyFiles_Click);
            // 
            // button3DatabaseConnection
            // 
            this.button3DatabaseConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3DatabaseConnection.Location = new System.Drawing.Point(351, 205);
            this.button3DatabaseConnection.Name = "button3DatabaseConnection";
            this.button3DatabaseConnection.Size = new System.Drawing.Size(125, 49);
            this.button3DatabaseConnection.TabIndex = 2;
            this.button3DatabaseConnection.Text = "3.Database Connection";
            this.button3DatabaseConnection.UseVisualStyleBackColor = true;
            this.button3DatabaseConnection.Click += new System.EventHandler(this.button3DatabaseConnection_Click);
            // 
            // button4RunQuery
            // 
            this.button4RunQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4RunQuery.Location = new System.Drawing.Point(510, 204);
            this.button4RunQuery.Name = "button4RunQuery";
            this.button4RunQuery.Size = new System.Drawing.Size(125, 49);
            this.button4RunQuery.TabIndex = 3;
            this.button4RunQuery.Text = "4.Run Queries";
            this.button4RunQuery.UseVisualStyleBackColor = true;
            this.button4RunQuery.Click += new System.EventHandler(this.button4RunQueries_Click);
            // 
            // button5Exit
            // 
            this.button5Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5Exit.Location = new System.Drawing.Point(663, 204);
            this.button5Exit.Name = "button5Exit";
            this.button5Exit.Size = new System.Drawing.Size(125, 49);
            this.button5Exit.TabIndex = 4;
            this.button5Exit.Text = "5.Exit";
            this.button5Exit.UseVisualStyleBackColor = true;
            this.button5Exit.Click += new System.EventHandler(this.button5Exit_Click);
            // 
            // button6Kill
            // 
            this.button6Kill.BackColor = System.Drawing.Color.Firebrick;
            this.button6Kill.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6Kill.Location = new System.Drawing.Point(541, 277);
            this.button6Kill.Name = "button6Kill";
            this.button6Kill.Size = new System.Drawing.Size(64, 31);
            this.button6Kill.TabIndex = 5;
            this.button6Kill.Text = "Kill";
            this.button6Kill.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button6Kill.UseVisualStyleBackColor = false;
            this.button6Kill.Click += new System.EventHandler(this.button6Kill_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(364, 354);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(792, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 5);
            this.label1.TabIndex = 7;
            this.label1.Text = "JimmyOnTheCode";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(827, 488);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button6Kill);
            this.Controls.Add(this.button5Exit);
            this.Controls.Add(this.button4RunQuery);
            this.Controls.Add(this.button3DatabaseConnection);
            this.Controls.Add(this.button2VerifyFiles);
            this.Controls.Add(this.button1PrepareFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Query Batch Tool";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1PrepareFiles;
        private System.Windows.Forms.Button button2VerifyFiles;
        private System.Windows.Forms.Button button3DatabaseConnection;
        private System.Windows.Forms.Button button4RunQuery;
        private System.Windows.Forms.Button button5Exit;
        private System.Windows.Forms.Button button6Kill;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;

    }
}

