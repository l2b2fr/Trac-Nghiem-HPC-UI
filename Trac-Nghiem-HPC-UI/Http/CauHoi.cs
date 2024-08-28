using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trac_Nghiem_HPC_UI.Http
{
    internal class CauHoi
    {
        public int Id { get; set; }
        public string CauHoiText { get; set; }
        public Image Photo { get; set; }
        public List<string> DapAn { get; set; }
        public string DapAnDung { get; set; }

        public CauHoi(string cauHoiText, Image image, List<string> dapAn, string dapAnDung)
        {
            CauHoiText = cauHoiText;
            Photo = image;
            DapAn = dapAn;
            DapAnDung = dapAnDung;
        }
    }
}
