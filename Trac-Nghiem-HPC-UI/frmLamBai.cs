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
using Trac_Nghiem_HPC_UI.DemoData;

namespace Trac_Nghiem_HPC_UI
{
    public partial class frmLamBai : DevExpress.XtraEditors.DirectXForm
    {
        private int thoigian = 1 * 60; // 15 phút = 15 * 60 giây
        private int demgiay = 1;
        public frmLamBai()
        {
            InitializeComponent();
        }

        private void frmLamBai_Load(object sender, EventArgs e)
        {
            loadCauHoi();
            stepProgressBarItem1.Progress = 100;

            // Bắt đầu Timer
            timer1.Start();
        }
        private void loadCauHoi()
        {
            List<CauHoi> listCauHoi = new List<CauHoi>();
            for (int i = 0; i < 40; i++)
            {
                CauHoi hoi = new CauHoi();
                hoi._id = (i + 1).ToString();
                listCauHoi.Add(hoi);
            }
            gridControlDanhSachCauHoi.DataSource = listCauHoi;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Xử lý khi thời gian nhỏ hơn hoặc bằng 1/4 thời gian tổng
            if (demgiay < thoigian / 4)
            {
                int progress = (int)((demgiay / (float)(thoigian / 4)) * 100);
                stepProgressBarItem2.Progress = progress;
            }
            // Xử lý khi thời gian nhỏ hơn hoặc bằng 1/2 thời gian tổng
            else if (demgiay < thoigian / 2)
            {
                int progress = (int)(((demgiay - thoigian / 4) / (float)(thoigian / 4)) * 100);
                stepProgressBarItem3.Progress = progress;
            }
            // Xử lý khi thời gian nhỏ hơn hoặc bằng thời gian tổng
            else if (demgiay < thoigian-1)
            {
                int progress = (int)(((demgiay - thoigian / 2) / (float)(thoigian / 2)) * 100);
                stepProgressBarItem4.Progress = progress;
            }
            // Dừng Timer khi thời gian vượt quá thời gian tổng
            else
            {
                stepProgressBarItem4.Progress = 100; // Đảm bảo giá trị cuối cùng là 100%
                timer1.Stop();
            }

            demgiay++;
            UpdateTimeDisplay();
        }
        private void UpdateTimeDisplay()
        {
            int remainingSeconds = thoigian - demgiay;
            TimeSpan time = TimeSpan.FromSeconds(remainingSeconds);
            labelControl1.Text = $"{time.Minutes:D2}:{time.Seconds:D2}";
        }
    }
}