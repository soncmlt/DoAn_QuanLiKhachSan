using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_BLL
{
    public class HoaDonDAO
    {
        #region Properties
        DataQLKhachSanDataContext dataContext = new DataQLKhachSanDataContext();
        #endregion
        #region Methods

        public bool InsertInvocie(tbl_HoaDon model)
        {
            try
            {
                dataContext.tbl_HoaDons.InsertOnSubmit(model);
                var objPT = dataContext.tbl_PhieuThues.Where(x => x.MaPhieuThue == model.MaPhieuThue).FirstOrDefault();
                objPT.TinhTrang = true;
                var objPhong = dataContext.tbl_Phongs.Where(x => x.MaPhong == model.MaPhong).FirstOrDefault();
                objPhong.TinhTrang = "Chưa thuê";
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
