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
        LoaiPhongDAO objLoaiPhongDAO = new LoaiPhongDAO();
        public frmChinhSuaPhong()
        {
            InitializeComponent();
            LoadTypeRoom();
            cbo_loaiPhong.Properties.NullText = string.Empty;
            List<string> lstStatus = new List<string>();
            lstStatus.Add("Chưa thuê");
            lstStatus.Add("Đã thuê");
            cbo_TrangThai.Properties.DataSource = lstStatus;
            cbo_TrangThai.Properties.NullText = string.Empty;
        }

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
            cbo_loaiPhong.Properties.DataSource = objLoaiPhongDAO.GetAllTypeRoom();
            cbo_loaiPhong.Properties.DisplayMember = "TenLoai";
            cbo_loaiPhong.Properties.ValueMember = "MaLoaiPhong";
            cbo_loaiPhong.Properties.NullText = string.Empty;
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
                    int index = dgv_DSLoaiPhong.CurrentCell.RowIndex;
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
    }
}