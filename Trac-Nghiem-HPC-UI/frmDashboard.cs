using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trac_Nghiem_HPC_UI.UI;

namespace Trac_Nghiem_HPC_UI
{
    public partial class frmDashboard : DevExpress.XtraEditors.DirectXForm
    {
        private static ucDashboard ucDashboard;
        private static ucMonThi ucMonThi;
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
            accordionControlTrangChu.Appearance.Default.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            if(ucDashboard == null)
            {
                ucDashboard = new ucDashboard();
                ucDashboard.Dock = DockStyle.Fill;
                xtraUserControlMain.Controls.Clear();
                xtraUserControlMain.Controls.Add(ucDashboard);
            }
            else
            {
                ucDashboard.Dock = DockStyle.Fill;
                xtraUserControlMain.Controls.Clear();
                xtraUserControlMain.Controls.Add(ucDashboard);
            }
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
        private void accordionControlTrangChu_Click(object sender, EventArgs e)
        {
            loadMau(accordionControlTrangChu);
            if (ucDashboard == null)
            {
                ucDashboard = new ucDashboard();
                ucDashboard.Dock = DockStyle.Fill;
                xtraUserControlMain.Controls.Clear();
                xtraUserControlMain.Controls.Add(ucDashboard);
            }
            else
            {
                ucDashboard.Dock = DockStyle.Fill;
                xtraUserControlMain.Controls.Clear();
                xtraUserControlMain.Controls.Add(ucDashboard);
            }
        }
        private void accordionControlMonThi_Click(object sender, EventArgs e)
        {
            loadMau(accordionControlMonThi);
            if(ucMonThi == null)
            {
                ucMonThi = new ucMonThi();
                ucMonThi.Dock = DockStyle.Fill;
                xtraUserControlMain.Controls.Clear();
                xtraUserControlMain.Controls.Add(ucMonThi);
            }
            else
            {
                ucMonThi.Dock = DockStyle.Fill;
                xtraUserControlMain.Controls.Clear();
                xtraUserControlMain.Controls.Add(ucMonThi);
            }
        }

        private void accordionControlLichSuThi_Click(object sender, EventArgs e)
        {
            loadMau(accordionControlLichSuThi);
        }

        private void accordionControlThongTin_Click(object sender, EventArgs e)
        {
            loadMau(accordionControlThongTin);
        }

        private void loadMau(AccordionControlElement accordionControl)
        {
            accordionControlTrangChu.Appearance.Default.BackColor = Color.FromArgb(240, 240, 240);
            accordionControlMonThi.Appearance.Default.BackColor = Color.FromArgb(240, 240, 240);
            accordionControlThongTin.Appearance.Default.BackColor = Color.FromArgb(240, 240, 240);
            accordionControlLichSuThi.Appearance.Default.BackColor = Color.FromArgb(240, 240, 240);

            accordionControl.Appearance.Default.BackColor = Color.White;
        }

        private void htmlContentControl1_ElementMouseClick(object sender, DevExpress.Utils.Html.DxHtmlElementMouseEventArgs e)
        {
            if (e.ElementId == "point _red")
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
            if (e.ElementId == "point _green")
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
    }
}