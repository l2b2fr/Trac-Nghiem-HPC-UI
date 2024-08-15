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
    public partial class frmDashboard : DevExpress.XtraEditors.DirectXForm
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void actrThoat_Click(object sender, EventArgs e)
        {
            var arg = new XtraMessageBoxArgs();
            arg.HtmlTemplate.Assign(htmlMesage);
            arg.Caption = "Thông báo";
            arg.Text = "Bạn có muốn thoát?";
            arg.DefaultButtonIndex = 0;
            var result = XtraMessageBox.Show(arg);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void actrDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}