using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using FileShadowWatcherShared;

namespace FileShadowWatcherGUI
{

    
    public class GUIFactory
    {
        frmMain frmMain;
        //public Control LastControl { get; set; }
        //u_WatcherOptions ctlWatcherOptions;
        internal WatcherFactory watcherFactory = new WatcherFactory();

        public GUIFactory(frmMain main)
        {
            frmMain = main;
            watcherFactory.InitializeFromGUI();
            watcherFactory.IsServiceInstalled();
        }

        /*public void RemoveLastControl()
        {
            if (LastControl.IsNull())
                return;
            frmMain.panelMain.Controls.Remove(LastControl);
        }

        public void AddWatcherOptionsControl()
        {
            if (ctlWatcherOptions.IsNull())
            {
                ctlWatcherOptions = new u_WatcherOptions();
                ctlWatcherOptions.Name = "ctlWatcherOptionsMain";
                ctlWatcherOptions.Dock = DockStyle.Fill;
            }
            RemoveLastControl();
            ctlWatcherOptions.UIFactory = this;
            frmMain.panelMain.Controls.Add(ctlWatcherOptions);
            LastControl = ctlWatcherOptions;
            frmMain.panelMain.Refresh();
        }*/

        internal void GetServiceStats()
        {
            frmMain.barEditItemInstalled.EditValue = watcherFactory.ServiceInstalled;
            if (watcherFactory.ServiceInstalled)
            {
                frmMain.barEditItemRunning.EditValue = watcherFactory.IsServiceRunning();
                frmMain.barEditItemPaused.EditValue = watcherFactory.IsServicePaused();
            }
        }

        internal void StartService()
        {
            if (watcherFactory.ServiceInstalled)
            {
                if (!watcherFactory.IsServiceRunning() && !watcherFactory.IsServicePaused())
                {
                    watcherFactory.StartService();
                }
                GetServiceStats();
            }
        }

        internal void StopService()
        {
            if (watcherFactory.ServiceInstalled)
            {
                if (watcherFactory.IsServiceRunning() && !watcherFactory.IsServicePaused())
                {
                    watcherFactory.StopService();
                    GetServiceStats();
                }
            }
        }

        internal void PauseService()
        {
            if (watcherFactory.ServiceInstalled)
            {
                if (watcherFactory.IsServiceRunning() && !watcherFactory.IsServicePaused())
                {
                    watcherFactory.PauseService();
                    GetServiceStats();
                }
            }
        }

        internal void ContinueService()
        {
            if (watcherFactory.ServiceInstalled)
            {
                if (!watcherFactory.IsServiceRunning() && watcherFactory.IsServicePaused())
                {
                    watcherFactory.ContinueService();
                    GetServiceStats();
                }
            }
        }

        internal void ReStartService()
        {
            if (watcherFactory.ServiceInstalled)
            {
                    watcherFactory.ReStartService();
                    GetServiceStats();
            }
        }

        internal void SaveOptions()
        {
            watcherFactory.optionsFactory.SaveOptions();
        }

        internal void AddOption()
        {
            WatcherFolderOption option = watcherFactory.CreateNewWatcherInstance(@"x:\", false);
            watcherFactory.optionsFactory.Options.WatcherFolderOptions.Add(option);
        }

        internal void AddEventExecutable(string OptionsGUID)
        {
            EventExecutable eventExecutable = new EventExecutable();
            eventExecutable.WatcherOptionGUID = OptionsGUID;
            watcherFactory.optionsFactory.Options.EventExecutables.Add(eventExecutable);
        }

        internal void ShowLogFile()
        {
            using (frmLogFile frmLog = new frmLogFile())
            {
                frmLog.ShowDialog();
            }
        }

        internal List<string> CreateBufferSizes()
        {
            List<string> BufferSizes = new List<string>();
            int x = 4096;
            for (int i = 1; i <= 16; i++)
            {
                int y = x * i;
                BufferSizes.Add(y.ToString());
            }
            return BufferSizes;
        }

        internal List<string> GetAssemblyInfo()
        {
            List<string> infos = new List<string>();
            Assembly assembly = Assembly.GetEntryAssembly();
            infos.Add(Application.ProductName);
            infos.Add(Application.ProductVersion);
            infos.Add(Application.CompanyName);
            infos.Add(assembly.Location);
            infos.Add(assembly.FullName);
            return infos;
        }

        internal void ShowAbout()
        {
            frmAbout fAbout = new frmAbout();
            fAbout.SetAbout(GetAssemblyInfo());
            fAbout.ShowDialog();
        }
    }
}
