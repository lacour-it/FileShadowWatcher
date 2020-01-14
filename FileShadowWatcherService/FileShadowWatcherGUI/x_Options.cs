using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using FileShadowWatcherShared;
using System.IO;

namespace FileShadowWatcherGUI
{
    public partial class x_Options : DevExpress.XtraEditors.XtraUserControl
    {
        public x_Options()
        {
            InitializeComponent();
            repositoryItemComboBoxWatcherChangeType.Items.AddRange(typeof(WatcherChangeTypes).GetEnumValues());
        }

        private GUIFactory gUIFactory;
        private List<WatcherFolderOption> Options;
        private List<EventExecutable> EventExecutables;

        public GUIFactory UIFactory
        {
            get { return gUIFactory; }
            set
            {
                gUIFactory = value;
                if (!gUIFactory.IsNull())
                {
                    comboBoxEditBufferSize.Properties.Items.AddRange(gUIFactory.CreateBufferSizes());
                    Options = gUIFactory.watcherFactory.optionsFactory.Options.WatcherFolderOptions;
                    EventExecutables = gUIFactory.watcherFactory.optionsFactory.Options.EventExecutables;
                    //watcherFolderOptionBindingSource.DataSource = Options;
                    //watcherFolderOptionBindingSource.ResetBindings(false);
                    //WatcherFolderOption option = Options[watcherFolderOptionBindingSource.Position];
                    //eventExecutableBindingSource.DataSource = gUIFactory.watcherFactory.GetEventExecutableByFolderGuid(gUIFactory.watcherFactory.optionsFactory.Options, option.FolderGUID);
                    eventExecutableBindingSource.DataSource = EventExecutables;
                    eventExecutableBindingSource.ResetBindings(false);
                    gridViewEventExecutables.ActiveFilterCriteria = new DevExpress.Data.Filtering.BinaryOperator("WatcherOptionGUID", Options[0].FolderGUID);
                }
            }
        }

        public void SetWatcherOptions(IEnumerable<WatcherFolderOption> watcherFolderOptions)
        {
            watcherFolderOptionBindingSource.DataSource = watcherFolderOptions;
            //Options = watcherFolderOptions.ToList();
            watcherFolderOptionBindingSource.ResetBindings(false);
        }

        public void SetWatcherOptionsPostion(int Position)
        {
            watcherFolderOptionBindingSource.Position = Position;
        }

        private void watcherFolderOptionBindingSource_PositionChanged(object sender, EventArgs e)
        {
            
            if (Options.IsNull())
                return;
            //WatcherFolderOption option = Options[watcherFolderOptionBindingSource.Position];
            //eventExecutableBindingSource.DataSource = gUIFactory.watcherFactory.GetEventExecutableByFolderGuid(gUIFactory.watcherFactory.optionsFactory.Options, option.FolderGUID);
            //eventExecutableBindingSource.ResetBindings(false);
            
            gridViewEventExecutables.ActiveFilterCriteria = new DevExpress.Data.Filtering.BinaryOperator("WatcherOptionGUID", Options[watcherFolderOptionBindingSource.Position].FolderGUID);
        }

        private void FolderPathTextEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (FolderBrowserDialog fd = new FolderBrowserDialog())
            {
                if (fd.ShowDialog()==DialogResult.OK)
                {
                    FolderPathTextEdit.Text = fd.SelectedPath;
                }
            }
        }

        private void TrashFolderTextEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (FolderBrowserDialog fd = new FolderBrowserDialog())
            {
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    TrashFolderTextEdit.Text = fd.SelectedPath;
                }
            }
        }

        private void gridEventExecutables_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
        }

        private void gridViewEventExecutables_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.SetRowCellValue(e.RowHandle, colWatcherOptionGUID, FolderGUIDTextEdit.Text);
        }

        private void repositoryItemButtonEditExecutable_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    gridViewEventExecutables.SetFocusedRowCellValue(colExecutablePath, fd.FileName);
                }
            }
        }

        private void gridViewEventExecutables_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            e.Row.ToString();
            var x = eventExecutableBindingSource.Current;
            //var z = 
        }
    }
}

