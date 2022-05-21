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
        /* Createby: 162860 - Vo Hoang Bao Son
           CreatedDate: 01/05/2022
        */
        #region Properties

        DataQLKhachSanDataContext dataContext = new DataQLKhachSanDataContext();

        #endregion

        #region Methods
        
        public List<NhanVienCustomBOView> GetNhanVienByTypeId(int intTypeId)
        {
            var lstResult = from objNhanVien in dataContext.tbl_NhanViens
                            join objLoaiNV in dataContext.tbl_LoaiNhanViens
                            on objNhanVien.MaLoaiNV equals objLoaiNV.MaLoaiNV
                            where objNhanVien.MaLoaiNV == intTypeId
                            select new NhanVienCustomBOView()
                            {
                                MaNV = objNhanVien.MaNV,
                                TenNV = objNhanVien.TenNV,
                                GioiTinh = objNhanVien.GioiTinh,
                                ChucVu = objLoaiNV.TenLoai,
                                DiaChi = objNhanVien.Diachi,
                                NgaySinh = objNhanVien.NgaySinh,
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
                    objNV.MatKhau = model.MaNV;
                    objNV.MaLoaiNV = model.MaLoaiNV;
                    objNV.GioiTinh = model.GioiTinh;
                    objNV.Diachi = model.DiaChi;
                    objNV.NgaySinh = model.NgaySinh;
                    dataContext.tbl_NhanViens.InsertOnSubmit(objNV);
                    dataContext.SubmitChanges();
                }
                else
                {
                    objCheckDB.TenNV = model.TenNV;
                    objCheckDB.MatKhau = model.MatKhau;
                    objCheckDB.GioiTinh = model.GioiTinh;
                    objCheckDB.NgaySinh = model.NgaySinh;
                    objCheckDB.Diachi = model.DiaChi;
                    dataContext.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public tbl_NhanVien CheckNhanVienExists(string strPhoneNumber)
        {
            try
            {
                return dataContext.tbl_NhanViens.Where(x => x.MaNV.Trim() == strPhoneNumber.Trim()).FirstOrDefault();
            }
            catch
            {
                return null;
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
