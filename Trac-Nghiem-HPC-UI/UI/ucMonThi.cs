using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
            loadBaiKiemTra();
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
            htmlContentControl1.DataContext = monThiList[0];
        }

        private void tileView1_ItemClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            /**
            var gridControl = tileView1.GridControl;

            if (gridControl == null || gridControl.DataSource == null)
            {
                MessageBox.Show("Grid control hoặc data không có dữ liệu");
                return;
            }

            var selectedIndex = e.Item.RowHandle;

            if (gridControl.DataSource is DataTable dataTable)
            {
                if (selectedIndex >= 0 && selectedIndex < dataTable.Rows.Count)
                {
                    var tenMonThi = dataTable.Rows[selectedIndex]["TenMonThi"]?.ToString();
                    MessageBox.Show(tenMonThi);
                }
                else
                {
                    MessageBox.Show("Chỉ mục hàng không hợp lệ được chọn.");
                }
            }
            else if (gridControl.DataSource is List<MonThi> dataList)
            {
                if (selectedIndex >= 0 && selectedIndex < dataList.Count)
                {
                    var tenMonThi = dataList[selectedIndex].TenMonThi?.ToString();
                    MessageBox.Show(tenMonThi);
                }
                else
                {
                    MessageBox.Show("Chỉ mục hàng không hợp lệ được chọn.");
                }
            }
            else
            {
                MessageBox.Show("Loại nguồn dữ liệu không được hỗ trợ.");
            }
            **/
        }

        private void tileView1_HtmlElementMouseClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewHtmlElementMouseEventArgs e)
        {
            if(e.ElementId == "detailButton")
            {
                var gridControl = tileView1.GridControl;

                if (gridControl == null || gridControl.DataSource == null)
                {
                    MessageBox.Show("Grid control hoặc data không có dữ liệu");
                    return;
                }

                var selectedIndex = e.RowHandle;

                if (gridControl.DataSource is DataTable dataTable)
                {
                    if (selectedIndex >= 0 && selectedIndex < dataTable.Rows.Count)
                    {
                        var tenMonThi = dataTable.Rows[selectedIndex]["TenMonThi"]?.ToString();
                        MessageBox.Show(tenMonThi);
                    }
                    else
                    {
                        MessageBox.Show("Chỉ mục hàng không hợp lệ được chọn.");
                    }
                }
                else if (gridControl.DataSource is List<MonThi> dataList)
                {
                    if (selectedIndex >= 0 && selectedIndex < dataList.Count)
                    {
                        var tenMonThi = dataList[selectedIndex].TenMonThi?.ToString();
                        List<MonThi> monThis = new List<MonThi>();
                        monThis.Add(dataList[selectedIndex]);
                        htmlContentControl1.DataContext = monThis;
                    }
                    else
                    {
                        MessageBox.Show("Chỉ mục hàng không hợp lệ được chọn.");
                    }
                }
                else
                {
                    MessageBox.Show("Loại nguồn dữ liệu không được hỗ trợ.");
                }
            }
        }

        private void loadBaiKiemTra()
        {
            // Tạo danh sách để chứa các bài kiểm tra
            List<BaiKiemTra> danhSachBaiKiemTra = new List<BaiKiemTra>();

            // Tạo 5 bài kiểm tra giả
            BaiKiemTra baiKiemTra1 = new BaiKiemTra(
                "Kiểm tra lập trình C# cơ bản",
                "Kiểm tra kiến thức cơ bản về lập trình C#, bao gồm cú pháp, biến, và vòng lặp.",
                45
            );

            BaiKiemTra baiKiemTra2 = new BaiKiemTra(
                "Kiểm tra hệ điều hành",
                "Đánh giá kiến thức về các khái niệm cơ bản của hệ điều hành, như quản lý tiến trình và bộ nhớ.",
                60
            );

            BaiKiemTra baiKiemTra3 = new BaiKiemTra(
                "Kiểm tra mạng máy tính",
                "Kiểm tra hiểu biết về các mô hình OSI, giao thức TCP/IP, và các khái niệm mạng cơ bản.",
                50
            );

            BaiKiemTra baiKiemTra4 = new BaiKiemTra(
                "Kiểm tra cơ sở dữ liệu",
                "Kiểm tra kiến thức về các khái niệm cơ bản của cơ sở dữ liệu, SQL và các thao tác với dữ liệu.",
                40
            );

            BaiKiemTra baiKiemTra5 = new BaiKiemTra(
                "Kiểm tra cấu trúc dữ liệu và giải thuật",
                "Đánh giá khả năng hiểu và áp dụng các cấu trúc dữ liệu và giải thuật trong lập trình.",
                55
            );

            // Thêm các bài kiểm tra vào danh sách
            danhSachBaiKiemTra.Add(baiKiemTra1);
            danhSachBaiKiemTra.Add(baiKiemTra2);
            danhSachBaiKiemTra.Add(baiKiemTra3);
            danhSachBaiKiemTra.Add(baiKiemTra4);
            danhSachBaiKiemTra.Add(baiKiemTra5);

            gridControl2.DataSource = danhSachBaiKiemTra;
        }

        private void tileView2_HtmlElementMouseClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewHtmlElementMouseEventArgs e)
        {
            if(e.ElementId == "kiemTraButton")
            {
                var selectedIndex = e.RowHandle;
                if (gridControl2.DataSource is List<BaiKiemTra> dataList)
                {
                    if (selectedIndex >= 0 && selectedIndex < dataList.Count)
                    {
                        var tenBaiKiemTra = dataList[selectedIndex].TenBaiKiemTra?.ToString();
                        List<BaiKiemTra> monThis = new List<BaiKiemTra>();
                        monThis.Add(dataList[selectedIndex]);
                        frmLamBai frmLamBai = new frmLamBai();
                        frmLamBai.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Chỉ mục hàng không hợp lệ được chọn.");
                    }
                }
            }
        }
    }
}
