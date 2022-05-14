using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public IQueryable GetAllTypeRoom()
        {
            return dataContext.tbl_LoaiPhongs.Select(t => t);
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
    }
}
