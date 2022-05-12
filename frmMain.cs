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
    }
}