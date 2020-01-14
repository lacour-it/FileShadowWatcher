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

namespace FileShadowWatcherGUI
{
    public partial class frmAbout : DevExpress.XtraEditors.XtraForm
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        internal void SetAbout(List<string> Infos)
        {
            textEditName.Text = Infos[0];
            textEditVersion.Text = Infos[1];
            textEditCompany.Text = Infos[2];
            textEditPath.Text = Infos[3];
            textEditAssembly.Text = Infos[4];
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}