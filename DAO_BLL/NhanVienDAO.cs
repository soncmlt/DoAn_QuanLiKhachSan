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
        public NhanVienBO GetInfoNhanVien(string strUserName)
        {
            var result = from objNhanVien in dataContext.tbl_NhanViens
                         where objNhanVien.MaNV == strUserName
                         select new NhanVienBO()
                         {
                             MaNV = objNhanVien.MaNV,
                             TenNV = objNhanVien.TenNV,
                             GioiTinh = objNhanVien.GioiTinh,
                             MaLoaiNV=objNhanVien.MaLoaiNV,
                             DiaChi = objNhanVien.Diachi,
                             NgaySinh = objNhanVien.NgaySinh,
                             MatKhau = objNhanVien.MatKhau
                         };
            return result.FirstOrDefault();
        }

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

        #region TestMethods

        public string TestDangNhap(string tendn, string mk)
        {
            if (string.IsNullOrEmpty(tendn) || string.IsNullOrEmpty(mk))
            {
                return  ("Tên đăng nhập hoặc Mật khẩu không được bỏ trống. Xin vui lòng kiển tra lại!");
            }
            else if (tendn.Length > 10 || mk.Length > 10)
            {
                return  ("Tên đăng nhập hoặc Mật khẩu không được vượt quá 10 ký tự. Xin vui lòng kiển tra lại!");
                
            }
            else if (LoadNhanVien(tendn, mk) == null)
            {

                return ("Tên đăng nhập hoặc Mật khẩu không đúng. Xin vui lòng kiển tra lại!");
            }
            else
            {
                return  "Đăng nhập thành công";
            }
        }


        public string TestThemNhanVien (NhanVienBO nv, bool isInsert)
        {
            try
            {
                #region SĐT - Mã nhân viên
                if (isInsert)
                {
                    if (string.IsNullOrEmpty(nv.MaNV))
                    {
                        return  ("Số điện thoại nhân viên không được bỏ trống. Xin vui lòng thử lại!");
                    }

                    if (nv.MaNV.Length > 10)
                    {
                        return  ("Số điện thoại nhân viên không được vượt quá 50 ký tự. Xin vui lòng thử lại!");
                    }

                    tbl_NhanVien objtbl_NhanVien = new tbl_NhanVien();
                    objtbl_NhanVien = CheckNhanVienExists(nv.MaNV);

                    if (objtbl_NhanVien != null)
                    {
                        return  ("Số điện thoại đã được khai báo cho User [" + objtbl_NhanVien.MaNV + " - " + objtbl_NhanVien.TenNV + "]. Xin vui lòng kiểm tra lại");
                    }
                }
                #endregion

                #region Tên nhân viên
                if (string.IsNullOrEmpty(nv.TenNV))
                {
                    return  ("Tên nhân viên không được bỏ trống. Xin vui lòng thử lại!");
                }

                if (nv.TenNV.Length > 50)
                {
                    return ("Tên nhân viên không được vượt quá 50 ký tự. Xin vui lòng thử lại!");
                }
                #endregion

                #region Địa chỉ
                if (!string.IsNullOrEmpty(nv.DiaChi) && nv.DiaChi.Trim().Length > 50)
                {
                    return ("Địa chỉ không được vượt quá 50 ký tự. Xin vui lòng thử lại!");
                }
                #endregion

                #region Ngày sinh
                if (nv.NgaySinh == null)
                {
                    return ("Ngày sinh không được bỏ trống. Xin vui lòng kiểm tra lại!");
                }
                #endregion

                #region Mật khẩu
                if (string.IsNullOrEmpty(nv.MatKhau))
                {
                    return ("Mật khẩu không được bỏ trống. Xin vui lòng thử lại!");
                }

                if (nv.MatKhau.Trim().Length > 10)
                {
                    return ("Mật khẩu không được vượt quá 10 ký tự. Xin vui lòng thử lại!");
                }
                #endregion



                return "Cập nhật dữ liệu cho nhân viên thành công!";
            }
            catch (Exception ex)
            {
                string strMessErr = "Lỗi trong quá trình kiểm tra thông tin cập nhật nhân viên trên UI";
                throw new Exception(strMessErr, ex);
            }
        }
        
        public string TestThemChucVu (string tenCV)
        {
            try
            {
                if (string.IsNullOrEmpty(tenCV))
                    return "Tên chức vụ không được bỏ trống. Xin vui lòng kiểm tra lại!";
                else if (tenCV.Length > 50)
                    return "Tên chức vụ không được vượt quá 50 ký tự. Xin vui lòng kiểm tra lại!";
                else return "Thêm mới chức vụ thành công!";
            }
            catch (Exception ex)
            {
                string strMessErr = "Lỗi trong quá trình kiểm tra thông tin cập nhật nhân viên trên UI";
                throw new Exception(strMessErr, ex);
            }
        }
        #endregion

    }
}
