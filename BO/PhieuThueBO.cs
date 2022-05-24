using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class PhieuThueBO
    {
        public int MaPhieuThue { get; set; }
        public int MaPhong { get; set; }
        public int MaHinhThuc { get; set; }
        public DateTime? NgayDat { get; set; }
        public string MaKH { get; set; }
    }

    public class PhieuThueCustom
    {
        public string TenKH { get; set; }
        public string MaKH { get; set; }
        public string TenPhong { get; set; }
        public DateTime? NgayDat { get; set; }
        public string TenHinhThuc { get; set; }
    }
}
