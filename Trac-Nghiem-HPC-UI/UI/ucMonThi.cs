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
            monThiList = new List<MonThi>
                {
                    new MonThi
                    {
                        TenMonThi = "Lập Trình C#",
                        ChiTietMonThi = "Khóa học về lập trình ứng dụng desktop và web bằng C#. Sinh viên sẽ học cách sử dụng ngôn ngữ lập trình C# để phát triển các ứng dụng thực tế, bao gồm cả giao diện người dùng và xử lý dữ liệu.",
                        Photo = imageCollection1.Images[0]
                    },
                    new MonThi
                    {
                        TenMonThi = "Cơ Sở Dữ Liệu",
                        ChiTietMonThi = "Nghiên cứu về quản lý và thiết kế cơ sở dữ liệu. Khóa học này sẽ cung cấp cho sinh viên kiến thức về các hệ quản trị cơ sở dữ liệu, ngôn ngữ truy vấn SQL và các kỹ thuật tối ưu hóa hiệu suất.",
                        Photo = imageCollection1.Images[1]
                    },
                    new MonThi
                    {
                        TenMonThi = "Mạng Máy Tính",
                        ChiTietMonThi = "Khóa học về cấu trúc và quản lý mạng máy tính. Sinh viên sẽ tìm hiểu về các giao thức mạng, thiết bị mạng, và cách thiết lập và bảo trì một mạng máy tính hiệu quả.",
                        Photo = imageCollection1.Images[2]
                    },
                    new MonThi
                    {
                        TenMonThi = "An Ninh Mạng",
                        ChiTietMonThi = "Nghiên cứu về bảo mật thông tin và an ninh mạng. Khóa học này sẽ giúp sinh viên hiểu các mối đe dọa an ninh, các biện pháp bảo vệ dữ liệu và cách phát hiện và ứng phó với các cuộc tấn công mạng.",
                        Photo = imageCollection1.Images[3]
                    },
                    new MonThi
                    {
                        TenMonThi = "Phát Triển Web",
                        ChiTietMonThi = "Khóa học về thiết kế và phát triển website. Sinh viên sẽ học cách sử dụng HTML, CSS, JavaScript và các framework phổ biến để tạo ra các trang web tương tác và thân thiện với người dùng.",
                        Photo = imageCollection1.Images[4]
                    },
                    new MonThi
                    {
                        TenMonThi = "Trí Tuệ Nhân Tạo",
                        ChiTietMonThi = "Khóa học về các thuật toán và ứng dụng trí tuệ nhân tạo. Sinh viên sẽ tìm hiểu về machine learning, deep learning và cách áp dụng các công nghệ này để giải quyết các bài toán thực tế.",
                        Photo = imageCollection1.Images[5]
                    },
                    new MonThi
                    {
                        TenMonThi = "Khoa Học Dữ Liệu",
                        ChiTietMonThi = "Nghiên cứu về phân tích và xử lý dữ liệu lớn. Khóa học này sẽ cung cấp cho sinh viên các kỹ thuật thu thập, phân tích và trực quan hóa dữ liệu để hỗ trợ ra quyết định.",
                        Photo = imageCollection1.Images[6]
                    },
                    new MonThi
                    {
                        TenMonThi = "Lập Trình Di Động",
                        ChiTietMonThi = "Khóa học về phát triển ứng dụng di động trên Android và iOS. Sinh viên sẽ học cách sử dụng các ngôn ngữ lập trình như Java, Kotlin và Swift để xây dựng ứng dụng di động chất lượng cao.",
                        Photo = imageCollection1.Images[7]
                    },
                    new MonThi
                    {
                        TenMonThi = "Công Nghệ Phần Mềm",
                        ChiTietMonThi = "Nghiên cứu về quy trình phát triển phần mềm và quản lý dự án. Khóa học này sẽ giúp sinh viên hiểu các phương pháp phát triển phần mềm, từ lập kế hoạch đến triển khai và bảo trì.",
                        Photo = imageCollection1.Images[8]
                    },
                    new MonThi
                    {
                        TenMonThi = "Hệ Thống Thông Tin",
                        ChiTietMonThi = "Khóa học về thiết kế và quản lý hệ thống thông tin. Sinh viên sẽ tìm hiểu về cách xây dựng và duy trì các hệ thống thông tin để hỗ trợ hoạt động kinh doanh và ra quyết định.",
                        Photo = imageCollection1.Images[9]
                    }
                };
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
            if (e.ElementId == "detailButton")
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
            if (e.ElementId == "kiemTraButton")
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
