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
using Trac_Nghiem_HPC_UI.DemoData;

namespace Trac_Nghiem_HPC_UI.UI
{
    public partial class ucMonThi : DevExpress.XtraEditors.XtraUserControl
    {
        private List<MonThi> monThiList;
        public ucMonThi()
        {
            InitializeComponent();
        }

        private void ucMonThi_Load(object sender, EventArgs e)
        {
            loadMonThi();
        }
        private void loadMonThi()
        {
            monThiList = new List<MonThi>();
            for (int i = 0; i < 10; i++)
            {
                MonThi monThi = new MonThi
                {
                    TenMonThi = "Tên Môn Thi " + i,
                    ChiTietMonThi = "Chi Tiết Môn Thi " + i,
                    Photo = imageCollection1.Images[i]
                };
                monThiList.Add(monThi);
            }
            gridControl1.DataSource = monThiList;
        }
    }
}
