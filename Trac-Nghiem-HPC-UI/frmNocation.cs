using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trac_Nghiem_HPC_UI
{
    public partial class frmNocation : DevExpress.XtraEditors.DirectXForm
    {
        public frmNocation()
        {
            InitializeComponent();
        }

        private void frmNocation_HtmlElementMouseClick(object sender, DevExpress.Utils.Html.DxHtmlElementMouseEventArgs e)
        {
            if (e.ElementId == "detail")
            {
                OpenLink("https://sinhvien.bachkhoahanoi.edu.vn/");
            }
            if (e.ElementId == "close")
            {
                this.Close();
            }
        }

        private void OpenLink(string url)
        {
            try
            {
                // Mở liên kết trong trình duyệt mặc định
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Đảm bảo sử dụng trình duyệt mặc định
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể mở liên kết: {ex.Message}");
            }
        }

        private void frmNocation_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}