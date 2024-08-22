using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trac_Nghiem_HPC_UI.DemoData
{
    internal class MonThi
    {
        public string TenMonThi { get; set; }
        public string ChiTietMonThi { get; set; }
        public Image Photo { get; set; }
        public DateTime NgayThi { get; set; }
        public string GiaoVien { get; set; }
        public string PriorityName { get; set; }
        public List<Khoa> DanhSachKhoa { get; set; }

        public MonThi()
        {
            DanhSachKhoa = new List<Khoa>();
        }

        // Phương thức tạo dữ liệu giả cho một môn thi
        public static MonThi FakeData(string tenMonThi, string chiTietMonThi, DateTime ngayThi, string giaoVien, string priorityName, List<string> tenKhoaList)
        {
            var monThi = new MonThi
            {
                TenMonThi = tenMonThi,
                ChiTietMonThi = chiTietMonThi,
                NgayThi = ngayThi,
                GiaoVien = giaoVien,
                PriorityName = priorityName,
                DanhSachKhoa = new List<Khoa>()
            };


            // Tạo danh sách Khoa từ các tên khoa được cung cấp
            foreach (var tenKhoa in tenKhoaList)
            {
                monThi.DanhSachKhoa.Add(Khoa.FakeData(tenKhoa));
            }

            return monThi;
        }

        // Phương thức tạo danh sách nhiều môn thi với dữ liệu giả
        public static List<MonThi> FakeMultipleData(int soLuongMonThi)
        {
            var danhSachMonThi = new List<MonThi>();

            for (int i = 1; i <= soLuongMonThi; i++)
            {
                danhSachMonThi.Add(FakeData(
                    $"Môn học {i}",
                    $"Chi tiết môn học {i}",
                    DateTime.Now.AddDays(i),
                    $"Giáo viên {i}",
                    i % 2 == 0 ? "High" : "Low",  // Chỉ định PriorityName "High" cho các môn thi chẵn, "Low" cho các môn lẻ
                    new List<string> { "Khoa CNTT", "Khoa CNOTO", "Khoa TKDH" }
                ));
            }

            return danhSachMonThi;
        }
    }
}
