using BO;
using DAO_BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace UT_QuanLyDienThoai
{
    /// <summary>
    /// Summary description for UT_NhanVien
    /// </summary>
    [TestClass]
    public class UT_FormNhanVien
    {
        NhanVienDAO NV = new NhanVienDAO();
        public UT_FormNhanVien()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        public string[] GetDataTest(string testCaseName)
        {
            XmlDocument document;
            XmlElement element;
            string filename;
            document = new XmlDocument();
            filename = "..\\..\\TestData\\TD_NhanVien.xml";
            document.Load(filename);
            element = document.DocumentElement;
            // read  xml
            XmlNodeList li = element.SelectNodes(testCaseName);
            var rs = new string[7];
            foreach (XmlNode item in li)
            {
                rs[0] = item.SelectSingleNode("sdt").InnerText;
                rs[1] = item.SelectSingleNode("hoten").InnerText;
                rs[2] = item.SelectSingleNode("chucvu").InnerText;
                rs[3] = item.SelectSingleNode("ngaysinh").InnerText;
                rs[4] = item.SelectSingleNode("gioitinh").InnerText;
                rs[5] = item.SelectSingleNode("diachi").InnerText;
                rs[6] = item.SelectSingleNode("matkhau").InnerText;
            }
            return rs;
        }

        [TestMethod]
        public void TC_NhanVienSDTNho()
        {
            //
            // TODO: Add test logic here
            //

            var listData = GetDataTest("TC_NhanVienSDTNho");
            NhanVienBO nv = new NhanVienBO()
            {
                TenNV = listData[1],
                MatKhau = listData[6],
                MaNV = listData[0],
                GioiTinh = listData[4],
                NgaySinh = DateTime.Parse(listData[3]),
                DiaChi = listData[5],
                MaLoaiNV = int.Parse(listData[2])
            };

            string result = NV.TestThemNhanVien(nv, true);
            string expectedResult = "Cập nhật dữ liệu cho nhân viên thành công!";

            Assert.AreEqual(expectedResult, result, "FAILED");
        }
        
        [TestMethod]
        public void TC_NhanVienSDTRong()
        {
            //
            // TODO: Add test logic here
            //

            var listData = GetDataTest("TC_NhanVienSDTRong");
            NhanVienBO nv = new NhanVienBO()
            {
                TenNV = listData[1],
                MatKhau = listData[6],
                MaNV = listData[0],
                GioiTinh = listData[4],
                NgaySinh = DateTime.Parse(listData[3]),
                DiaChi = listData[5],
                MaLoaiNV = int.Parse(listData[2])
            };

            string result = NV.TestThemNhanVien(nv, true);
            string expectedResult = "Số điện thoại nhân viên không được bỏ trống. Xin vui lòng thử lại!";

            Assert.AreEqual(expectedResult, result, "PASS");
        }
        [TestMethod]
        public void TC_NhanVienSDTKyTuDB()
        {
            //
            // TODO: Add test logic here
            //

            var listData = GetDataTest("TC_NhanVienSDTKyTuDB");
            NhanVienBO nv = new NhanVienBO()
            {
                TenNV = listData[1],
                MatKhau = listData[6],
                MaNV = listData[0],
                GioiTinh = listData[4],
                NgaySinh = DateTime.Parse(listData[3]),
                DiaChi = listData[5],
                MaLoaiNV = int.Parse(listData[2])
            };

            string result = NV.TestThemNhanVien(nv, true);
            string expectedResult = "Số điện thoại không hợp lệ";

            Assert.AreEqual(expectedResult, result, "FAILED");
        }
        [TestMethod]
        public void TC_NhanVienSDTLon()
        {
            //
            // TODO: Add test logic here
            //

            var listData = GetDataTest("TC_NhanVienSDTLon");
            NhanVienBO nv = new NhanVienBO()
            {
                TenNV = listData[1],
                MatKhau = listData[6],
                MaNV = listData[0],
                GioiTinh = listData[4],
                NgaySinh = DateTime.Parse(listData[3]),
                DiaChi = listData[5],
                MaLoaiNV = int.Parse(listData[2])
            };

            string result = NV.TestThemNhanVien(nv, true);
            string expectedResult = "Số điện thoại nhân viên không được vượt quá 10 ký tự. Xin vui lòng thử lại!";

            Assert.AreEqual(expectedResult, result, "FAILED");
        }
        [TestMethod]
        public void TC_NhanVienTenKyTuDB()
        {
            //
            // TODO: Add test logic here
            //

            var listData = GetDataTest("TC_NhanVienTenKyTuDB");
            NhanVienBO nv = new NhanVienBO()
            {
                TenNV = listData[1],
                MatKhau = listData[6],
                MaNV = listData[0],
                GioiTinh = listData[4],
                NgaySinh = DateTime.Parse(listData[3]),
                DiaChi = listData[5],
                MaLoaiNV = int.Parse(listData[2])
            };

            string result = NV.TestThemNhanVien(nv, true);
            string expectedResult = "Tên nhân viên không hợp lệ";

            Assert.AreEqual(expectedResult, result, "FAILED");
        }
        //[TestMethod]
        //public void TC_ChucVuRong()
        //{
        //    //
        //    // TODO: Add test logic here
        //    //

        //    var listData = GetDataTest("TC_ChucVuRong");
        //    NhanVienBO nv = new NhanVienBO()
        //    {
        //        TenNV = listData[1],
        //        MatKhau = listData[6],
        //        MaNV = listData[0],
        //        GioiTinh = listData[4],
        //        NgaySinh = DateTime.Parse(listData[3]),
        //        DiaChi = listData[5],
        //        MaLoaiNV = int.Parse(listData[2])
        //    };

        //    string result = NV.TestThemNhanVien(nv, true);
        //    string expectedResult = "Tên nhân viên không hợp lệ";

        //    Assert.AreEqual(expectedResult, result, "FAILED");
        //}
    }
}
