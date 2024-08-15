using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trac_Nghiem_HPC_UI
{
    public partial class frmLoading : DevExpress.XtraEditors.DirectXForm
    {
        private int progressValue = 0;
        public frmLoading()
        {
            InitializeComponent();
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressValue += 1;
            progressBarControl1.Position = progressValue;

            if (progressValue >= 100)
            {
                timer1.Stop();
                this.Close();
                frmDashboard frmDashboard = new frmDashboard();
                frmDashboard.Show();
                alertControlSucces.Show(frmDashboard);
            }
        }

        private void alertControlSucces_HtmlElementMouseClick(object sender, DevExpress.XtraBars.Alerter.AlertHtmlElementMouseEventArgs e)
        {
            if (e.ElementId == "okButton") e.HtmlPopup.Close();
        }
    }
}