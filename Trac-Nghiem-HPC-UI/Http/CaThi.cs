using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trac_Nghiem_HPC_UI.Http
{
    internal class CaThi
    {
        public int Id { get; set; }
        public string TenCa { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public int KyThiId { get; set; }
        public int MonHocId { get; set; }
    }
}
