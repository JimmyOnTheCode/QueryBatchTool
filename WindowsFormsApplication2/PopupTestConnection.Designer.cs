namespace QueryBatchTool
{
    partial class PopupTestConnection
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
            this.systemName = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.systemNameLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.port = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.serverName = new System.Windows.Forms.TextBox();
            this.database = new System.Windows.Forms.TextBox();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.driverTypeBox = new System.Windows.Forms.GroupBox();
            this.pgsqlRadio = new System.Windows.Forms.RadioButton();
            this.db2Radio = new System.Windows.Forms.RadioButton();
            this.sqlServerRadio = new System.Windows.Forms.RadioButton();
            this.driverTypeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // systemName
            // 
            this.systemName.Location = new System.Drawing.Point(117, 92);
            this.systemName.Name = "systemName";
            this.systemName.Size = new System.Drawing.Size(171, 20);
            this.systemName.TabIndex = 5;
            this.systemName.Visible = false;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(117, 196);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(171, 20);
            this.username.TabIndex = 8;
            this.username.Visible = false;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(117, 222);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(170, 20);
            this.password.TabIndex = 9;
            this.password.Visible = false;
            // 
            // systemNameLabel
            // 
            this.systemNameLabel.AutoSize = true;
            this.systemNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.systemNameLabel.Location = new System.Drawing.Point(36, 95);
            this.systemNameLabel.Name = "systemNameLabel";
            this.systemNameLabel.Size = new System.Drawing.Size(75, 13);
            this.systemNameLabel.TabIndex = 4;
            this.systemNameLabel.Text = "System Name:";
            this.systemNameLabel.Visible = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(36, 199);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Username:";
            this.usernameLabel.Visible = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(36, 225);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.Visible = false;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(132, 264);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(88, 27);
            this.connectButton.TabIndex = 10;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.button1ConnectButton_Click);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(117, 157);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(170, 20);
            this.port.TabIndex = 7;
            this.port.Visible = false;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(36, 160);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(29, 13);
            this.portLabel.TabIndex = 9;
            this.portLabel.Text = "Port:";
            this.portLabel.Visible = false;
            // 
            // serverName
            // 
            this.serverName.Location = new System.Drawing.Point(117, 92);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(172, 20);
            this.serverName.TabIndex = 4;
            this.serverName.Visible = false;
            // 
            // database
            // 
            this.database.Location = new System.Drawing.Point(117, 129);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(170, 20);
            this.database.TabIndex = 6;
            this.database.Visible = false;
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Location = new System.Drawing.Point(36, 132);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(56, 13);
            this.databaseLabel.TabIndex = 12;
            this.databaseLabel.Text = "Database:";
            this.databaseLabel.Visible = false;
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.Location = new System.Drawing.Point(36, 95);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(72, 13);
            this.serverNameLabel.TabIndex = 13;
            this.serverNameLabel.Text = "Server Name:";
            this.serverNameLabel.Visible = false;
            // 
            // driverTypeBox
            // 
            this.driverTypeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.driverTypeBox.Controls.Add(this.sqlServerRadio);
            this.driverTypeBox.Controls.Add(this.pgsqlRadio);
            this.driverTypeBox.Controls.Add(this.db2Radio);
            this.driverTypeBox.Location = new System.Drawing.Point(39, 13);
            this.driverTypeBox.Name = "driverTypeBox";
            this.driverTypeBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.driverTypeBox.Size = new System.Drawing.Size(274, 60);
            this.driverTypeBox.TabIndex = 1;
            this.driverTypeBox.TabStop = false;
            this.driverTypeBox.Text = "Driver Type";
            // 
            // pgsqlRadio
            // 
            this.pgsqlRadio.AutoSize = true;
            this.pgsqlRadio.Location = new System.Drawing.Point(93, 29);
            this.pgsqlRadio.Name = "pgsqlRadio";
            this.pgsqlRadio.Size = new System.Drawing.Size(82, 17);
            this.pgsqlRadio.TabIndex = 3;
            this.pgsqlRadio.TabStop = true;
            this.pgsqlRadio.Text = "PostgreSQL";
            this.pgsqlRadio.UseVisualStyleBackColor = true;
            this.pgsqlRadio.CheckedChanged += new System.EventHandler(this.AllCheckBoxes_CheckedChanged);
            // 
            // db2Radio
            // 
            this.db2Radio.AutoSize = true;
            this.db2Radio.Location = new System.Drawing.Point(23, 29);
            this.db2Radio.Name = "db2Radio";
            this.db2Radio.Size = new System.Drawing.Size(46, 17);
            this.db2Radio.TabIndex = 2;
            this.db2Radio.TabStop = true;
            this.db2Radio.Text = "DB2";
            this.db2Radio.UseVisualStyleBackColor = true;
            this.db2Radio.CheckedChanged += new System.EventHandler(this.AllCheckBoxes_CheckedChanged);
            // 
            // sqlServerRadio
            // 
            this.sqlServerRadio.AutoSize = true;
            this.sqlServerRadio.Location = new System.Drawing.Point(181, 29);
            this.sqlServerRadio.Name = "sqlServerRadio";
            this.sqlServerRadio.Size = new System.Drawing.Size(80, 17);
            this.sqlServerRadio.TabIndex = 4;
            this.sqlServerRadio.TabStop = true;
            this.sqlServerRadio.Text = "SQL Server";
            this.sqlServerRadio.UseVisualStyleBackColor = true;
            this.sqlServerRadio.CheckedChanged += new System.EventHandler(this.AllCheckBoxes_CheckedChanged);
            // 
            // PopupTestConnection
            // 
            this.AcceptButton = this.connectButton;
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 312);
            this.Controls.Add(this.driverTypeBox);
            this.Controls.Add(this.serverNameLabel);
            this.Controls.Add(this.databaseLabel);
            this.Controls.Add(this.database);
            this.Controls.Add(this.serverName);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.port);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.systemNameLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.systemName);
            this.Name = "PopupTestConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ODBC Connection";
            this.Load += new System.EventHandler(this.PopupTestConnection_Load);
            this.driverTypeBox.ResumeLayout(false);
            this.driverTypeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PgsqlRadio_CheckedChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }


        #endregion

        private System.Windows.Forms.TextBox systemName;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label systemNameLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox serverName;
        private System.Windows.Forms.TextBox database;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.Label serverNameLabel;
        private System.Windows.Forms.GroupBox driverTypeBox;
        private System.Windows.Forms.RadioButton pgsqlRadio;
        private System.Windows.Forms.RadioButton db2Radio;
        private System.Windows.Forms.RadioButton sqlServerRadio;
    }
}