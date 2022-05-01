using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO_BLL;
namespace DoAn_QuanLiKhachSan
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            NhanVienDAO objDAO = new NhanVienDAO();
            if(string.IsNullOrEmpty(txtUserName.Text.Trim()) || string.IsNullOrEmpty(txtPass.Text.Trim()))
            {
                MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không được bỏ trống. Xin vui lòng kiển tra lại!");
                return;
            }
            else if (txtUserName.Text.Trim().Length > 10 || txtPass.Text.Trim().Length > 10)
            {
                MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không được vượt quá 10 ký tự. Xin vui lòng kiển tra lại!");
                return;
            }
            else if (objDAO.LoadNhanVien(txtUserName.Text.Trim(), txtPass.Text.Trim()) == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không đúng. Xin vui lòng kiển tra lại!");
                return;
            }
            else
            {
                FrmLoading frm = new FrmLoading();
                frm.Show();
                this.Hide();
            }
        }
    }
}
