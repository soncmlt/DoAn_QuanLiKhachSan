using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml; 
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace CodeUI_QuanLyKhachSan
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest_ThanhToan
    {
        public CodedUITest_ThanhToan()
        {
        }

        public List<string> GetDataTest()
        {
            XmlDataDocument doc = new XmlDataDocument();
            doc.Load("D:\\Works\\CodeUI_QuanLyKhachSan\\TD_DangNhap.xml");

            XmlNodeList elements = doc.GetElementsByTagName("TC_KiemTraDangNhap");
            List<string> rs = new List<string>();
            foreach (XmlNode node in elements)
            {
                var line = node.SelectSingleNode("tendn").InnerText + "-" + node.SelectSingleNode("matkhau").InnerText;
                rs.Add(line);
            }
            
            return rs;
        }

        [TestMethod]
        public void CodedUITestMethodDangNhap()
        {
            try
            {
                var listData = GetDataTest();
                foreach (var data in listData)
                {
                    string ten = data.Split('-')[0];
                    string mk = data.Split('-')[1];
                    this.UIMap.RecordedMethodDangNhap1Params.UITxtUserNameEditText = ten;
                    this.UIMap.RecordedMethodDangNhap1Params.UITxtPassEditSendKeys = "LhN8aH3/sMZ8FDsaa2gg68CE0hC30afa";

                    this.UIMap.RecordedMethodDangNhap1();
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
            //this.UIMap.RecordedMethodThemChucVuParams.UIItemEditText = "";
            //this.UIMap.RecordedMethodThemChucVu();

            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        }


        [TestMethod]
        public void CodedUITestMethodDangNhap1()
        {
            this.UIMap.RecordedMethodDangNhap1();

            //this.UIMap.RecordedMethodThemChucVuParams.UIItemEditText = "";
            //this.UIMap.RecordedMethodThemChucVu();

            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        }

        [TestMethod]
        public void CodedUITestMethodThemChucVu()
        {

            this.UIMap.RecordedMethodThemChucVu1();
            //this.UIMap.RecordedMethodThemChucVu();


            //this.UIMap.RecordedMethodThemChucVuParams.UIItemEditText = "";
            //this.UIMap.RecordedMethodThemChucVu();


            //this.UIMap.RecordedMethodThemChucVuParams.UIItemEditText = "55%%%%!";
            //this.UIMap.RecordedMethodThemChucVu();


            //this.UIMap.RecordedMethodThemChucVuParams.UIItemEditText = "Nhân Viênnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn";
            //this.UIMap.RecordedMethodThemChucVu();

            //this.UIMap.RecordedMethodThemChucVuParams.UIItemEditText = "";
            //this.UIMap.RecordedMethodThemChucVu();

            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\TD_DangNhap.xml", "TC_KiemTraDangNhap", DataAccessMethod.Sequential)]
        public void CodedUITestMethodThem1Phim2()
        {
            this.UIMap.RecordedMethodDangNhap1Params.UITxtUserNameEditText = this.TestContext.DataRow["tendn"].ToString();
            this.UIMap.RecordedMethodDangNhap1Params.UITxtPassEditSendKeys = this.TestContext.DataRow["matkhau"].ToString();

            this.UIMap.RecordedMethodDangNhap1();
        }
        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        #endregion

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
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
