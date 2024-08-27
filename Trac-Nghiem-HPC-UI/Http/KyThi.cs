using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trac_Nghiem_HPC_UI.Http
{
    internal class KyThi
    {
        public int Id { get; set; }
        public string TenKyThi { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public List<CaThi> Ca_This { get; set; }
    }
}
