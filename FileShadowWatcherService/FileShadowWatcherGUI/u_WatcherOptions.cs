using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileShadowWatcherShared;
using System.IO;

namespace FileShadowWatcherGUI
{
    public partial class u_WatcherOptions : UserControl
    {
        public u_WatcherOptions()
        {
            InitializeComponent();
        }

        private GUIFactory gUIFactory;
        private List<WatcherFolderOption> Options;

        public GUIFactory UIFactory
        {
            get { return gUIFactory; }
            set 
            {
                gUIFactory = value;
                if (!gUIFactory.IsNull())
                {
                    Options = gUIFactory.watcherFactory.optionsFactory.Options.WatcherFolderOptions;
                    watcherFolderOptionBindingSource.DataSource = Options;
                    watcherFolderOptionBindingSource.ResetBindings(false);
                    GetEventCol();
                }
            }
        }

        private void GetEventCol()
        {
            DataGridViewComboBoxColumn colEvents = (DataGridViewComboBoxColumn)dataGridViewEvents.Columns["watcherChangeTypeDataGridViewTextBoxColumn"];
            colEvents.DataSource = Enum.GetValues(typeof(WatcherChangeTypes));
        }

        private void watcherFolderOptionBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            WatcherFolderOption option = Options[watcherFolderOptionBindingSource.Position];
            eventExecutableBindingSource.DataSource = option.EventExecutables;
            eventExecutableBindingSource.ResetBindings(false);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            WatcherFolderOption option = gUIFactory.watcherFactory.CreateNewWatcherInstance(@"x:\", false);
            Options.Add(option);
            watcherFolderOptionBindingSource.ResetBindings(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            gUIFactory.watcherFactory.optionsFactory.SaveOptions();
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Intance ?", "Deletion", MessageBoxButtons.YesNo) == DialogResult.OK)
            {
                WatcherFolderOption option = Options[watcherFolderOptionBindingSource.Position];
                Options.Remove(option);
            }
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = folderBrowserDialog.SelectedPath;
            }
            folderBrowserDialog.Dispose();
        }
    }
}
