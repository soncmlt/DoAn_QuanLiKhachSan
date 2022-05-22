using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_BLL
{
    public class PhongDAO
    {
        DataQLKhachSanDataContext dataContext = new DataQLKhachSanDataContext();
        #region Methods
        /* Createby: 162860 - Vo Hoang Bao Son
           CreatedDate: 13/05/2022
        */
        public List<PhongBO> GetRoomByTyRoomId(int intTypeRoomId)
        {
            var objPhongTro = from objPhong in dataContext.tbl_Phongs
                              from objLoaiPhong in dataContext.tbl_LoaiPhongs
                              where objPhong.MaLoaiPhong == objLoaiPhong.MaLoaiPhong && objPhong.MaLoaiPhong == intTypeRoomId
                              select new PhongBO ()
                              { MaLoaiPhong = objPhong.MaLoaiPhong, TenPhong = objPhong.TenPhong, MaPhong = objPhong.MaPhong, TinhTrang = objPhong.TinhTrang };
            return objPhongTro.ToList();
        }

        public bool Insert(string strRoomName, int intTypeRoommId, string strStatus)
        {
            try
            {
                tbl_Phong pbjPhong = new tbl_Phong();
                pbjPhong.TenPhong = strRoomName;
                pbjPhong.MaLoaiPhong = intTypeRoommId;
                pbjPhong.TinhTrang = strStatus;
                dataContext.tbl_Phongs.InsertOnSubmit(pbjPhong);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int intRoomId)
        {
            try
            {
                var objPhong = dataContext.tbl_Phongs.Where(t => t.MaPhong == intRoomId);
                dataContext.tbl_Phongs.DeleteAllOnSubmit(objPhong);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(int intRoomId, string strRoomName, string  strStatush)
        {
            try
            {
                var objPhong = dataContext.tbl_Phongs.Where(t => t.MaPhong == intRoomId).FirstOrDefault();
                objPhong.TenPhong = strRoomName;
                objPhong.TinhTrang = strStatush;
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<PhongBO> LoadMenuRoom()
        {
            var lstResult = from objPhong in dataContext.tbl_Phongs
                            join objLoaiPhong in dataContext.tbl_LoaiPhongs
                            on objPhong.MaLoaiPhong equals objLoaiPhong.MaLoaiPhong
                            select new PhongBO()
                            {
                                MaPhong = objPhong.MaPhong,
                                TenLoai = objLoaiPhong.TenLoai,
                                MaLoaiPhong = objPhong.MaLoaiPhong,
                                TenPhong = objPhong.TenPhong,
                                TinhTrang = objPhong.TinhTrang
                            };
            return lstResult.OrderByDescending(x => x.MaPhong).ToList();
        }

        public bool UpdateStatus(int intRoomId)
        {
            try
            {
                var objPhong = dataContext.tbl_Phongs.Where(x => x.MaPhong == intRoomId).FirstOrDefault();
                if (objPhong != null)
                {
                    objPhong.TinhTrang = "Đã thuê";
                    dataContext.SubmitChanges();
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
        #endregion
    }
}
