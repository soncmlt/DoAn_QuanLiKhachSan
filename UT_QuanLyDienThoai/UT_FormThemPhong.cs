using DAO_BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace UT_QuanLyDienThoai
{
    /// <summary>
    /// Summary description for UT_FormThemPhong
    /// </summary>
    [TestClass]
    public class UT_FormThemPhong
    {
        LoaiPhongDAO LP = new LoaiPhongDAO();
        public UT_FormThemPhong()
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
            filename = "D:\\Works\\UT_QuanLyDienThoai\\TestData\\TD_ThemPhong.xml";
            document.Load(filename);
            element = document.DocumentElement;
            // read  xml
            XmlNodeList li = element.SelectNodes(testCaseName);
            var rs = new string[6];
            foreach (XmlNode item in li)
            {
                rs[0] = item.SelectSingleNode("tenloai").InnerText;
                rs[1] = item.SelectSingleNode("sogiuong").InnerText;
                rs[2] = item.SelectSingleNode("gg").InnerText;
                rs[3] = item.SelectSingleNode("gn").InnerText;
                rs[4] = item.SelectSingleNode("gt").InnerText;
                rs[5] = item.SelectSingleNode("tp").InnerText;
            }
            return rs;
        }

        [TestMethod]
        public void TC_ThemPhong()
        {
            //
            // TODO: Add test logic here
            //

            var listData = GetDataTest("TC_ThemPhong");

            var result = LP.TestThemPhong(listData[0], listData[5], listData[2], listData[3], listData[4], listData[1]);

            var expectedResult = "Thêm loại phòng thành công!";

            Assert.AreEqual(expectedResult, result, "PASS");
        }
        
        [TestMethod]
        public void TC_ThemPhongTrungTenLoai()
        {
            //
            // TODO: Add test logic here
            //

            var listData = GetDataTest("TC_ThemPhongTrungTenLoai");

            var result = LP.TestThemPhong(listData[0], listData[5], listData[2], listData[3], listData[4], listData[1]);

            var expectedResult = "Thêm loại phòng thất bại!";

            Assert.AreEqual(expectedResult, result, "PASS");
        }
        [TestMethod]
        public void TC_ThemPhongTrongTenPhong()
        {
            //
            // TODO: Add test logic here
            //

            var listData = GetDataTest("TC_ThemPhongTrongTenPhong");

            var result = LP.TestThemPhong(listData[0], listData[5], listData[2], listData[3], listData[4], listData[1]);

            var expectedResult = "Dữ liệu thêm mới không được bỏ trống. Xin vui lòng kiểm tra lại!";

            Assert.AreEqual(expectedResult, result, "PASS");
        }
        
        [TestMethod]
        public void TC_ThemPhongTenLoaiHon()
        {
            //
            // TODO: Add test logic here
            //

            var listData = GetDataTest("TC_ThemPhongTenLoaiHon");

            var result = LP.TestThemPhong(listData[0], listData[5], listData[2], listData[3], listData[4], listData[1]);

            var expectedResult = "Tên Loại Phòng vượt quá";

            Assert.AreEqual(expectedResult, result, "PASS");
        }
        [TestMethod]
        public void TC_ThemPhongSoGiuong()
        {
            //
            // TODO: Add test logic here
            //

            var listData = GetDataTest("TC_ThemPhongSoGiuong");

            var result = LP.TestThemPhong(listData[0], listData[5], listData[2], listData[3], listData[4], listData[1]);

            var expectedResult = "Số giường phải là kiểu số nguyên > 0. Xin vui lòng kiểm tra lại!";

            Assert.AreEqual(expectedResult, result, "PASS");
        }
        [TestMethod]
        public void TC_ThemPhongTrongSoGiuong()
        {
            //
            // TODO: Add test logic here
            //

            var listData = GetDataTest("TC_ThemPhongTrongSoGiuong");

            var result = LP.TestThemPhong(listData[0], listData[5], listData[2], listData[3], listData[4], listData[1]);

            var expectedResult = "Dữ liệu thêm mới không được bỏ trống. Xin vui lòng kiểm tra lại!";

            Assert.AreEqual(expectedResult, result, "PASS");
        }
        [TestMethod]
        public void TC_ThemPhongTrongGiaGio()
        {
            //
            // TODO: Add test logic here
            //

            var listData = GetDataTest("TC_ThemPhongTrongGiaGio");

            var result = LP.TestThemPhong(listData[0], listData[5], listData[2], listData[3], listData[4], listData[1]);

            var expectedResult = "Thông tin về giá không được bỏ trống. Xin vui lòng kiểm tra lại!";

            Assert.AreEqual(expectedResult, result, "PASS");
        }
        [TestMethod]
        public void TC_ThemPhongTrongGiaNgay()
        {
            //
            // TODO: Add test logic here
            //

            var listData = GetDataTest("TC_ThemPhongTrongGiaNgay");

            var result = LP.TestThemPhong(listData[0], listData[5], listData[2], listData[3], listData[4], listData[1]);

            var expectedResult = "Thông tin về giá không được bỏ trống. Xin vui lòng kiểm tra lại!";

            Assert.AreEqual(expectedResult, result, "PASS");
        }
        [TestMethod]
        public void TC_ThemPhongTenLoaiKyTuDB()
        {
            //
            // TODO: Add test logic here
            //

            var listData = GetDataTest("TC_ThemPhongTenLoaiKyTuDB");

            var result = LP.TestThemPhong(listData[0], listData[5], listData[2], listData[3], listData[4], listData[1]);

            var expectedResult = "Tên Phòng không được chứa ký tự đặc biệt";

            Assert.AreEqual(expectedResult, result, "PASS");
        }
    }
}
