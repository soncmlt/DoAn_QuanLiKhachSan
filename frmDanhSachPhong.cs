using BO;
using DAO_BLL;
using DevExpress.XtraEditors;
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
    public partial class frmDanhSachPhong : DevExpress.XtraEditors.XtraForm
    {
        PhongDAO objPhongDAO = new PhongDAO();

        public frmDanhSachPhong()
        {
            InitializeComponent();
        }
        //XuLy xl = new XuLy();
        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btn_capNhat_Click(object sender, EventArgs e)
        {
            DynamicUserControls();
            List<PhongBO> lstPhong = new List<PhongBO>();
            lstPhong = objPhongDAO.LoadMenuRoom();
            int soluong = lstPhong.Count();
            trv_DSTenPhong.Nodes.Clear();
            for (int i = 0; i < lstPhong.Count(); i++)
            {
                TreeNode node = new TreeNode(lstPhong[i].TenPhong);
                trv_DSTenPhong.Nodes.Add(node);

            }

        }
        private void Phong_Click(object sender, EventArgs e)
        {
            Phong obj = (Phong)sender;
            txt_maPhong.Text = obj.MaPhong;
            txt_tenPhong.Text = obj.TenPhong;
            txt_trangThai.Text = obj.TrangThai;
            txt_loaiPhong.Text = obj.TenLoaiPhong;
        }

        private void frmDanhSachPhong_Load(object sender, EventArgs e)
        {
            txt_maPhong.ReadOnly = true;
            txt_tenPhong.ReadOnly = true;
            txt_trangThai.ReadOnly = true;
            txt_loaiPhong.ReadOnly = true;
            DynamicUserControls();
            List<PhongBO> lstPhong = new List<PhongBO>();
            lstPhong = objPhongDAO.LoadMenuRoom();
            int soluong = lstPhong.Count();
            for (int i = 0; i < lstPhong.Count(); i++)
            {
                TreeNode node = new TreeNode(lstPhong[i].TenPhong);
                trv_DSTenPhong.Nodes.Add(node);

            }
        }

        private void DynamicUserControls()
        {
            flowLayoutPanel1.Controls.Clear();
            List<PhongBO> lstPhong = new List<PhongBO>();
            lstPhong = objPhongDAO.LoadMenuRoom();
            int soluong = lstPhong.Count();
            Phong[] phongs = new Phong[soluong];
            for (int i = 0; i < phongs.Length; i++)
            {
                phongs[i] = new Phong();
                phongs[i].MaPhong = lstPhong[i].MaPhong.ToString();
                phongs[i].MaLP = lstPhong[i].MaLoaiPhong.ToString();
                phongs[i].TenPhong = lstPhong[i].TenPhong;
                phongs[i].TrangThai = lstPhong[i].TinhTrang;
                phongs[i].TenLoaiPhong = lstPhong[i].TenLoai;
                flowLayoutPanel1.Controls.Add(phongs[i]);
                phongs[i].Click += new System.EventHandler(this.Phong_Click);
            }
        }
    }
}