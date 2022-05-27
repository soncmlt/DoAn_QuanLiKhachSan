using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace DAO_BLL
{
    public class LoaiPhongDAO 
    {
        DataQLKhachSanDataContext dataContext = new DataQLKhachSanDataContext();
        #region Methods
        /* Createby: 162860 - Vo Hoang Bao Son
           CreatedDate: 13/05/2022
        */

        //Lấy tất cả cả loại phòng
        public List<LoaiPhongBO> GetAllTypeRoom()
        {
            var lstResult = from objLoaiPhong in dataContext.tbl_LoaiPhongs
                            select new LoaiPhongBO()
                            {
                                MaLoaiPhong = objLoaiPhong.MaLoaiPhong,
                                TenLoai = objLoaiPhong.TenLoai,
                                SoGiuong = objLoaiPhong.SoGiuong,
                                GiaGio = objLoaiPhong.GiaGio,
                                GiaNgay = objLoaiPhong.GiaNgay,
                                GiaThang = objLoaiPhong.GiaThang
                            };
            return lstResult.OrderByDescending(x => x.MaLoaiPhong).ToList();
        }
        //Xóa Loại Phòng
        public bool Delete(int intTypeRoomId)
        {
            try
            {
                var lstPhong = dataContext.tbl_Phongs.Where(t => t.MaLoaiPhong == intTypeRoomId);
                var loaiphong = dataContext.tbl_LoaiPhongs.Where(t => t.MaLoaiPhong == intTypeRoomId);
                dataContext.tbl_Phongs.DeleteAllOnSubmit(lstPhong);
                dataContext.tbl_LoaiPhongs.DeleteAllOnSubmit(loaiphong);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                string strMessErr = "Lỗi trong quá trình xóa loại phòng trên BLL";
                throw new Exception(strMessErr, ex);
            }
        }

        public bool Update(int intTypeRoomId, string strTypeName, int intNumberOfBed, int intPriceHour, int intPriceDay, int intPriceMonth)
        {
            try
            {
                var loaiphong = dataContext.tbl_LoaiPhongs.Where(t => t.MaLoaiPhong == intTypeRoomId).FirstOrDefault();
                loaiphong.TenLoai = strTypeName;
                loaiphong.SoGiuong = intNumberOfBed;
                loaiphong.GiaGio = intPriceHour;
                loaiphong.GiaNgay = intPriceDay;
                loaiphong.GiaThang = intPriceMonth;
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Insert(string strTypeName, int intNumberOfBed, int intPriceHour, int intPriceDay, int intPriceMonth)
        {
            try
            {
                tbl_LoaiPhong loaiphong = new tbl_LoaiPhong();
                loaiphong.TenLoai = strTypeName;
                loaiphong.SoGiuong = intNumberOfBed;
                loaiphong.GiaGio = intPriceHour;
                loaiphong.GiaNgay = intPriceDay;
                loaiphong.GiaThang = intPriceMonth;
                dataContext.tbl_LoaiPhongs.InsertOnSubmit(loaiphong);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region TestMethod
        //public string TestThemPhong (LoaiPhongBO loai, string tenPhong, string loaiGiuong)
        //{
        //    try
        //    {
        //        int intSoGiuong = -1;
        //        int intPriceHoure = -1;
        //        int intPriceDay = -1;
        //        int intPriceMonth = -1;
        //        if (string.IsNullOrEmpty(loai.TenLoai) || string.IsNullOrEmpty(loai.SoGiuong))
        //        {
        //            MessageBox.Show("Dữ liệu thêm mới không được bỏ trống. Xin vui lòng kiểm tra lại!");
        //            return;
        //        }
        //        else if (!int.TryParse(txt_soGiuong.Text.Trim(), out intSoGiuong))
        //        {
        //            MessageBox.Show("Số giường phải là kiểu số nguyên > 0. Xin vui lòng kiểm tra lại!");
        //            return;
        //        }
        //        else if (string.IsNullOrEmpty(txt_GiaGio.Text.Trim()) || string.IsNullOrEmpty(txt_GiaNgay.Text.Trim()) || string.IsNullOrEmpty(txt_GiaThang.Text.Trim()))
        //        {
        //            MessageBox.Show("Thông tin về giá không được bỏ trống. Xin vui lòng kiểm tra lại!");
        //            return;
        //        }
        //        else
        //        {
        //            intPriceHoure = int.Parse(txt_GiaGio.Text.Trim());
        //            intPriceDay = int.Parse(txt_GiaNgay.Text.Trim());
        //            intPriceMonth = int.Parse(txt_GiaThang.Text.Trim());
        //            if (objLoaiPhongDAO.Insert(txt_tenLoai.Text, intSoGiuong, intPriceHoure, intPriceDay, intPriceMonth))
        //            {
        //                MessageBox.Show("Thêm loại phòng thành công!");
        //                LoadTypeRoom();
        //                CheckDataTypeRooome();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Thêm loại phòng thất bại!");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string strMessErr = "Lỗi trong quá trình thêm loại phòng trên UI";
        //        throw new Exception(strMessErr, ex);
        //    }
        //}
        #endregion
    }
}
