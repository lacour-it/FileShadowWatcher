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
    }
}
