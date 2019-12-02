namespace FileShadowWatcherGUI
{
    partial class f_Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxBackupPath = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItemBackupPath = new System.Windows.Forms.ToolStripMenuItem();
            this.testVSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testInitializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testPowerForensicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileReToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allFileRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletedFileRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.restoreFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.toolStripTextBoxBackupPath,
            this.toolStripMenuItemBackupPath,
            this.testVSSToolStripMenuItem,
            this.testPowerForensicsToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 27);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 23);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // toolStripTextBoxBackupPath
            // 
            this.toolStripTextBoxBackupPath.Name = "toolStripTextBoxBackupPath";
            this.toolStripTextBoxBackupPath.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripMenuItemBackupPath
            // 
            this.toolStripMenuItemBackupPath.Name = "toolStripMenuItemBackupPath";
            this.toolStripMenuItemBackupPath.Size = new System.Drawing.Size(82, 23);
            this.toolStripMenuItemBackupPath.Text = "BackupPath";
            this.toolStripMenuItemBackupPath.Click += new System.EventHandler(this.toolStripMenuItemBackupPath_Click);
            // 
            // testVSSToolStripMenuItem
            // 
            this.testVSSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testInitializeToolStripMenuItem});
            this.testVSSToolStripMenuItem.Name = "testVSSToolStripMenuItem";
            this.testVSSToolStripMenuItem.Size = new System.Drawing.Size(62, 23);
            this.testVSSToolStripMenuItem.Text = "Test VSS";
            // 
            // testInitializeToolStripMenuItem
            // 
            this.testInitializeToolStripMenuItem.Name = "testInitializeToolStripMenuItem";
            this.testInitializeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.testInitializeToolStripMenuItem.Text = "Test Initialize";
            this.testInitializeToolStripMenuItem.Click += new System.EventHandler(this.testInitializeToolStripMenuItem_Click);
            // 
            // testPowerForensicsToolStripMenuItem
            // 
            this.testPowerForensicsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileReToolStripMenuItem,
            this.allFileRecordsToolStripMenuItem,
            this.deletedFileRecordsToolStripMenuItem,
            this.deletedFileToolStripMenuItem,
            this.restoreFileToolStripMenuItem});
            this.testPowerForensicsToolStripMenuItem.Name = "testPowerForensicsToolStripMenuItem";
            this.testPowerForensicsToolStripMenuItem.Size = new System.Drawing.Size(128, 23);
            this.testPowerForensicsToolStripMenuItem.Text = "Test Power Forensics";
            // 
            // fileReToolStripMenuItem
            // 
            this.fileReToolStripMenuItem.Name = "fileReToolStripMenuItem";
            this.fileReToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fileReToolStripMenuItem.Text = "Forensic File Record";
            this.fileReToolStripMenuItem.Click += new System.EventHandler(this.fileReToolStripMenuItem_Click);
            // 
            // allFileRecordsToolStripMenuItem
            // 
            this.allFileRecordsToolStripMenuItem.Name = "allFileRecordsToolStripMenuItem";
            this.allFileRecordsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allFileRecordsToolStripMenuItem.Text = "All File Records";
            // 
            // deletedFileRecordsToolStripMenuItem
            // 
            this.deletedFileRecordsToolStripMenuItem.Name = "deletedFileRecordsToolStripMenuItem";
            this.deletedFileRecordsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deletedFileRecordsToolStripMenuItem.Text = "Deleted File Records";
            this.deletedFileRecordsToolStripMenuItem.Click += new System.EventHandler(this.deletedFileRecordsToolStripMenuItem_Click);
            // 
            // deletedFileToolStripMenuItem
            // 
            this.deletedFileToolStripMenuItem.Name = "deletedFileToolStripMenuItem";
            this.deletedFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deletedFileToolStripMenuItem.Text = "Deleted File";
            this.deletedFileToolStripMenuItem.Click += new System.EventHandler(this.deletedFileToolStripMenuItem_Click);
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(88, 36);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(610, 481);
            this.panelMain.TabIndex = 1;
            // 
            // restoreFileToolStripMenuItem
            // 
            this.restoreFileToolStripMenuItem.Name = "restoreFileToolStripMenuItem";
            this.restoreFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restoreFileToolStripMenuItem.Text = "RestoreFile";
            this.restoreFileToolStripMenuItem.Click += new System.EventHandler(this.restoreFileToolStripMenuItem_Click);
            // 
            // f_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "f_Main";
            this.Text = "Form1";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        internal System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxBackupPath;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBackupPath;
        private System.Windows.Forms.ToolStripMenuItem testVSSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testInitializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testPowerForensicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileReToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allFileRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletedFileRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletedFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreFileToolStripMenuItem;
    }
}

