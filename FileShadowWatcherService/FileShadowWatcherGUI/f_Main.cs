using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileShadowWatcherShared;
using PowerForensics.FileSystems.Ntfs;

namespace FileShadowWatcherGUI
{
    public partial class f_Main : Form
    {

        public GUIFactory GUI { get; set; }
        public f_Main()
        {
            InitializeComponent();
            GUI = new GUIFactory(this);
            toolStripTextBoxBackupPath.Text = GUI.watcherFactory.optionsFactory.Options.BackupRootPath;
        }

        private void toolStripMenuItemBackupPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog()==DialogResult.OK)
            {
                toolStripTextBoxBackupPath.Text = folderBrowserDialog.SelectedPath;
                GUI.watcherFactory.optionsFactory.Options.BackupRootPath = toolStripTextBoxBackupPath.Text;
                GUI.watcherFactory.optionsFactory.SaveOptions();
            }
        }

        private void testInitializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestFactory.InitializeVSS();
        }

        private void fileReToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void deletedFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileRecord fileRecord = GUI.watcherFactory.forensicsFactory.GetDeletedInstance(@"E:\BriefPrivat.dotx");
            if (!fileRecord.IsNull())
                MessageBox.Show(fileRecord.FullName + " found at " + fileRecord.Directory);
        }

        private void deletedFileRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<FileRecord> fileRecords = GUI.watcherFactory.forensicsFactory.GetDeletedInstances("E:");
        }

        private void restoreFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string answer = GUI.watcherFactory.forensicsFactory.RestoreDeletedFile(@"E:\BriefPrivat.dotx", @"C:\BriefPrivat.dotx");
            MessageBox.Show(answer);
        }
    }
}
