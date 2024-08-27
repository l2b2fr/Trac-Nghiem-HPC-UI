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
    public partial class ucLichSuThi : DevExpress.XtraEditors.XtraUserControl
    {
        public ucLichSuThi()
        {
            InitializeComponent();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {

        }

        private void ucLichSuThi_Load(object sender, EventArgs e)
        {
            List<Exam> examHistoryData = new List<Exam>
        {
            new Exam
            {
                TenKiThi = "Ki Thi Giữa Kỳ Lập Trình C#",
                MoTaKiThi = "Đánh giá giữa kỳ cho môn Lập trình C#.",
                NgayThi = new DateTime(2024, 9, 20),
                DiaDiemThi = "Phòng 101, Tòa nhà Công nghệ"
            },
            new Exam
            {
                TenKiThi = "Ki Thi Cuối Kỳ Cơ Sở Dữ Liệu",
                MoTaKiThi = "Thi cuối kỳ môn Cơ sở dữ liệu.",
                NgayThi = new DateTime(2024, 12, 15),
                DiaDiemThi = "Phòng 202, Tòa nhà Công nghệ"
            },
            new Exam
            {
                TenKiThi = "Ki Thi Giữa Kỳ Mạng Máy Tính",
                MoTaKiThi = "Đánh giá giữa kỳ cho môn Mạng máy tính.",
                NgayThi = new DateTime(2025, 3, 25),
                DiaDiemThi = "Phòng 303, Tòa nhà Công nghệ"
            },
            new Exam
            {
                TenKiThi = "Ki Thi Cuối Kỳ Hệ Thống Thông Tin",
                MoTaKiThi = "Thi cuối kỳ môn Hệ thống thông tin.",
                NgayThi = new DateTime(2025, 6, 10),
                DiaDiemThi = "Phòng 404, Tòa nhà Công nghệ"
            },
            new Exam
            {
                TenKiThi = "Ki Thi Giữa Kỳ An Ninh Mạng",
                MoTaKiThi = "Đánh giá giữa kỳ cho môn An ninh mạng.",
                NgayThi = new DateTime(2024, 10, 05),
                DiaDiemThi = "Phòng 505, Tòa nhà Công nghệ"
            },
            new Exam
            {
                TenKiThi = "Ki Thi Cuối Kỳ Phát Triển Web",
                MoTaKiThi = "Thi cuối kỳ môn Phát triển web.",
                NgayThi = new DateTime(2024, 12, 20),
                DiaDiemThi = "Phòng 606, Tòa nhà Công nghệ"
            },
            new Exam
            {
                TenKiThi = "Ki Thi Giữa Kỳ Trí Tuệ Nhân Tạo",
                MoTaKiThi = "Đánh giá giữa kỳ cho môn Trí tuệ nhân tạo.",
                NgayThi = new DateTime(2025, 4, 15),
                DiaDiemThi = "Phòng 707, Tòa nhà Công nghệ"
            },
            new Exam
            {
                TenKiThi = "Ki Thi Cuối Kỳ Lập Trình Web",
                MoTaKiThi = "Thi cuối kỳ môn Lập trình web.",
                NgayThi = new DateTime(2025, 6, 25),
                DiaDiemThi = "Phòng 808, Tòa nhà Công nghệ"
            },
            new Exam
            {
                TenKiThi = "Ki Thi Giữa Kỳ Khoa Học Dữ Liệu",
                MoTaKiThi = "Đánh giá giữa kỳ cho môn Khoa học dữ liệu.",
                NgayThi = new DateTime(2024, 11, 10),
                DiaDiemThi = "Phòng 909, Tòa nhà Công nghệ"
            },
            new Exam
            {
                TenKiThi = "Ki Thi Cuối Kỳ Công Nghệ Phần Mềm",
                MoTaKiThi = "Thi cuối kỳ môn Công nghệ phần mềm.",
                NgayThi = new DateTime(2025, 7, 05),
                DiaDiemThi = "Phòng 1010, Tòa nhà Công nghệ"
            }
        };
            gridControl1.DataSource = examHistoryData;
        }
    }
}
