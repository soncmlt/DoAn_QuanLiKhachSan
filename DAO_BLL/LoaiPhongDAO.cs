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
        public string TestThemPhong (string tenLoai, string tenPhong, string giaGio, string giaNgay,string giaThang,  string loaiGiuong)
        {
            try
            {
                int intSoGiuong = -1;
                int intPriceHoure = -1;
                int intPriceDay = -1;
                int intPriceMonth = -1;
                if (string.IsNullOrEmpty(tenLoai) || string.IsNullOrEmpty(loaiGiuong))
                {
                    return ("Dữ liệu thêm mới không được bỏ trống. Xin vui lòng kiểm tra lại!");
                }
                else if (!int.TryParse(loaiGiuong, out intSoGiuong))
                {
                    return ("Số giường phải là kiểu số nguyên > 0. Xin vui lòng kiểm tra lại!");
                }
                else if (string.IsNullOrEmpty(giaGio) || string.IsNullOrEmpty(giaNgay) || string.IsNullOrEmpty(giaThang))
                {
                    return ("Thông tin về giá không được bỏ trống. Xin vui lòng kiểm tra lại!");
                }
                else
                {
                    intPriceHoure = int.Parse(giaGio);
                    intPriceDay = int.Parse(giaNgay);
                    intPriceMonth = int.Parse(giaThang);
                    if (Insert(tenLoai, intSoGiuong, intPriceHoure, intPriceDay, intPriceMonth))
                    {
                        return ("Thêm loại phòng thành công!");
                    }
                    else
                    {
                        return ("Thêm loại phòng thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                string strMessErr = "Lỗi trong quá trình thêm loại phòng trên UI";
                throw new Exception(strMessErr, ex);
            }
        }
        #endregion
    }
}
