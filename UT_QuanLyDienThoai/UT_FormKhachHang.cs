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
    /// Summary description for UT_KhachHang
    /// </summary>
    [TestClass]
    public class UT_FormKhachHang
    {
        KhachHangDAO KH = new KhachHangDAO(); 
        public UT_FormKhachHang()
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
            filename = "..\\..\\TestData\\TD_KhachHang.xml";
            document.Load(filename);
            element = document.DocumentElement;
            // read  xml
            XmlNodeList li = element.SelectNodes(testCaseName);
            var rs = new string[6];
            foreach (XmlNode item in li)
            {
                rs[0] = item.SelectSingleNode("hoten").InnerText;
                rs[1] = item.SelectSingleNode("cmnd").InnerText;
                rs[2] = item.SelectSingleNode("sdt").InnerText;
                rs[3] = item.SelectSingleNode("gioitinh").InnerText;
                rs[4] = item.SelectSingleNode("ngaysinh").InnerText;
                rs[5] = item.SelectSingleNode("diachi").InnerText;
            }
            return rs;
        }


        /// <summary>
        /// Test Chức năng Thêm Khách Hàng
        /// </summary>
        [TestMethod]
        public void UT_ThemCaseCMNDTonTai()
        {
            //
            // TODO: Add test logic here
            //

            var listData = GetDataTest("UT_ThemCaseCMNDTonTai");
            KhachHangBO kh = new KhachHangBO()
            {
                TenKH = listData[0],
                MaKH = listData[1],
                SDT = listData[2],
                GioiTinh = listData[3],
                NgaySinh = DateTime.Parse(listData[4]),
                DiaChi = listData[5],
            };

            string result = KH.TestFormKhachHang(kh, true);
            string expectedResult = "Mã CMND/CCCD đã được khai báo cho User";

            Assert.AreEqual(expectedResult, result, "PASS");

        }
        
        [TestMethod]
        public void UT_ThemCaseSDTNhoHon()
        {
            //
            // TODO: Add test logic here
            //

            var listData = GetDataTest("UT_ThemCaseSDTNhoHon");
            KhachHangBO kh = new KhachHangBO()
            {
                TenKH = listData[0],
                MaKH = listData[1],
                SDT = listData[2],
                GioiTinh = listData[3],
                NgaySinh = DateTime.Parse(listData[4]),
                DiaChi = listData[5],
            };

            string result = KH.TestFormKhachHang(kh, true);
            string expectedResult = "Số điện thoại không được bỏ trống và không được vượt quá 10 số. Xin vui lòng kiểm tra lại!";

            Assert.AreEqual(expectedResult, result, "PASS");
        }
        
        [TestMethod]
        public void UT_ThemCaseSDTRong()
        {
            //
            // TODO: Add test logic here
            //

            var listData = GetDataTest("UT_ThemCaseSDTRong");
            KhachHangBO kh = new KhachHangBO()
            {
                TenKH = listData[0],
                MaKH = listData[1],
                SDT = listData[2],
                GioiTinh = listData[3],
                NgaySinh = DateTime.Parse(listData[4]),
                DiaChi = listData[5],
            };

            string result = KH.TestFormKhachHang(kh, true);
            string expectedResult = "Số điện thoại không được bỏ trống và không được vượt quá 10 số. Xin vui lòng kiểm tra lại!";

            Assert.AreEqual(expectedResult, result, "PASS");
        }
        
        [TestMethod]
        public void UT_ThemCaseNgaySinhRong()
        {
            //
            // TODO: Add test logic here
            //

            var listData = GetDataTest("UT_ThemCaseNgaySinhRong");
            KhachHangBO kh = new KhachHangBO()
            {
                TenKH = listData[0],
                MaKH = listData[1],
                SDT = listData[2],
                GioiTinh = listData[3],
                NgaySinh = DateTime.Parse(listData[4]),
                DiaChi = listData[5],
            };

            string result = KH.TestFormKhachHang(kh, true);
            string expectedResult = "Ngày sinh không được bỏ trống. Xin vui lòng kiểm tra lại!";

            Assert.AreEqual(expectedResult, result, "PASS");
        }
        [TestMethod]
        public void UT_ThemCaseTenRong()
        {
            //
            // TODO: Add test logic here
            //

            var listData = GetDataTest("UT_ThemCaseTenRong");
            KhachHangBO kh = new KhachHangBO()
            {
                TenKH = listData[0],
                MaKH = listData[1],
                SDT = listData[2],
                GioiTinh = listData[3],
                NgaySinh = DateTime.Parse(listData[4]),
                DiaChi = listData[5],
            };

            string result = KH.TestFormKhachHang(kh, true);
            string expectedResult = "Tên khách hàng không được bỏ trống và không được vượt quá 50 ký tự";

            Assert.AreEqual(expectedResult, result, "PASS");
        }
        [TestMethod]
        public void UT_ThemCaseDiaChiHon50()
        {
            //
            // TODO: Add test logic here
            //

            var listData = GetDataTest("UT_ThemCaseDiaChiHon50");
            KhachHangBO kh = new KhachHangBO()
            {
                TenKH = listData[0],
                MaKH = listData[1],
                SDT = listData[2],
                GioiTinh = listData[3],
                NgaySinh = DateTime.Parse(listData[4]),
                DiaChi = listData[5],
            };

            string result = KH.TestFormKhachHang(kh, true);
            string expectedResult = "Địa chỉ khách hàng không được vượt quá 50 ký tự. Xin vui lòng kiểm tra lại!";

            Assert.AreEqual(expectedResult, result, "PASS");
        }
        [TestMethod]
        public void UT_ThemCaseTenKyTuDB()
        {
            //
            // TODO: Add test logic here
            //

            var listData = GetDataTest("UT_ThemCaseTenKyTuDB");
            KhachHangBO kh = new KhachHangBO()
            {
                TenKH = listData[0],
                MaKH = listData[1],
                SDT = listData[2],
                GioiTinh = listData[3],
                NgaySinh = DateTime.Parse(listData[4]),
                DiaChi = listData[5],
            };

            string result = KH.TestFormKhachHang(kh, true);
            string expectedResult = "Họ tên khách hàng không hợp lệ";

            Assert.AreEqual(expectedResult, result, "FAILED");
        }
        [TestMethod]
        public void UT_ThemCasePass()
        {
            //
            // TODO: Add test logic here
            //

            var listData = GetDataTest("UT_ThemCasePass");
            KhachHangBO kh = new KhachHangBO()
            {
                TenKH = listData[0],
                MaKH = listData[1],
                SDT = listData[2],
                GioiTinh = listData[3],
                NgaySinh = DateTime.Parse(listData[4]),
                DiaChi = listData[5],
            };

            string result = KH.TestFormKhachHang(kh, true);
            string expectedResult = "Cập nhật dữ liệu khách hàng thành công!";

            Assert.AreEqual(expectedResult, result, "FAILED");
        }
        [TestMethod]
        public void UT_ThemCaseNgaySinhKhongHople()
        {
            //
            // TODO: Add test logic here
            //

            var listData = GetDataTest("UT_ThemCaseNgaySinhKhongHople");
            KhachHangBO kh = new KhachHangBO()
            {
                TenKH = listData[0],
                MaKH = listData[1],
                SDT = listData[2],
                GioiTinh = listData[3],
                NgaySinh = DateTime.Parse(listData[4]),
                DiaChi = listData[5],
            };

            string result = KH.TestFormKhachHang(kh, true);
            string expectedResult = "Ngày sinh không hợp lệ";

            Assert.AreEqual(expectedResult, result, "FAILED");
        }
        [TestMethod]
        public void UT_ThemCaseCMNDKhongHople()
        {
            //
            // TODO: Add test logic here
            //

            var listData = GetDataTest("UT_ThemCaseCMNDKhongHople");
            KhachHangBO kh = new KhachHangBO()
            {
                TenKH = listData[0],
                MaKH = listData[1],
                SDT = listData[2],
                GioiTinh = listData[3],
                NgaySinh = DateTime.Parse(listData[4]),
                DiaChi = listData[5],
            };

            string result = KH.TestFormKhachHang(kh, true);
            string expectedResult = "Số CMND không hợp lệ";

            Assert.AreEqual(expectedResult, result, "FAILED");
        }
        [TestMethod]
        public void UT_SuaCaseDTHople1()
        {
            //
            // TODO: Add test logic here
            //

            var listData = GetDataTest("UT_SuaCaseDTHople1");
            KhachHangBO kh = new KhachHangBO()
            {
                TenKH = listData[0],
                MaKH = listData[1],
                SDT = listData[2],
                GioiTinh = listData[3],
                NgaySinh = DateTime.Parse(listData[4]),
                DiaChi = listData[5],
            };

            string result = KH.TestFormKhachHang(kh, true);
            string expectedResult = "Số điện thoại không được bỏ trống và không được vượt quá 10 số. Xin vui lòng kiểm tra lại!";

            Assert.AreEqual(expectedResult, result, "PASS");
        }
    }
}
