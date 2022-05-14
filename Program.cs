﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLiKhachSan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static ThanhToanForm thanhToanForm = null;
        public static QuanLiNhanVienForm quanLiNhanVienForm = null;
        public static QuanLiPhongForm quanLiPhongForm = null;
        public static ThongTinKhachHangForm thongTinKhachHangForm = null;
        public static DatPhongForm datPhongForm = null;
        public static FrmDangNhap frmDangNhap = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}