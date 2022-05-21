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
using DAO_BLL;

namespace DoAn_QuanLiKhachSan
{
    public partial class frmDanhSachKhachHang : DevExpress.XtraEditors.XtraForm
    {
        /* Createby: 162860 - Vo Hoang Bao Son
           CreatedDate: 21/05/2022
        */
        #region Properties
        KhachHangDAO objKhachHangDAO = new KhachHangDAO();
        #endregion
        public frmDanhSachKhachHang()
        {
            InitializeComponent();
            LoadDataCusTomer();
        }
        #region Methods

        public void LoadDataCusTomer()
        {
            dgv_KhachHang.DataSource = objKhachHangDAO.GetDataCustomer();
        }

        private void dgv_KhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_KhachHang.DataSource != null && dgv_KhachHang.Rows.Count > 0)
            {
                int index = dgv_KhachHang.CurrentCell.RowIndex;
                txt_TenKH.Text = dgv_KhachHang["col_TenKH", index].Value.ToString().Trim();
                txt_MaKH.Text = dgv_KhachHang["col_MaKH", index].Value.ToString().Trim();
                txt_SDT.Text = dgv_KhachHang["col_SDT", index].Value.ToString().Trim();
                cbo_GioiTinh.EditValue = dgv_KhachHang["col_SDT", index].Value.ToString().Trim();
                dtp_NgaySinh.Text = dgv_KhachHang["col_NgaySinh", index].Value.ToString().Trim();
                dtp_NgaySinh.Text = DateTime.Parse(dgv_KhachHang["col_NgaySinh", index].Value.ToString().Trim()).Date.ToString();
                txt_DiaChi.Text = dgv_KhachHang["col_DiaChi", index].Value.ToString().Trim();
            }
        }

        #endregion


    }
}