using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLiKhachSan
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Program.quanLiNhanVienForm = new QuanLiNhanVienForm();
            Program.thongTinKhachHangForm = new ThongTinKhachHangForm();
            Program.thanhToanForm = new ThanhToanForm();
            Program.quanLiPhongForm = new QuanLiPhongForm();
            Program.datPhongForm = new DatPhongForm();
            Program.quanLiPhongForm.MdiParent = this;
            Program.quanLiPhongForm.Dock = DockStyle.Fill;
            Program.quanLiPhongForm.Show();
        }

        private void btn_dangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_quanLiPhong_Click(object sender, EventArgs e)
        {
            changeSelectColor(btn_quanLiPhong);
            changeUnselectColor(btn_quanLiNhanVien);
            changeUnselectColor(btn_thanhToan);
            changeUnselectColor(btn_thongTinKhachHang);
            changeUnselectColor(btn_DatPhong);
            Program.quanLiPhongForm.MdiParent = this;
            Program.quanLiPhongForm.Dock = DockStyle.Fill;
            Program.quanLiPhongForm.Show();
            Program.thongTinKhachHangForm.Hide();
            Program.quanLiNhanVienForm.Hide();
            Program.thanhToanForm.Hide();
            Program.datPhongForm.Hide();
        }

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            changeSelectColor(btn_thanhToan);
            changeUnselectColor(btn_quanLiNhanVien);
            changeUnselectColor(btn_quanLiPhong);
            changeUnselectColor(btn_thongTinKhachHang);
            changeUnselectColor(btn_DatPhong);
            Program.thanhToanForm.MdiParent = this;
            Program.thanhToanForm.Dock = DockStyle.Fill;
            Program.thanhToanForm.Show();
            Program.quanLiNhanVienForm.Hide();
            Program.quanLiPhongForm.Hide();
            Program.thongTinKhachHangForm.Hide();
            Program.datPhongForm.Hide();
        }
        public void changeSelectColor(Button btn)
        {
            btn.ForeColor = Color.FromArgb(255, 255, 255);
            btn.BackColor = Color.FromArgb(40, 53, 62);
        }
        public void changeUnselectColor(Button btn)
        {
            btn.ForeColor = Color.FromArgb(40, 53, 62);
            btn.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btn_thongTinKhachHang_Click(object sender, EventArgs e)
        {
            changeSelectColor(btn_thongTinKhachHang);
            changeUnselectColor(btn_quanLiNhanVien);
            changeUnselectColor(btn_thanhToan);
            changeUnselectColor(btn_quanLiPhong);
            changeUnselectColor(btn_DatPhong);
            Program.thongTinKhachHangForm.MdiParent = this;
            Program.thongTinKhachHangForm.Dock = DockStyle.Fill;
            Program.thongTinKhachHangForm.Show();
            Program.quanLiPhongForm.Hide();
            Program.quanLiNhanVienForm.Hide();
            Program.thanhToanForm.Hide();
            Program.datPhongForm.Hide();
        }

        private void btn_quanLiNhanVien_Click(object sender, EventArgs e)
        {
            changeSelectColor(btn_quanLiNhanVien);
            changeUnselectColor(btn_quanLiPhong);
            changeUnselectColor(btn_thanhToan);
            changeUnselectColor(btn_thongTinKhachHang);
            changeUnselectColor(btn_DatPhong);
            Program.quanLiNhanVienForm.MdiParent = this;
            Program.quanLiNhanVienForm.Dock = DockStyle.Fill;
            Program.quanLiNhanVienForm.Show();
            Program.quanLiPhongForm.Hide();
            Program.thongTinKhachHangForm.Hide();
            Program.thanhToanForm.Hide();
            Program.datPhongForm.Hide();
        }

        private void btn_DatPhong_Click(object sender, EventArgs e)
        {
            changeSelectColor(btn_DatPhong);
            changeUnselectColor(btn_quanLiPhong);
            changeUnselectColor(btn_thanhToan);
            changeUnselectColor(btn_thongTinKhachHang);
            changeUnselectColor(btn_quanLiNhanVien);
            Program.datPhongForm.MdiParent = this;
            Program.datPhongForm.Dock = DockStyle.Fill;
            Program.datPhongForm.Show();
            Program.quanLiPhongForm.Hide();
            Program.thongTinKhachHangForm.Hide();
            Program.thanhToanForm.Hide();
            Program.quanLiNhanVienForm.Hide();
        }
    }
}
