using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace DAO_BLL
{
    public class NhanVienDAO
    {
        DataQLKhachSanDataContext dataContext = new DataQLKhachSanDataContext();
        #region
        /* Createby: 162860 - Vo Hoang Bao Son
           CreatedDate: 01/05/2022
        */
        public List<NhanVienCustomBOView> GetALLNhanVien()
        {
            var lstResult = from objNhanVien in dataContext.tbl_NhanViens
                            select new NhanVienCustomBOView()
                            {
                                MaNV = objNhanVien.MaNV,
                                TenNV = objNhanVien.TenNV,
                                GioiTinh = objNhanVien.GioiTinh,
                                MatKhau = objNhanVien.MatKhau
                            };
            return lstResult.OrderByDescending(x => x.MaNV).ToList();
        }

        public tbl_NhanVien LoadNhanVien(string strUserName, string strPass)
        {
            
            return dataContext.tbl_NhanViens.Where(x => x.MaNV.Trim() == strUserName && x.MatKhau.Trim() == strPass).FirstOrDefault();
        }

        public bool InsertOrUpdate(NhanVienBO model)
        {
            try
            {
                var objCheckDB = dataContext.tbl_NhanViens.Where(x => x.MaNV.Trim() == model.MaNV.Trim()).FirstOrDefault();
                if (objCheckDB == null)
                {
                    tbl_NhanVien objNV = new tbl_NhanVien();
                    objNV.MaNV = model.MaNV;
                    objNV.TenNV = model.TenNV;
                    objNV.MatKhau = model.MatKhau;
                    objNV.MaLoaiNV = model.MaLoaiNV;
                    objNV.GioiTinh = model.GioiTinh;
                    dataContext.tbl_NhanViens.InsertOnSubmit(objNV);
                    dataContext.SubmitChanges();
                }
                else
                {
                    objCheckDB.TenNV = model.TenNV;
                    objCheckDB.MatKhau = model.MatKhau;
                    objCheckDB.MaLoaiNV = model.MaLoaiNV;
                    objCheckDB.GioiTinh = model.GioiTinh;
                    dataContext.SubmitChanges(); 
                }
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool Delete(string strMaNV)
        {
            try
            {
                var objNV = dataContext.tbl_NhanViens.Where(x => x.MaNV.Trim() == strMaNV.Trim()).FirstOrDefault();
                if (objNV != null)
                {
                    dataContext.tbl_NhanViens.DeleteOnSubmit(objNV);
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
