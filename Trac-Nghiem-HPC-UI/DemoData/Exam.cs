using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trac_Nghiem_HPC_UI.DemoData
{
    internal class Exam
    {
        public string TenKiThi { get; set; } // Exam Title
        public string MoTaKiThi { get; set; } // Exam Description
        public DateTime NgayThi { get; set; } // Exam Date
        public string DiaDiemThi { get; set; } // Exam Location
    }
}
