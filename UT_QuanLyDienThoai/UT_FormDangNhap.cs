using DAO_BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace UT_QuanLyDienThoai
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UT_FormDangNhap
    {
        NhanVienDAO NV = new NhanVienDAO();
        public UT_FormDangNhap()
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
            filename = "D:\\Works\\UT_QuanLyDienThoai\\TestData\\TD_DangNhap.xml";
            document.Load(filename);
            element = document.DocumentElement;
            // read  xml
            XmlNodeList li = element.SelectNodes(testCaseName);
            var rs = new string[2];
            foreach (XmlNode item in li)
            {
                rs[0] = item.SelectSingleNode("tendn").InnerText;
                rs[1] = item.SelectSingleNode("matkhau").InnerText;
            }
            return rs;
        }

        [TestMethod]
        public void TC_KiemTraDangNhapHopLe()
        {
            //
            // TODO: Add test logic here
            //
            var lstData = GetDataTest("TC_KiemTraDangNhapHopLe");
            var tdn = lstData[0];
            var mk = lstData[1];

            string result = NV.TestDangNhap(tdn, mk);
            string expectedResult = "Đăng nhập thành công";

            Assert.AreEqual(expectedResult, result, "PASS");
        }
        
        [TestMethod]
        public void TC_KiemTraDangNhapKhongTonTai()
        {
            //
            // TODO: Add test logic here
            //
            var lstData = GetDataTest("TC_KiemTraDangNhapKhongTonTai");
            var tdn = lstData[0];
            var mk = lstData[1];

            string result = NV.TestDangNhap(tdn, mk);
            string expectedResult = "Tên đăng nhập hoặc Mật khẩu không đúng. Xin vui lòng kiển tra lại!";

            Assert.AreEqual(expectedResult, result, "PASS");
        }
        
        [TestMethod]
        public void TC_KiemTraDangNhapSaiMatKhau()
        {
            //
            // TODO: Add test logic here
            //
            var lstData = GetDataTest("TC_KiemTraDangNhapSaiMatKhau");
            var tdn = lstData[0];
            var mk = lstData[1];

            string result = NV.TestDangNhap(tdn, mk);
            string expectedResult = "Tên đăng nhập hoặc Mật khẩu không đúng. Xin vui lòng kiển tra lại!";

            Assert.AreEqual(expectedResult, result, "PASS");
        }
        [TestMethod]
        public void TC_KiemTraDangKhongHopLe()
        {
            //
            // TODO: Add test logic here
            //
            var lstData = GetDataTest("TC_KiemTraDangKhongHopLe");
            var tdn = lstData[0];
            var mk = lstData[1];

            string result = NV.TestDangNhap(tdn, mk);
            string expectedResult = "Tên đăng nhập hoặc Mật khẩu không được vượt quá 10 ký tự. Xin vui lòng kiển tra lại!";

            Assert.AreEqual(expectedResult, result, "PASS");
        }
        
        [TestMethod]
        public void TC_KiemTraChuaKyTuDacBiet()
        {
            //
            // TODO: Add test logic here
            //
            var lstData = GetDataTest("TC_KiemTraChuaKyTuDacBiet");
            var tdn = lstData[0];
            var mk = lstData[1];

            string result = NV.TestDangNhap(tdn, mk);
            string expectedResult = "Tên đăng nhập hoặc Mật khẩu không được chứa ký tự đặc biệt. Xin vui lòng kiển tra lại!";

            Assert.AreEqual(expectedResult, result, "FAILED");
        }
        [TestMethod]
        public void TC_KiemTraNhapRong()
        {
            //
            // TODO: Add test logic here
            //
            var lstData = GetDataTest("TC_KiemTraNhapRong");
            var tdn = lstData[0];
            var mk = lstData[1];

            string result = NV.TestDangNhap(tdn, mk);
            string expectedResult = "Tên đăng nhập hoặc Mật khẩu không được bỏ trống. Xin vui lòng kiển tra lại!";

            Assert.AreEqual(expectedResult, result, "PASS");
        }
    }
}
