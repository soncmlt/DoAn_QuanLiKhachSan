using DevExpress.XtraBars;
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
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public bool IsFormActive(Form form)
        {
            bool Isopend = false;
            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (form.Name == item.Name)
                    {
                        xtraTabbedMdiManager1.Pages[item].MdiChild.Activate();
                        Isopend = true;
                    }

                }
            }
            return Isopend;
        }
        public void ViewChildForm(Form _form)
        {
            if (!IsFormActive(_form))
            {
                _form.MdiParent = this;
                _form.Show();
            }
        }

        private void btn_DanhSachPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDanhSachPhong frm = new frmDanhSachPhong();
            frm.Name = "Danh sách phòng";
            ViewChildForm(frm);
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmChinhSuaPhong frm = new frmChinhSuaPhong();
            frm.Name = "Chỉnh sửa thông tin phòng";
            ViewChildForm(frm);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThongTinNhanVien frm = new frmThongTinNhanVien();
            frm.Name = "Thông tin nhân viên";
            ViewChildForm(frm);
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQuanLiThongTinNhanVien frm = new frmQuanLiThongTinNhanVien();
            frm.Name = "Quản lí thông tin nhân viên";
            ViewChildForm(frm);
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThayDoiMatKhau frm = new frmThayDoiMatKhau();
            frm.Name = "Thay đổi mật khẩu";
            frm.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDanhSachKhachHang frm = new frmDanhSachKhachHang();
            frm.Name = "Thông tin khách hàng";
            ViewChildForm(frm);
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThanhToan frm = new frmThanhToan();
            frm.Name = "Thanh toán";
            ViewChildForm(frm);
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThongTinThuePhong frm = new frmThongTinThuePhong();
            frm.Name = "Thông tin thuê phòng";
            ViewChildForm(frm);
        }
    }
}