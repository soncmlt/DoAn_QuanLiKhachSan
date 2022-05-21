using BO;
using DAO_BLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DoAn_QuanLiKhachSan
{
    public partial class frmQuanLiThongTinNhanVien : DevExpress.XtraEditors.XtraForm
    {

        /* CreatedUser: 162860 - Vo Hoang Bao Son
         * CreatedDate: 20-05-2022
        */
        #region Properties
        LoaiNhanVienDAO objLoaiNhanVienDAO = new LoaiNhanVienDAO();
        NhanVienDAO objNhanVienDAO = new NhanVienDAO();
        #endregion
        public frmQuanLiThongTinNhanVien()
        {
            InitializeComponent();
            LoadDatadLoaiPhong();
            LoadDataComboGender();
            CheckEnable();
        }

        /*
         User: 162860 -Võ Hoàng Bảo Sơn
         Note: Khi không có như cầu sử dụng tất cả các method này xin vui lòng xóa!   
         */
        #region Các methods không cần thiết - vui lòng xóa

        private void txt_tenPhong_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }
        #endregion


        /* CreatedUser: 162860 - Vo Hoang Bao Son
         * CreatedDate: 20-05-2022
        */
        #region Methods

        public void LoadDatadLoaiPhong()
        {
            dgv_ChucVu.DataSource = objLoaiNhanVienDAO.GetALLLoaiNhanVien();
        }
        

        private void dgv_DSLoaiPhong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_ChucVu.DataSource != null && dgv_ChucVu.Rows.Count > 0)
            {
                int index = dgv_ChucVu.CurrentCell.RowIndex;
                txt_tenChucVu.Text = dgv_ChucVu["col_TenChucVu", index].Value.ToString().Trim();
                txt_ChuVu.Text = txt_tenChucVu.Text;
                LoadDataNhanVien(int.Parse(dgv_ChucVu["col_MaChucVu", index].Value.ToString().Trim()));
            }
        }

        private void dgv_DSNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DSNhanVien.DataSource != null && dgv_DSNhanVien.Rows.Count > 0)
            {
                int index = dgv_DSNhanVien.CurrentCell.RowIndex;
                txt_SDT.Text = dgv_DSNhanVien["col_MaNhanVien", index].Value.ToString().Trim();
                txt_TenNV.Text = dgv_DSNhanVien["col_TenNhanVien", index].Value.ToString().Trim();
                cbo_gioiTinh.EditValue = dgv_DSNhanVien["col_GioiTinh", index].Value.ToString().Trim();
                if (dgv_DSNhanVien["col_DiaChi", index].Value != null)
                {
                    txt_diaChi.Text = dgv_DSNhanVien["col_DiaChi", index].Value.ToString().Trim();
                }
                else
                {
                    txt_diaChi.Text = string.Empty;
                }

                if (dgv_DSNhanVien["col_MatKhau", index].Value != null)
                {
                    txt_matKhau.Text = dgv_DSNhanVien["col_MatKhau", index].Value.ToString().Trim();
                }
                else
                {
                    txt_matKhau.Text = string.Empty;
                }
                dtp_ngaySinh.Text = dgv_DSNhanVien["col_NgaySinh", index].Value.ToString().Trim();
                
            }
        }

        private void btn_ThemLoai_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInsertOrUpdatePerSonType())
                {
                    int index = dgv_ChucVu.CurrentCell.RowIndex;
                    LoaiNhanVienBO objLoaiNhanVienBO = new LoaiNhanVienBO();
                    objLoaiNhanVienBO.MaLoaiNV = -1;
                    objLoaiNhanVienBO.TenLoaiNV = txt_tenChucVu.Text.Trim();
                    if (objLoaiNhanVienDAO.InsertOrUpdate(objLoaiNhanVienBO))
                    {
                        MessageBox.Show("Thêm mới chức vụ thành công!");
                        LoadDatadLoaiPhong();
                        CheckEnable();
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới chức vụ thất bại. Xin vui lòng kiểm tra lại!");
                    }
                }
            }
            catch (Exception ex)
            {
                string strMessErr = "Lỗi trong quá trình thêm mới chức vụ trên UI";
                throw new Exception(strMessErr, ex);
            }
        }

        private void btn_SuaLoai_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInsertOrUpdatePerSonType())
                {
                    int index = dgv_ChucVu.CurrentCell.RowIndex;
                    LoaiNhanVienBO objLoaiNhanVienBO = new LoaiNhanVienBO();
                    objLoaiNhanVienBO.MaLoaiNV = int.Parse(dgv_ChucVu["col_MaChucVu", index].Value.ToString().Trim());
                    objLoaiNhanVienBO.TenLoaiNV = txt_tenChucVu.Text.Trim();
                    if (objLoaiNhanVienDAO.InsertOrUpdate(objLoaiNhanVienBO))
                    {
                        MessageBox.Show("Cập nhật chức vụ thành công!");
                        LoadDatadLoaiPhong();
                        CheckEnable();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật chức vụ thất bại. Xin vui lòng kiểm tra lại!");
                    }
                }
            }
            catch (Exception ex)
            {
                string strMessErr = "Lỗi trong quá trình chỉnh sửa chức vụ trên UI";
                throw new Exception(strMessErr, ex);
            }
        }

        public bool CheckInsertOrUpdatePerSonType()
        {
            if (string.IsNullOrEmpty(txt_tenChucVu.Text.Trim()))
            {
                MessageBox.Show("Tên chức vụ không được bỏ trống. Xin vui lòng kiểm tra lại!");
                return false;
            }
            if (txt_tenChucVu.Text.Trim().Length > 50)
            {
                MessageBox.Show("Tên chức vụ không được vượt quá 50 ký tự. Xin vui lòng kiểm tra lại!");
                return false;
            }
            return true;
        }

        private void btn_XoaLoai_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_ChucVu.DataSource != null && dgv_ChucVu.Rows.Count > 0 && dgv_ChucVu.CurrentRow.Selected == true)
                {
                    int index = dgv_ChucVu.CurrentCell.RowIndex;
                    int intPerSonType = int.Parse(dgv_ChucVu["col_MaChucVu", index].Value.ToString().Trim());
                    if (objLoaiNhanVienDAO.Delete(intPerSonType))
                    {
                        MessageBox.Show("Xóa chức vụ thành công!");
                        LoadDatadLoaiPhong();
                        CheckEnable();
                    }
                }
                else
                {
                    MessageBox.Show("Không có dòng nào được chọn để xóa. Xin vui lòng kiểm tra lại!");
                }
            }
            catch (Exception ex)
            {
                string strMessErr = "Lỗi trong quá trình xóa chức vụ trên UI";
                throw new Exception(strMessErr, ex);
            }
        }

        private void btn_ThemPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInsertOrUpdate(true))
                {
                    InsertOrUpdate(true);
                }
            }
            catch (Exception ex)
            {
                string strMessErr = "Lỗi trong quá trình cập nhật dữ liệu nhân viên trên UI";
                throw new Exception(strMessErr, ex);
            }
        }

        public bool CheckInsertOrUpdate(bool isInsert)
        {
            try
            {
                #region SĐT - Mã nhân viên
                if (isInsert)
                {
                    if (string.IsNullOrEmpty(txt_SDT.Text.Trim()))
                    {
                        MessageBox.Show("Số điện thoại nhân viên không được bỏ trống. Xin vui lòng thử lại!");
                        return false;
                    }

                    if (txt_SDT.Text.Trim().Length > 10)
                    {
                        MessageBox.Show("Số điện thoại nhân viên không được vượt quá 50 ký tự. Xin vui lòng thử lại!");
                        return false;
                    }

                    tbl_NhanVien objtbl_NhanVien = new tbl_NhanVien();
                    objtbl_NhanVien = objNhanVienDAO.CheckNhanVienExists(txt_SDT.Text.Trim());

                    if (objtbl_NhanVien != null)
                    {
                        MessageBox.Show("Số điện thoại đã được khai báo cho User [" + objtbl_NhanVien.MaNV + " - " + objtbl_NhanVien.TenNV + "]. Xin vui lòng kiểm tra lại");
                        return false;
                    }
                }
                #endregion

                #region Tên nhân viên
                if (string.IsNullOrEmpty(txt_TenNV.Text.Trim()))
                {
                    MessageBox.Show("Tên nhân viên không được bỏ trống. Xin vui lòng thử lại!");
                    return false;
                }

                if (txt_TenNV.Text.Trim().Length > 50)
                {
                    MessageBox.Show("Tên nhân viên không được vượt quá 50 ký tự. Xin vui lòng thử lại!");
                    return false;
                }
                #endregion

                #region Địa chỉ
                if (!string.IsNullOrEmpty(txt_diaChi.Text.Trim()) && txt_diaChi.Text.Trim().Length > 50)
                {
                    MessageBox.Show("Địa chỉ không được vượt quá 50 ký tự. Xin vui lòng thử lại!");
                    return false;
                }
                #endregion

                #region Ngày sinh
                if (string.IsNullOrEmpty(dtp_ngaySinh.Text.Trim()))
                {
                    MessageBox.Show("Ngày sinh không được bỏ trống. Xin vui lòng kiểm tra lại!");
                    return false;
                }
                #endregion

                #region Mật khẩu
                if (string.IsNullOrEmpty(txt_matKhau.Text.Trim()))
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống. Xin vui lòng thử lại!");
                    return false;
                }

                if (txt_matKhau.Text.Trim().Length > 10)
                {
                    MessageBox.Show("Mật khẩu không được vượt quá 10 ký tự. Xin vui lòng thử lại!");
                    return false;
                }
                #endregion



                return true;
            }
            catch (Exception ex)
            {
                string strMessErr = "Lỗi trong quá trình kiểm tra thông tin cập nhật nhân viên trên UI";
                throw new Exception(strMessErr, ex);
            }
        }

        public void LoadDataComboGender()
        {
            List<string> lstStatus = new List<string>();
            lstStatus.Add("Nam");
            lstStatus.Add("Nữ");
            cbo_gioiTinh.Properties.DataSource = lstStatus;
            cbo_gioiTinh.EditValue = "Nam";
        }

        public void InsertOrUpdate(bool isInsert)
        {
            try
            {
                NhanVienBO model = new NhanVienBO();
                if (isInsert)
                {
                    model.MaNV = txt_SDT.Text.Trim();
                }
                else
                {
                    int index = dgv_DSNhanVien.CurrentCell.RowIndex;
                    model.MaNV = dgv_DSNhanVien["col_MaNhanVien", index].Value.ToString().Trim();
                }
                int indexLoaiNV = dgv_ChucVu.CurrentCell.RowIndex;
                model.MaLoaiNV = int.Parse(dgv_ChucVu["col_MaChucVu", indexLoaiNV].Value.ToString().Trim());
                model.MatKhau = txt_matKhau.Text.Trim();
                model.DiaChi = txt_diaChi.Text.Trim();
                model.GioiTinh = cbo_gioiTinh.Text.Trim();
                model.TenNV = txt_TenNV.Text.Trim();
                model.NgaySinh = DateTime.Parse(dtp_ngaySinh.Text).Date;
                if (objNhanVienDAO.InsertOrUpdate(model))
                {
                    MessageBox.Show("Cập nhật dữ liệu cho nhân viên thành công!");
                    LoadDataNhanVien(model.MaLoaiNV);
                    CheckEnable();
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu cho nhân viên thất bại!");
                }

            }
            catch (Exception ex)
            {
                string strMessErr = "Lỗi trong quá trình cập nhật thông tin nhân viên trên UI";
                throw new Exception(strMessErr, ex);
            }
        }

        public void LoadDataNhanVien(int intTypeId)
        {
            dgv_DSNhanVien.DataSource = objNhanVienDAO.GetNhanVienByTypeId(intTypeId);
        }

        private void btn_SuaPhong_Click(object sender, EventArgs e)
        {
            if (dgv_DSNhanVien.DataSource != null && dgv_DSNhanVien.Rows.Count > 0 && dgv_DSNhanVien.CurrentRow.Selected == true)
            {
                if (CheckInsertOrUpdate(false))
                {
                    InsertOrUpdate(false);
                }
            }
            else
            {
                MessageBox.Show("Danh sách nhân viên đang rỗng không thể chỉnh sửa. Xin vui lòng kiểm tra lại!");
            }
        }

        private void btn_XoaPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_DSNhanVien.DataSource != null && dgv_DSNhanVien.Rows.Count > 0 && dgv_DSNhanVien.CurrentRow.Selected == true)
                {
                    int index = dgv_DSNhanVien.CurrentCell.RowIndex;
                    string strMaNV = dgv_DSNhanVien["col_MaNhanVien", index].Value.ToString().Trim();
                    if (objNhanVienDAO.Delete(strMaNV))
                    {
                        MessageBox.Show("Xóa nhân viên thành công!");
                        int indexLoaiNV = dgv_ChucVu.CurrentCell.RowIndex;
                        int intMaLoai = int.Parse(dgv_ChucVu["col_MaChucVu", indexLoaiNV].Value.ToString().Trim());
                        LoadDataNhanVien(intMaLoai);
                        CheckEnable();
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bạt!");
                    }
                }
                else
                {
                    MessageBox.Show("Danh sách nhân viên đang rỗng không thể xóa. Xin vui lòng kiểm tra lại!");
                }
            }
            catch (Exception ex)
            {
                string strMessErr = "Lỗi trong quá trình cập nhật thông tin nhân viên trên UI";
                throw new Exception(strMessErr, ex);
            }
        }

        public void CheckEnable()
        {
            if (dgv_ChucVu.DataSource == null || dgv_ChucVu.Rows.Count == 0)
            {
                btn_SuaLoai.Enabled = false;
                btn_XoaLoai.Enabled = false;

                btn_ThemNV.Enabled = false;
                btn_SuaNV.Enabled = false;
                btn_XoaNV.Enabled = false;
            }

            if (dgv_ChucVu.Rows.Count > 0)
            {
                btn_SuaLoai.Enabled = true;
                btn_XoaLoai.Enabled = true;
                btn_ThemNV.Enabled = true;
            }

            if (dgv_DSNhanVien.DataSource == null || dgv_DSNhanVien.Rows.Count == 0)
            {
                btn_SuaNV.Enabled = false;
                btn_XoaNV.Enabled = false;
            }

            if (dgv_DSNhanVien.Rows.Count > 0)
            {
                btn_SuaNV.Enabled = true;
                btn_XoaNV.Enabled = true;
            }
        }

        #endregion
    }
}
