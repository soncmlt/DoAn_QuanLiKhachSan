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
    public partial class frmThanhToan : DevExpress.XtraEditors.XtraForm
    {
        #region
        PhieuThueDAO objPhieuThueDAO = new PhieuThueDAO();
        PhongDAO objPhong = new PhongDAO();
        LoaiPhongDAO objLoaiPhong = new LoaiPhongDAO();
        HoaDonDAO objHoaDonDAO = new HoaDonDAO();
        #endregion
        public frmThanhToan()
        {
            InitializeComponent();
        }

        public bool CheckValueSearch()
        {
            try
            {
                if (string.IsNullOrEmpty(dtp_ngayBatDau.Text.Trim()) || string.IsNullOrEmpty(dtp_ngayKetThuc.Text.Trim()))
                {
                    MessageBox.Show("Ngày bắt đầu và ngày kết thúc không được bỏ trống xin vui lòng kiểm tra lại!. Xin vui lòng kiểm tra lại!");
                    return false;
                }
                DateTime dtFrom = DateTime.Parse(dtp_ngayBatDau.Text.Trim());
                DateTime dtTo = DateTime.Parse(dtp_ngayKetThuc.Text.Trim());
                if (DateTime.Compare(dtFrom, dtTo) > 0)
                {
                    MessageBox.Show("Ngày bắt đầu không được nhỏ hơn ngày kết thúc. Xin vui lòng kiểm tra lại!");
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            if (CheckValueSearch())
            {
                loadDataPhieuThue();
                CheckEnable();
            }

        }

        public void loadDataPhieuThue()
        {
            DateTime dtFrom = DateTime.Parse(dtp_ngayBatDau.Text.Trim());
            DateTime dtTo = DateTime.Parse(dtp_ngayKetThuc.Text.Trim());
            dgv_DSPhieuThue.DataSource = objPhieuThueDAO.GetListPhieuThueByDate(dtFrom, dtTo);
        }

        private void dgv_DSPhieuThue_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DSPhieuThue.DataSource != null && dgv_DSPhieuThue.Rows.Count > 0)
            {
                int index = dgv_DSPhieuThue.CurrentCell.RowIndex;
                int itnMaPT = int.Parse(dgv_DSPhieuThue["col_MaPhieuDat", index].Value.ToString().Trim());
                int intMaHT = int.Parse(dgv_DSPhieuThue["col_HinhThucThue", index].Value.ToString().Trim());
                int intMaPhong = int.Parse(dgv_DSPhieuThue["col_MaPhong", index].Value.ToString().Trim());
                var objResultPT = objPhieuThueDAO.GetListPhieuThueByDate(itnMaPT);
                if (objResultPT != null)
                {
                    txt_tenKH.Text = objResultPT.TenKH.Trim();
                    txt_CMND.Text = objResultPT.MaKH.Trim();
                    txt_phong.Text = objResultPT.TenPhong.Trim();
                    txt_ngayDat.Text = objResultPT.NgayDat.ToString();
                    txt_HinhThuc.Text = objResultPT.TenHinhThuc.ToString();
                    txt_ngayTra.Text = DateTime.Now.ToString();
                    double dbTimeRen = CalThoiGianThue(intMaHT, (DateTime)objResultPT.NgayDat, DateTime.Now);
                    txt_thoiGianThue.Text = dbTimeRen.ToString();
                    var objPhongDB = objPhong.LoadMenuRoom().Where(x => x.MaPhong == intMaPhong).FirstOrDefault();
                    var objLoaiPhongDB = objLoaiPhong.GetAllTypeRoom().Where(x => x.MaLoaiPhong == objPhongDB.MaLoaiPhong).FirstOrDefault();
                    double totalPrice = CalPrice(intMaHT, dbTimeRen, objLoaiPhongDB);
                    txt_tongTien.Text = totalPrice.ToString();
                }
            }
        }

        public double CalThoiGianThue(int intTypeId, DateTime dtFrom, DateTime dtTo)
        {
            try
            {
                TimeSpan dbTimeRen = dtTo - dtFrom;
                //Id = 1: Thuê theo giờ
                if (intTypeId == 1)
                {
                    if (dbTimeRen.TotalHours < 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return dbTimeRen.TotalHours;
                    }

                }
                //Id = 2: Thuê theo ngày
                else if (intTypeId == 2)
                {

                    if (dbTimeRen.TotalDays < 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return dbTimeRen.TotalDays;
                    }
                }
                else
                {
                    int totalMonth = Math.Abs((dtFrom.Month - dtTo.Month) + 12 * (dtFrom.Year - dtTo.Year));
                    if (totalMonth == 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return totalMonth;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi tính thời gian thuê phòng trên UI", ex);
            }
        }

        public double CalPrice(int intTyepId, double dbTimeRen, LoaiPhongBO objLoaiPhongBO)
        {
            try
            {
                if (intTyepId == 1)
                {
                    return dbTimeRen * (double)objLoaiPhongBO.GiaGio;
                }
                else if (intTyepId == 2)
                {
                    return dbTimeRen * (double)objLoaiPhongBO.GiaNgay;
                }
                else
                {
                    return dbTimeRen * (double)objLoaiPhongBO.GiaThang;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi tính tiền thuê phòng trên UI", ex);
            }
        }

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_HoaDon objHD = new tbl_HoaDon();
                int index = dgv_DSPhieuThue.CurrentCell.RowIndex;
                objHD.MaPhieuThue = int.Parse(dgv_DSPhieuThue["col_MaPhieuDat", index].Value.ToString().Trim());
                objHD.MaHinhThuc = int.Parse(dgv_DSPhieuThue["col_HinhThucThue", index].Value.ToString().Trim());
                objHD.MaPhong = int.Parse(dgv_DSPhieuThue["col_MaPhong", index].Value.ToString().Trim());
                objHD.MaKH = Convert.ToString(dgv_DSPhieuThue["col_MaPhong", index].Value).Trim();
                objHD.GioVao = Convert.ToDateTime(dgv_DSPhieuThue["col_NgayDat", index].Value.ToString().Trim());
                objHD.GioRa = DateTime.Parse(txt_ngayTra.Text.Trim());
                objHD.ThoiGianThue = double.Parse(txt_thoiGianThue.Text.Trim());
                objHD.TongTien = double.Parse(txt_tongTien.Text.Trim());
                if (objHoaDonDAO.InsertInvocie(objHD))
                {
                    MessageBox.Show("Thanh toán thành công!");
                    loadDataPhieuThue();
                    CheckEnable();
                }
                else
                {
                    MessageBox.Show("Thanh toán thất bại!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thanh toán hóa đơn trên UI", ex);
            }
        }

        public void CheckEnable()
        {
            if (dgv_DSPhieuThue.DataSource == null || dgv_DSPhieuThue.Rows.Count == 0)
            {
                btn_thanhToan.Enabled = false;
            }
            else
            {
                btn_thanhToan.Enabled = true;
            }
        }
    }
}