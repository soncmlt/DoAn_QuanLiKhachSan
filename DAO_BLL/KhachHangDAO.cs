using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
namespace DAO_BLL
{
    public class KhachHangDAO
    {
        /* Createby: 162860 - Vo Hoang Bao Son
           CreatedDate: 21/05/2022
        */
        #region Properties

        DataQLKhachSanDataContext dataContext = new DataQLKhachSanDataContext();

        #endregion

        #region Methods

        public List<KhachHangBO> GetDataCustomer()
        {
            try
            {
                var lstResult = from objKH in dataContext.tbl_KhachHangs
                                select new KhachHangBO()
                                {
                                    MaKH = objKH.MaKH,
                                    TenKH = objKH.TenKH,
                                    SDT = objKH.SDT,
                                    GioiTinh = objKH.GioiTinh,
                                    NgaySinh = objKH.NgaySinh,
                                    DiaChi = objKH.DiaChi
                                };
                return lstResult.OrderByDescending(x => x.MaKH).ToList();
            }
            catch
            {
                return null;
            }
        }


        public bool InsertOrUpdate(KhachHangBO objKhachHangBO)
        {
            try
            {
                var objCheckDB = dataContext.tbl_KhachHangs.Where(x => x.MaKH.Trim() == objKhachHangBO.MaKH.Trim()).FirstOrDefault();
                if (objCheckDB == null)
                {
                    tbl_KhachHang objKH = new tbl_KhachHang();
                    objKH.MaKH = objKhachHangBO.MaKH;
                    objKH.TenKH = objKhachHangBO.TenKH;
                    objKH.SDT = objKhachHangBO.SDT;
                    objKH.GioiTinh = objKhachHangBO.GioiTinh;
                    objKH.NgaySinh = objKhachHangBO.NgaySinh;
                    objKH.DiaChi = objKhachHangBO.DiaChi;
                    dataContext.tbl_KhachHangs.InsertOnSubmit(objKH);
                }
                else
                {
                    objCheckDB.TenKH = objKhachHangBO.TenKH;
                    objCheckDB.SDT = objKhachHangBO.SDT;
                    objCheckDB.GioiTinh = objKhachHangBO.GioiTinh;
                    objCheckDB.NgaySinh = objKhachHangBO.NgaySinh;
                    objCheckDB.DiaChi = objKhachHangBO.DiaChi;
                    dataContext.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(string strMaKH)
        {
            try
            {
                var objKH = dataContext.tbl_KhachHangs.Where(x => x.MaKH.Trim() == strMaKH.Trim()).FirstOrDefault();
                if (objKH != null)
                {
                    dataContext.tbl_KhachHangs.DeleteOnSubmit(objKH);
                    dataContext.SubmitChanges();
                }
                else
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }

        }
        #endregion
    }
}
