using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class NhanVienBO
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public string MatKhau { get; set; }
        public int MaLoaiNV { get; set; }
        public string DiaChi { get; set; }
        public DateTime? NgaySinh { get; set; }
    }

    public class NhanVienCustomBOView
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public string ChucVu { get; set; }
        public string DiaChi { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string MatKhau { get; set; }
    }
}
