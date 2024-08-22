using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trac_Nghiem_HPC_UI.DemoData
{
    internal class Khoa
    {
        public string FullName { get; set; }
        public string KhoaName { get; set; }

        // Phương thức tạo dữ liệu giả
        public static Khoa FakeData(string khoaName)
        {
            return new Khoa
            {
                FullName = $"Khoa {khoaName}",
                KhoaName = khoaName
            };
        }
    }
}
