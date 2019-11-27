using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileShadowWatcherShared;

namespace FileShadowWatcherGUI
{

    
    public class GUIFactory
    {
        f_Main frmMain;
        public Control LastControl { get; set; }
        u_WatcherOptions ctlWatcherOptions;
        internal WatcherFactory watcherFactory = new WatcherFactory();

        public GUIFactory(f_Main main)
        {
            frmMain = main;
            watcherFactory.InitializeFromGUI();
            AddWatcherOptionsControl();
        }

        public void RemoveLastControl()
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
        }

    }
}
