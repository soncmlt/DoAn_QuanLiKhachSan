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
    public partial class frmChinhSuaPhong : DevExpress.XtraEditors.XtraForm
    {
        /*
         * Created User: 162860 - Võ Hoàng Bảo Sơn
         * Created Date: 14/05/2022
         */
        #region Properties
        LoaiPhongDAO objLoaiPhongDAO = new LoaiPhongDAO();
        PhongDAO objPhongDAO = new PhongDAO();
        #endregion
        public frmChinhSuaPhong()
        {
            InitializeComponent();
            LoadTypeRoom();
            LoadDataComboStatus();
            CheckDataTypeRooome();
        }

        #region Methods
        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void dgv_DSLoaiPhong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DSLoaiPhong.DataSource != null && dgv_DSLoaiPhong.Rows.Count > 0 && dgv_DSLoaiPhong.CurrentRow.Selected == true)
            {
                int index = dgv_DSLoaiPhong.CurrentCell.RowIndex;
                txt_tenLoai.Text = dgv_DSLoaiPhong["col_TenLoai", index].Value.ToString().Trim();
                txt_soGiuong.Text = dgv_DSLoaiPhong["col_SoGiuong", index].Value.ToString().Trim();
                txt_MaLoaiPhong.Text = dgv_DSLoaiPhong["col_TenLoai", index].Value.ToString().Trim();
                GetDataRoomByTypeRoomId(int.Parse(dgv_DSLoaiPhong["col_MaLoai", index].Value.ToString().Trim()));
                CheckDataTypeRooome();
            }

        }

        private void btn_XoaLoai_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_DSLoaiPhong.DataSource != null && dgv_DSLoaiPhong.Rows.Count > 0 && dgv_DSLoaiPhong.CurrentRow.Selected == true)
                {
                    int index = dgv_DSLoaiPhong.CurrentCell.RowIndex;
                    if (objLoaiPhongDAO.Delete(int.Parse(dgv_DSLoaiPhong["col_MaLoai", index].Value.ToString().Trim())))
                    {
                        MessageBox.Show("Xóa loại phòng thành công!");
                        LoadTypeRoom();
                        CheckDataTypeRooome();
                    }
                }
                else
                {
                    MessageBox.Show("Không có dòng nào được chọn để xóa. Xin vui lòng kiểm tra lại!");
                }

            }
            catch (Exception ex)
            {
                string strMessErr = "Lỗi trong quá trình xóa loại phòng trên UI";
                throw new Exception(strMessErr, ex);
            }
        }

        public void LoadTypeRoom()
        {
            dgv_DSLoaiPhong.DataSource = objLoaiPhongDAO.GetAllTypeRoom();
            //cbo_loaiPhong.Properties.DataSource = objLoaiPhongDAO.GetAllTypeRoom();
            //cbo_loaiPhong.Properties.DisplayMember = "TenLoai";
            //cbo_loaiPhong.Properties.ValueMember = "MaLoaiPhong";
            //cbo_loaiPhong.Properties.NullText = string.Empty;
            //cbo_loaiPhong.Properties.NullText = string.Empty;
        }

        private void btn_SuaLoai_Click(object sender, EventArgs e)
        {
            try
            {
                int intSoGiuong = -1;
                if (dgv_DSLoaiPhong.DataSource == null || dgv_DSLoaiPhong.Rows.Count == 0)
                {
                    MessageBox.Show("Danh sách loại phòng hiện đang rỗng. Xin vui lòng kiểm tra lại!");
                }
                else if (string.IsNullOrEmpty(txt_tenLoai.Text.Trim()) || string.IsNullOrEmpty(txt_soGiuong.Text.Trim()))
                {
                    MessageBox.Show("Dữ liệu chỉnh sửa không được bỏ trống. Xin vui lòng kiểm tra lại!");
                }
                else if (!int.TryParse(txt_soGiuong.Text.Trim(), out intSoGiuong))
                {
                    MessageBox.Show("Số giường phải là kiểu số nguyên > 0. Xin vui lòng kiểm tra lại!");
                }
                else if (dgv_DSLoaiPhong.CurrentRow.Selected == true)
                {
                    int index = dgv_DSLoaiPhong.CurrentCell.RowIndex;
                    if (objLoaiPhongDAO.Update(int.Parse(dgv_DSLoaiPhong["col_MaLoai", index].Value.ToString().Trim()), txt_tenLoai.Text, intSoGiuong, 2000, 2000, 2000))
                    {
                        MessageBox.Show("Sửa loại phòng thành công!");
                        LoadTypeRoom();
                    }
                    else
                    {
                        MessageBox.Show("Sửa loại phòng thất bại!");
                    }
                }

            }
            catch (Exception ex)
            {
                string strMessErr = "Lỗi trong quá trình sửa loại phòng trên UI";
                throw new Exception(strMessErr, ex);
            }
        }

        private void btn_ThemLoai_Click(object sender, EventArgs e)
        {
            try
            {
                int intSoGiuong = -1;
                if (string.IsNullOrEmpty(txt_tenLoai.Text.Trim()) || string.IsNullOrEmpty(txt_soGiuong.Text.Trim()))
                {
                    MessageBox.Show("Dữ liệu thêm mới không được bỏ trống. Xin vui lòng kiểm tra lại!");
                    return;
                }
                else if (!int.TryParse(txt_soGiuong.Text.Trim(), out intSoGiuong))
                {
                    MessageBox.Show("Số giường phải là kiểu số nguyên > 0. Xin vui lòng kiểm tra lại!");
                }
                else
                {
                    if (objLoaiPhongDAO.Insert(txt_tenLoai.Text, intSoGiuong, 2000, 2000, 2000))
                    {
                        MessageBox.Show("Thêm loại phòng thành công!");
                        LoadTypeRoom();
                    }
                    else
                    {
                        MessageBox.Show("Thêm loại phòng thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                string strMessErr = "Lỗi trong quá trình thêm loại phòng trên UI";
                throw new Exception(strMessErr, ex);
            }
        }

        public void LoadDataComboStatus()
        {
            List<string> lstStatus = new List<string>();
            lstStatus.Add("Chưa thuê");
            lstStatus.Add("Đã thuê");
            cbo_TrangThai.Properties.DataSource = lstStatus;
            cbo_TrangThai.Text = "Chưa thuê";
        }

        public void CheckDataTypeRooome()
        {
            if (dgv_DSLoaiPhong.DataSource == null || dgv_DSLoaiPhong.Rows.Count == 0)
            {
                btn_ThemPhong.Enabled = false;
                btn_SuaPhong.Enabled = false;
                btn_XoaPhong.Enabled = false;
                btn_SuaLoai.Enabled = false;
                btn_XoaLoai.Enabled = false;
            }
            if (dgv_DSPhong.DataSource == null || dgv_DSPhong.Rows.Count == 0)
            {
                btn_SuaPhong.Enabled = false;
                btn_XoaPhong.Enabled = false;
            }
        }
        #endregion

        private void dgv_DSPhong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DSPhong.DataSource != null && dgv_DSPhong.Rows.Count > 0 && dgv_DSPhong.CurrentRow.Selected == true)
            {
                int index = dgv_DSPhong.CurrentCell.RowIndex;
                txt_tenPhong.Text = dgv_DSPhong["col_TenPhong", index].Value.ToString().Trim();
                cbo_TrangThai.EditValue = dgv_DSPhong["col_TrangThai", index].Value.ToString().Trim();
            }
        }

        private void btn_ThemPhong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tenPhong.Text.Trim()))
            {
                MessageBox.Show("Tên phòng không được bỏ trống. Xin vui lòng kiểm tra lại!");
            }
            else if (txt_tenPhong.Text.Trim().Length > 20)
            {
                MessageBox.Show("Tên phòng không được vượt quá 20 ký tự. Xin vui lòng kiểm tra lại");
            }
            else
            {
                int index = dgv_DSLoaiPhong.CurrentCell.RowIndex;
                if (objPhongDAO.Insert(txt_tenPhong.Text.Trim(), int.Parse(dgv_DSLoaiPhong["col_MaLoai", index].Value.ToString().Trim()), "Chưa thuê"))
                {
                    MessageBox.Show("Thêm mới phòng thành công!");
                    GetDataRoomByTypeRoomId(int.Parse(dgv_DSLoaiPhong["col_MaLoai", index].Value.ToString().Trim()));
                    CheckDataTypeRooome();
                }
            }
        }

        public void GetDataRoomByTypeRoomId(int intTypeRoomId)
        {
            dgv_DSPhong.DataSource = objPhongDAO.GetRoomByTyRoomId(intTypeRoomId);
        }

        private void btn_XoaPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_DSPhong.DataSource != null && dgv_DSPhong.Rows.Count > 0 && dgv_DSPhong.CurrentRow.Selected == true)
                {
                    int index = dgv_DSPhong.CurrentCell.RowIndex;
                    if (objPhongDAO.Delete(int.Parse(dgv_DSPhong["col_MaPhong", index].Value.ToString().Trim())))
                    {
                        MessageBox.Show("Xóa phòng thành công!");
                        int indexLoaiPhong = dgv_DSLoaiPhong.CurrentCell.RowIndex;
                        GetDataRoomByTypeRoomId(int.Parse(dgv_DSLoaiPhong["col_MaLoai", indexLoaiPhong].Value.ToString().Trim()));
                        CheckDataTypeRooome();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi trong quá trình xóa phòng. Xin vui lòng kiểm tra lại!");
                    }
                }
                else
                {
                    MessageBox.Show("Không có dòng nào được chọn để xóa. Xin vui lòng kiểm tra lại!");
                }

            }
            catch (Exception ex)
            {
                string strMessErr = "Lỗi trong quá trình xóa loại phòng trên UI";
                throw new Exception(strMessErr, ex);
            }
        }

        private void btn_SuaPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_tenPhong.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Tên phòng không được bỏ trống. Xin vui lòng kiểm tra lại");
                }
                else if (txt_tenPhong.Text.Trim().Length > 20)
                {
                    MessageBox.Show("Tên phòng không được vượt quá 20 ký tự. Xin vui lòng kiểm tra lại");
                }
                else if (dgv_DSPhong.CurrentRow.Selected == true)
                {
                    int index = dgv_DSPhong.CurrentCell.RowIndex;
                    if (objPhongDAO.Update(int.Parse(dgv_DSPhong["col_MaPhong", index].Value.ToString().Trim()), txt_tenPhong.Text, cbo_TrangThai.Text))
                    {
                        MessageBox.Show("Sửa phòng thành công!");
                        int indexLoaiPhong = dgv_DSLoaiPhong.CurrentCell.RowIndex;
                        GetDataRoomByTypeRoomId(int.Parse(dgv_DSLoaiPhong["col_MaLoai", indexLoaiPhong].Value.ToString().Trim()));
                    }
                    else
                    {
                        MessageBox.Show("Sửa phòng thất bại!");
                    }
                }

            }
            catch (Exception ex)
            {
                string strMessErr = "Lỗi trong quá trình sửa loại phòng trên UI";
                throw new Exception(strMessErr, ex);
            }
        }
    }
}