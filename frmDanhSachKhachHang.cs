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
            LoadDataComboGender();
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
                cbo_GioiTinh.EditValue = dgv_KhachHang["col_GioiTinh", index].Value.ToString().Trim();
                dtp_NgaySinh.Text = DateTime.Parse(dgv_KhachHang["col_NgaySinh", index].Value.ToString().Trim()).ToString("dd/MM/yyyy");
                if (dgv_KhachHang["col_DiaChi", index].Value != null)
                {
                    txt_DiaChi.Text = dgv_KhachHang["col_DiaChi", index].Value.ToString().Trim();
                }
            }
        }

        public bool CheckInsertOrUpdate(bool isInsert)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_TenKH.Text.Trim()) || txt_TenKH.Text.Trim().Length > 50)
                {
                    MessageBox.Show("Tên khách hàng không được bỏ trống và không được vượt quá 50 ký tự");
                    return false;
                }


                if (isInsert)
                {
                    if (string.IsNullOrEmpty(txt_MaKH.Text.Trim()) || txt_MaKH.Text.Trim().Length > 10)
                    {
                        MessageBox.Show("Số CMND/CCCD không được bỏ trống và không được vượt quá 10 ký tự");
                        return false;
                    }

                    var objKH = objKhachHangDAO.CheckIsExistsCustommer(txt_MaKH.Text.Trim());
                    if (objKH != null)
                    {
                        MessageBox.Show("Mã CMND/CCCD đã được khai báo cho User [" + objKH.MaKH + " - " + objKH.TenKH + "]");
                        return false;
                    }
                }

                if (string.IsNullOrEmpty(txt_SDT.Text.Trim()) || txt_SDT.Text.Trim().Length > 10)
                {
                    MessageBox.Show("Số điện thoại không được bỏ trống và không được vượt quá 10 số. Xin vui lòng kiểm tra lại!");
                    return false;
                }

                if (string.IsNullOrEmpty(dtp_NgaySinh.Text.Trim()))
                {
                    MessageBox.Show("Ngày sinh không được bỏ trống. Xin vui lòng kiểm tra lại!");
                    return false;
                }

                if (!string.IsNullOrEmpty(txt_DiaChi.Text.Trim()) && txt_DiaChi.Text.Trim().Length > 50)
                {
                    MessageBox.Show("Địa chỉ khách hàng không được vượt quá 50 ký tự. Xin vui lòng kiểm tra lại!");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                string strMessErr = "Lỗi trong quá trình kiểm tra thông tin cập nhật nhân viên trên UI";
                throw new Exception(strMessErr, ex);
            }
        }

        public bool InsertOrUpdate(bool isInsert)
        {
            try
            {
                KhachHangBO objKhachHangBO = new KhachHangBO();
                if (isInsert)
                {
                    objKhachHangBO.MaKH = txt_MaKH.Text.Trim();
                }
                else
                {
                    int index = dgv_KhachHang.CurrentCell.RowIndex;
                    objKhachHangBO.MaKH = dgv_KhachHang["col_MaKH", index].Value.ToString().Trim();
                }
                objKhachHangBO.TenKH = txt_TenKH.Text.Trim();
                objKhachHangBO.SDT = txt_SDT.Text.Trim();
                objKhachHangBO.GioiTinh = cbo_GioiTinh.Text.Trim();
                objKhachHangBO.NgaySinh = DateTime.Parse(dtp_NgaySinh.Text.Trim()).Date;
                objKhachHangBO.DiaChi = txt_DiaChi.Text.Trim();
                if (objKhachHangDAO.InsertOrUpdate(objKhachHangBO))
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
            if (CheckInsertOrUpdate(true))
            {
                if (InsertOrUpdate(true))
                {
                    MessageBox.Show("Cập nhật dữ liệu khách hàng thành công!");
                    LoadDataCusTomer();
                    CheckEnable();
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu khách hàng thất bại!");
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (CheckInsertOrUpdate(false))
            {
                if (InsertOrUpdate(false))
                {
                    MessageBox.Show("Cập nhật dữ liệu khách hàng thành công!");
                    LoadDataCusTomer();
                    CheckEnable();
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu khách hàng thất bại!");
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dgv_KhachHang.DataSource != null && dgv_KhachHang.Rows.Count > 0 && dgv_KhachHang.CurrentRow.Selected == true)
            {
                int index = dgv_KhachHang.CurrentCell.RowIndex;
                string strMaKH = dgv_KhachHang["col_MaKH", index].Value.ToString().Trim();
                if (objKhachHangDAO.Delete(strMaKH))
                {
                    MessageBox.Show("Xóa khách hàng thành công!");
                    LoadDataCusTomer();
                    CheckEnable();
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng thất bạt!");
                }
            }
            else
            {
                MessageBox.Show("Danh sách khách hàng đang rỗng không thể xóa. Xin vui lòng kiểm tra lại!");
            }
        }

        public void CheckEnable()
        {
            if (dgv_KhachHang.DataSource == null || dgv_KhachHang.Rows.Count == 0)
            {
                btn_Xoa.Enabled = false;
                btn_Sua.Enabled = false;
            }
            else
            {
                btn_Xoa.Enabled = true;
                btn_Sua.Enabled = true;
            }
        }

        public void LoadDataComboGender()
        {
            List<string> lstStatus = new List<string>();
            lstStatus.Add("Nam");
            lstStatus.Add("Nữ");
            cbo_GioiTinh.Properties.DataSource = lstStatus;
            cbo_GioiTinh.EditValue = "Nam";
        }

        private void txt_MaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }


        #endregion
    }
}