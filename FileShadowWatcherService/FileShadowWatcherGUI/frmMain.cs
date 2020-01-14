using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using FileShadowWatcherShared;

namespace FileShadowWatcherGUI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public GUIFactory GUI { get; set; }
        public frmMain()
        {
            InitializeComponent();
            GUI = new GUIFactory(this);
            bindingSourceOptions.DataSource = GUI.watcherFactory.optionsFactory.Options.WatcherFolderOptions;
            bindingSourceOptions.ResetBindings(false);
            x_Options1.SetWatcherOptions(GUI.watcherFactory.optionsFactory.Options.WatcherFolderOptions);
            x_Options1.UIFactory = GUI;
            GUI.GetServiceStats();
            timerService.Enabled = true;
        }

        private void bindingSourceOptions_CurrentChanged(object sender, EventArgs e)
        {
            x_Options1.SetWatcherOptionsPostion(bindingSourceOptions.Position);
        }

        private void bindingSourceOptions_PositionChanged(object sender, EventArgs e)
        {
            x_Options1.SetWatcherOptionsPostion(bindingSourceOptions.Position);
        }

        private void timerService_Tick(object sender, EventArgs e)
        {
            GUI.GetServiceStats();
        }

        private void btnStart_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUI.StartService();
        }

        private void btnStop_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUI.StopService();
        }

        private void btnPause_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUI.PauseService();
        }

        private void btnContinue_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUI.ContinueService();
        }

        private void btnRestart_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUI.ReStartService();
        }

        private void btnAddOption_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUI.AddOption();
            bindingSourceOptions.Position = bindingSourceOptions.Count - 1;
            tileViewOptions.RefreshData();
        }

        private void btnSaveOptions_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUI.SaveOptions();
        }

        private void btnDeleteOption_ItemClick(object sender, ItemClickEventArgs e)
        {
            bindingSourceOptions.RemoveCurrent();
        }

        private void btnShowLogFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUI.ShowLogFile();
        }

        private void btnAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            GUI.ShowAbout();
        }
    }
}