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
using BO;
namespace DoAn_QuanLiKhachSan
{
    public partial class frmThongTinThuePhong : DevExpress.XtraEditors.XtraForm
    {
        #region Properties
        KhachHangDAO objKhachHangDAO = new KhachHangDAO();
        LoaiPhongDAO objLoaiPhongDAO = new LoaiPhongDAO();
        PhongDAO objPhongDAO = new PhongDAO();
        HinhThucDAO objHinhThucDAO = new HinhThucDAO();
        PhieuThueDAO objPhieuThueDAO = new PhieuThueDAO();
        #endregion
        public frmThongTinThuePhong()
        {
            InitializeComponent();
            LoadDataCustomer();
            LoadRoomType();
            LoadDataHinhThuc();
            dtp_NgayDat.Text = DateTime.Now.ToString();
            LoadDataPT();
        }

        public void LoadDataCustomer()
        {
            cbo_KhachHang.Properties.DataSource = objKhachHangDAO.GetDataCustomer();
            cbo_KhachHang.Properties.ValueMember = "MaKH";
            cbo_KhachHang.Properties.DisplayMember = "TenKH";
            cbo_KhachHang.EditValue = string.Empty;
            if (cbo_KhachHang.Properties.DataSource != null)
            {
                var objKH = objKhachHangDAO.GetDataCustomer().FirstOrDefault();
                cbo_KhachHang.EditValue = objKH.MaKH.Trim();
            }
        }

        public void LoadRoomType()
        {
            cbl_LoaiPhong.Properties.DataSource = objLoaiPhongDAO.GetAllTypeRoom();
            cbl_LoaiPhong.Properties.ValueMember = "MaLoaiPhong";
            cbl_LoaiPhong.Properties.DisplayMember = "TenLoai";
            cbl_LoaiPhong.EditValue = string.Empty;
            if (cbl_LoaiPhong.Properties.DataSource != null)
            {
                var objLP = objLoaiPhongDAO.GetAllTypeRoom().FirstOrDefault();
                cbl_LoaiPhong.EditValue = objLP.MaLoaiPhong;
                int intTyepId = int.Parse(cbl_LoaiPhong.EditValue.ToString().Trim());
                LoadDataRoom(intTyepId);
            }
        }

        private void cbl_LoaiPhong_EditValueChanged(object sender, EventArgs e)
        {
            if (cbl_LoaiPhong.Properties.DataSource != null && !string.IsNullOrEmpty(cbl_LoaiPhong.EditValue.ToString().Trim()))
            {
                int intTyepId = int.Parse(cbl_LoaiPhong.EditValue.ToString().Trim());
                LoadDataRoom(intTyepId);
            }
        }

        public void LoadDataHinhThuc()
        {
            cbo_HinhThuc.Properties.DataSource = objHinhThucDAO.GetAllDataHinhThuc();
            cbo_HinhThuc.Properties.ValueMember = "MaHinhThuc";
            cbo_HinhThuc.Properties.DisplayMember = "TenHinhThuc";
            if (cbo_HinhThuc.Properties.DataSource != null)
            {
                var objHT = objHinhThucDAO.GetAllDataHinhThuc().FirstOrDefault();
                cbo_HinhThuc.EditValue = objHT.MaHinhThuc;
            }
        }

        public void LoadDataRoom(int intTyepId)
        {
            cbo_Phong.Properties.DataSource = objPhongDAO.GetRoomByTyRoomId(int.Parse(cbl_LoaiPhong.EditValue.ToString().Trim()));
            cbo_Phong.Properties.ValueMember = "MaPhong";
            cbo_Phong.Properties.DisplayMember = "TenPhong";
            cbo_Phong.EditValue = string.Empty;
            if (cbo_Phong.Properties.DataSource != null)
            {
                var objPhong = objPhongDAO.GetRoomByTyRoomId(intTyepId).FirstOrDefault();
                cbo_Phong.EditValue = objPhong.MaPhong;
            }
        }

        public bool CheckInsertOrUpdate(bool isInsert)
        {
            if (string.IsNullOrEmpty(cbo_Phong.EditValue.ToString().Trim()))
            {
                MessageBox.Show("Thông tin phòng không được để trống. Xin vui lòng kiểm tra lại");
                return false;
            }

            if (isInsert)
            {
                if (string.IsNullOrEmpty(cbo_KhachHang.EditValue.ToString().Trim()))
                {
                    MessageBox.Show("Thông tin khách hàng không được để trống. Xin vui lòng kiểm tra lại");
                    return false;
                }
                var objPhong = objPhongDAO.LoadMenuRoom().Where(x => x.MaPhong == int.Parse(cbo_Phong.EditValue.ToString().Trim())).FirstOrDefault();
                if (objPhong != null && objPhong.TinhTrang.Trim() == "Đã thuê")
                {
                    MessageBox.Show("Phòng [" + cbo_Phong.Text.Trim() + "] hiện đã được thuê. Xin vui lòng chọn phòng khác!");
                    return false;
                }

                if (string.IsNullOrEmpty(cbo_HinhThuc.Text.Trim()))
                {
                    MessageBox.Show("Hình thức thuê không được bỏ trống xin vui lòng thử lại!");
                    return false;
                }
            }
            return true;
        }

        public bool InsertOrUpdate(bool isInsert)
        {
            try
            {
                var objPT = new PhieuThueBO();
                if (!isInsert)
                {
                    int index = dgv_PhieuThue.CurrentCell.RowIndex;
                    objPT.MaPhieuThue = int.Parse(dgv_PhieuThue["col_MaPhieuDat", index].Value.ToString().Trim());
                }
                else
                {
                    objPT.MaPhieuThue = -1;
                }
                objPT.MaPhong = int.Parse(cbo_Phong.EditValue.ToString().Trim());
                objPT.MaHinhThuc = int.Parse(cbo_HinhThuc.EditValue.ToString().Trim());
                objPT.MaKH = cbo_KhachHang.EditValue.ToString().Trim();
                if (objPhieuThueDAO.InsertOrUpdate(objPT))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (CheckInsertOrUpdate(true) && InsertOrUpdate(true))
            {
                MessageBox.Show("Thêm mới thành công!");
                LoadDataPT();
                CheckEnable();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!");
            }
        }

        public void LoadDataPT()
        {
            dgv_PhieuThue.DataSource = objPhieuThueDAO.GetAllDataPhieuThue();
        }

        private void dgv_PhieuThue_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_PhieuThue.DataSource != null && dgv_PhieuThue.Rows.Count > 0)
            {
                int index = dgv_PhieuThue.CurrentCell.RowIndex;
                cbo_HinhThuc.EditValue = int.Parse(dgv_PhieuThue["col_HinhThucThue", index].Value.ToString().Trim());
                dtp_NgayDat.Text = dgv_PhieuThue["col_NgayGioCheckIn", index].Value.ToString().Trim();
                var objLoaiPhong = objPhongDAO.LoadMenuRoom().Where(x => x.MaPhong == int.Parse(dgv_PhieuThue["col_MaPhong", index].Value.ToString().Trim())).FirstOrDefault();
                cbl_LoaiPhong.EditValue = objLoaiPhong.MaLoaiPhong;
                LoadDataRoom(objLoaiPhong.MaLoaiPhong);
                cbo_KhachHang.EditValue = int.Parse(dgv_PhieuThue["col_MaKH", index].Value.ToString().Trim());
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (CheckInsertOrUpdate(false) && InsertOrUpdate(false))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadDataPT();
                CheckEnable();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_PhieuThue.DataSource != null && dgv_PhieuThue.Rows.Count > 0)
            {
                int index = dgv_PhieuThue.CurrentCell.RowIndex;
                if (objPhieuThueDAO.Delete(int.Parse(dgv_PhieuThue["col_MaPhieuDat", index].Value.ToString().Trim())))
                {
                    MessageBox.Show("Xóa phiếu thuê thành công!");
                    LoadDataPT();
                    CheckEnable();
                }
                else
                {
                    MessageBox.Show("Xóa phiếu thuê thất bại!");
                }
            }
        }

        public void CheckEnable()
        {
            if (dgv_PhieuThue.DataSource != null && dgv_PhieuThue.Rows.Count > 0)
            {
                btn_Xoa.Enabled = true;
                btn_Sua.Enabled = true;
            }
            else
            {
                btn_Xoa.Enabled = false;
                btn_Sua.Enabled = false;
            }
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}