using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
namespace DAO_BLL
{
    public class PhieuThueDAO
    {
        /* Createby: 162860 - Vo Hoang Bao Son
           CreatedDate: 22/05/2022
        */
        DataQLKhachSanDataContext dataContext = new DataQLKhachSanDataContext();
        #region Methods

        public List<PhieuThueBO> GetAllDataPhieuThue()
        {
            try
            {
                var lstResult = from objPT in dataContext.tbl_PhieuThues
                                where objPT.TinhTrang == false
                                select new PhieuThueBO()
                                {
                                    MaPhieuThue = objPT.MaPhieuThue,
                                    MaPhong = objPT.MaPhong,
                                    MaHinhThuc = objPT.MaHinhThuc,
                                    MaKH = objPT.MaKH,
                                    NgayDat = objPT.NgayDat
                                };
                return lstResult.OrderByDescending(x => x.MaPhieuThue).ToList();
            }
            catch
            {
                return null;
            }
        }

        public bool InsertOrUpdate(PhieuThueBO objPhieuThueBO)
        {
            try
            {
                var objPT = dataContext.tbl_PhieuThues.Where(x => x.MaPhieuThue == objPhieuThueBO.MaPhieuThue).FirstOrDefault();
                if (objPT == null)
                {
                    tbl_PhieuThue objInsert = new tbl_PhieuThue();
                    objInsert.MaPhong = objPhieuThueBO.MaPhong;
                    objInsert.MaHinhThuc = objPhieuThueBO.MaHinhThuc;
                    objInsert.NgayDat = DateTime.Now;
                    objInsert.MaKH = objPhieuThueBO.MaKH;
                    objInsert.TinhTrang = false;
                    dataContext.tbl_PhieuThues.InsertOnSubmit(objInsert);
                    var objPhong = dataContext.tbl_Phongs.Where(x => x.MaPhong == objPhieuThueBO.MaPhong).FirstOrDefault();
                    objPhong.TinhTrang = "Đã thuê";
                }
                else
                {
                    objPT.MaHinhThuc = objPhieuThueBO.MaHinhThuc;
                    objPT.MaPhong = objPhieuThueBO.MaPhong;
                }
                dataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool Delete(int intRenVoucherId)
        {
            try
            {
                var objPT = dataContext.tbl_PhieuThues.Where(x => x.MaPhieuThue == intRenVoucherId).FirstOrDefault();
                if (objPT == null)
                {
                    return false;
                }
                else
                {
                    dataContext.tbl_PhieuThues.DeleteOnSubmit(objPT);
                    var objPhong = dataContext.tbl_Phongs.Where(x => x.MaPhong == objPT.MaPhong).FirstOrDefault();
                    if (objPhong != null)
                    {
                        objPhong.TinhTrang = "Chưa thuê";
                    }
                    else
                    {
                        return false;
                    }
                }
                dataContext.SubmitChanges();
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
