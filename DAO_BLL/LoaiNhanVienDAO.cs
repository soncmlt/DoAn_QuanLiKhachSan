using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace DAO_BLL
{
    public class LoaiNhanVienDAO
    {
        DataQLKhachSanDataContext dataContext = new DataQLKhachSanDataContext();
        public List<LoaiNhanVienBO> GetALLLoaiNhanVien()
        {
            var lstResult = from objLoaiNhanVien in dataContext.tbl_LoaiNhanViens
                            select new LoaiNhanVienBO()
                            {
                                MaLoaiNV = objLoaiNhanVien.MaLoaiNV,
                                TenLoaiNV = objLoaiNhanVien.TenLoai
                            };
            return lstResult.OrderByDescending(x => x.MaLoaiNV).ToList();
        }

        public bool InsertOrUpdate(LoaiNhanVienBO objLoaiNhanVienBO)
        {
            try
            {
                var onjCheckDB = dataContext.tbl_LoaiNhanViens.Where(x => x.MaLoaiNV == objLoaiNhanVienBO.MaLoaiNV).FirstOrDefault();
                if (onjCheckDB == null)
                {
                    tbl_LoaiNhanVien objLoaiNV = new tbl_LoaiNhanVien();
                    objLoaiNV.TenLoai = objLoaiNhanVienBO.TenLoaiNV;
                    dataContext.tbl_LoaiNhanViens.InsertOnSubmit(objLoaiNV);
                    dataContext.SubmitChanges();
                }
                else
                {
                    onjCheckDB.TenLoai = objLoaiNhanVienBO.TenLoaiNV;
                    dataContext.SubmitChanges();
                }
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool Delete(int intLoaiNVId)
        {
            try
            {
                var onjCheckDB = dataContext.tbl_LoaiNhanViens.Where(x => x.MaLoaiNV == intLoaiNVId).FirstOrDefault();
                if (onjCheckDB != null)
                {
                    var onjChecNV = dataContext.tbl_NhanViens.Where(x => x.MaLoaiNV == intLoaiNVId);
                    if (onjChecNV != null)
                    {
                        dataContext.tbl_NhanViens.DeleteAllOnSubmit(onjChecNV);
                    }
                    dataContext.tbl_LoaiNhanViens.DeleteOnSubmit(onjCheckDB);
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
    }
}
