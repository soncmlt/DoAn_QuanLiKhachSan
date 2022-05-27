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

        }
    }
}
