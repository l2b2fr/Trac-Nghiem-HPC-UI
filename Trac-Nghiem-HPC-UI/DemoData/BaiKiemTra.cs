using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trac_Nghiem_HPC_UI.DemoData
{
    internal class BaiKiemTra
    {
        // Thuộc tính tên bài kiểm tra
        public string TenBaiKiemTra { get; set; }

        // Thuộc tính chi tiết bài kiểm tra
        public string ChiTietBaiKiemTra { get; set; }

        // Thuộc tính thời gian (đơn vị phút)
        public int ThoiGian { get; set; }

        // Hàm khởi tạo mặc định
        public BaiKiemTra()
        {
        }

        // Hàm khởi tạo với tham số
        public BaiKiemTra(string tenBaiKiemTra, string chiTietBaiKiemTra, int thoiGian)
        {
            TenBaiKiemTra = tenBaiKiemTra;
            ChiTietBaiKiemTra = chiTietBaiKiemTra;
            ThoiGian = thoiGian;
        }

        // Phương thức hiển thị thông tin bài kiểm tra
        public void HienThiThongTin()
        {
            Console.WriteLine($"Tên Bài Kiểm Tra: {TenBaiKiemTra}");
            Console.WriteLine($"Chi Tiết Bài Kiểm Tra: {ChiTietBaiKiemTra}");
            Console.WriteLine($"Thời Gian: {ThoiGian} phút");
            // Logic hiển thị hình ảnh có thể được thêm vào ở đây
        }
    }
}
