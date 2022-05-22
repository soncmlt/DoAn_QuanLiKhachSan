using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class PhongBO
    {
        public int MaPhong { get; set; }
        public int MaLoaiPhong { get; set; }
        public string TenPhong { get; set; }
        public string TinhTrang { get; set; }
        public string TenLoai { get; set; }
    }

    public class LoaiPhongBO
    {
        public int MaLoaiPhong { get; set; }
        public string TenLoai { get; set; }
        public int? SoGiuong { get; set; }
        public int? GiaGio { get; set; }
        public int? GiaNgay { get; set; }
        public int? GiaThang { get; set; }
    }

}
