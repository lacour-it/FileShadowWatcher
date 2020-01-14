using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FileShadowWatcherShared;

namespace FileShadowWatcherGUI
{
    public partial class frmLogFile : DevExpress.XtraEditors.XtraForm
    {
        public frmLogFile()
        {
            InitializeComponent();
            memoEditLogFile.Text = slLogger.ReadLogFile("FileShadowWatcherService");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(memoEditLogFile.Text);
        }
    }
}