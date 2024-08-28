using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
using Trac_Nghiem_HPC_UI.Http;

namespace Trac_Nghiem_HPC_UI
{
    public partial class frmLamBai : DevExpress.XtraEditors.DirectXForm
    {
        private int thoigian = 1 * 60; // 15 phút = 15 * 60 giây
        private int demgiay = 1;
        private List<CauHoi> CauHois;
        public frmLamBai()
        {
            InitializeComponent();
        }

        private void frmLamBai_Load(object sender, EventArgs e)
        {
            loadCauHoi();
            loadDetail();
            stepProgressBarItem1.Progress = 100;

            // Bắt đầu Timer
            timer1.Start();
        }
        private void loadDetail()
        {
            List<SinhVienResponse> list = new List<SinhVienResponse>();
            list.Add(Program.sinhVienResponse);
            htmlContentControlHeader.DataContext = Program.sinhVienResponse;
        }
        private void loadCauHoi()
        {
            /*List<CauHoi> listCauHoi = new List<CauHoi>();
            for (int i = 0; i < 40; i++)
            {
                CauHoi hoi = new CauHoi();
                hoi._id = (i + 1).ToString();
                listCauHoi.Add(hoi);
            }
            gridControlDanhSachCauHoi.DataSource = listCauHoi;
            */
            CauHois = new List<CauHoi>
                 {
                new CauHoi("Đây là cấu trúc mạng hình gì:",imageCollectionCauHoi.Images[0],
                    new List<string> { "A: Ring", "B: Bus", "C: Start", "D: Tất cả đều sai" },
                    "D"),

                new CauHoi("Đây là loại mô hình gì:",imageCollectionCauHoi.Images[1],
                    new List<string> { "A: OSI", "B: TCP/IP", "C: Tất cả đúng", "D: Tất cả đều sai" },
                    "C"),

                new CauHoi("Sơ đồ chức năng đăng nhập sau đây thuộc loại sơ đồ nào:",imageCollectionCauHoi.Images[2],
                    new List<string> { "A: Usecase", "B: Trạng thái", "C: Tuần tự", "D: Lớp" },
                    "A"),

                new CauHoi("Các thành phần dưới đây thuộc loại sơ đồ nào:",imageCollectionCauHoi.Images[3],
                    new List<string> { "A: Usecase", "B: Trạng thái", "C: Tuần tự", "D: Hoạt động" },
                    "D"),

                new CauHoi("Dưới đây là hình ảnh logo về một phần mềm chỉnh sửa ảnh, đó là phần mềm gì:",imageCollectionCauHoi.Images[4],
                    new List<string> { "A: Illustrator", "B: Adobe Photoshop", "C: CorelDRAW", "D: InDesign" },
                    "B"),

                new CauHoi("Sắp xếp các thuật ngữ Hue, Saturation và Value theo đúng thứ tự bằng hình ảnh minh họa dưới đây:",imageCollectionCauHoi.Images[5],
                    new List<string> { "A: 1-2-3", "B: 2-3-1", "C: 3-1-2", "D: Tất cả đều sai" },
                    "C"),

                new CauHoi("Dưới đây là mô hình gì:",imageCollectionCauHoi.Images[6],
                    new List<string> { "A: RGB", "B: CMYK", "C: RYB", "D: Tất cả đều sai" },
                    "B"),

                new CauHoi("Trong SQL đây là câu lệnh giúp thực hiện tác vụ gì:",imageCollectionCauHoi.Images[7],
                    new List<string> { "A: Thêm một bản ghi vào một bảng", "B: Xóa bản ghi trong một bảng",
                                      "C: Chỉnh sửa bản ghi trong một bảng", "D: Tất cả đều sai" },
                    "A"),

                new CauHoi("Thẻ <a> </a> trong đoạn code trên dùng để làm gì:",imageCollectionCauHoi.Images[8],
                    new List<string> { "A: Đặt tiêu đề cho trang",
                                      "B: Chứa toàn bộ nội dung hiển thị của trang web, bao gồm văn bản, hình ảnh, video, liên kết",
                                      "C: Tạo liên kết đến trang web example", "D: Tất cả đều sai" },
                    "C"),

                new CauHoi("Đoạn code phía dưới dùng để làm gì:",imageCollectionCauHoi.Images[9],
                    new List<string> { "A: Kiểm tra số nhập vào là số chẵn hay lẻ",
                                      "B: Kiểm tra số nhập vào có phải số nguyên hay không",
                                      "C: Kiểm tra số nhập vào có phải số nguyên tố hay không", "D: Tất cả đều sai" },
                    "A"),

                new CauHoi("Hình ảnh minh họa dưới đây là bộ phận nào của máy tính:",imageCollectionCauHoi.Images[10],
                    new List<string> { "A: Mainboard", "B: CPU", "C: Khe cắm Ram", "D: Tất cả đều sai" },
                    "C"),

                new CauHoi("Mô hình quản lý thư viện dưới đây thuộc loại mô hình nào:",imageCollectionCauHoi.Images[11],
                    new List<string> { "A: Hoạt động", "B: Trạng thái", "C: Usecase", "D: Lớp" },
                    "A"),

                new CauHoi("Đây là mô hình gì:",imageCollectionCauHoi.Images[12],
                    new List<string> { "A: Mô hình client-server", "B: Mô hình OSI", "C: Mô hình TCP/IP", "D: Tất cả đều sai" },
                    "A"),

                new CauHoi("Tầng thứ 2 trong mô hình OSI là gì:",imageCollectionCauHoi.Images[13],
                    new List<string> { "A: Link", "B: Data-link", "C: Tất cả đều đúng", "D: Tất cả đều sai" },
                    "B"),

                new CauHoi("Lệnh SELECT dưới đây dùng để làm gì:",imageCollectionCauHoi.Images[14],
                    new List<string> { "A: Chỉnh sửa dữ liệu từ 1 bảng", "B: In ra thông tin từ 1 bảng",
                                      "C: Tạo 1 bảng mới", "D: Tất cả đều sai" },
                "B")
            };


            for (int i = 0; i < CauHois.Count; i++)
            {
                CauHois[i].Id = i + 1;
            }

            gridControlDanhSachCauHoi.DataSource = CauHois;
            htmlContentControlChiTietCauHoi.DataContext = CauHois[0];

            // Xóa các mục hiện tại trong radioGroupDapAn để tránh lỗi khi thêm mới
            radioGroupDapAn.Properties.Items.Clear();

            // Lấy danh sách các đáp án từ câu hỏi hiện tại
            List<string> listDapAn = CauHois[0].DapAn;

            // Duyệt qua từng đáp án và thêm vào radioGroupDapAn
            for (int i = 0; i < listDapAn.Count; i++)
            {
                radioGroupDapAn.Properties.Items.Add(new RadioGroupItem(listDapAn[i], listDapAn[i]));
            }
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
            else if (demgiay < thoigian - 1)
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

        private void htmlContentControl2_ElementMouseClick(object sender, DevExpress.Utils.Html.DxHtmlElementMouseEventArgs e)
        {
            if (e.ElementId == "nopBaiButon")
            {
                var arg = new XtraMessageBoxArgs();
                arg.HtmlTemplate.Assign(htmlMesage);
                arg.Caption = "Nộp bài thi";
                arg.Text = "Bạn có thực sự muốn nộp bài?";
                arg.DefaultButtonIndex = 0;
                var result = XtraMessageBox.Show(arg);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void tileView1_HtmlElementMouseClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewHtmlElementMouseEventArgs e)
        {
            if (e.ElementId == "cauHoi")
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
                else if (gridControl.DataSource is List<CauHoi> dataList)
                {
                    if (selectedIndex >= 0 && selectedIndex < dataList.Count)
                    {
                        List<CauHoi> cauHois = new List<CauHoi>();
                        cauHois.Add(dataList[selectedIndex]);
                        htmlContentControlChiTietCauHoi.DataContext = cauHois;

                        // Xóa các mục hiện tại trong radioGroupDapAn để tránh lỗi khi thêm mới
                        radioGroupDapAn.Properties.Items.Clear();

                        // Lấy danh sách các đáp án từ câu hỏi hiện tại
                        List<string> listDapAn = dataList[selectedIndex].DapAn;

                        // Duyệt qua từng đáp án và thêm vào radioGroupDapAn
                        for (int i = 0; i < listDapAn.Count; i++)
                        {
                            radioGroupDapAn.Properties.Items.Add(new RadioGroupItem(listDapAn[i], listDapAn[i]));
                        }
                        radioGroupDapAn.EditValue = false;

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
    }
}