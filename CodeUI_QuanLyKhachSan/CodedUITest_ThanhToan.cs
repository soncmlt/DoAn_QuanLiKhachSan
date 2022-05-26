using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
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

        [TestMethod]
        public void CodedUITestMethodThanhToan()
        {
            this.UIMap.RecordedMethodDangNhap1Params.UITxtUserNameEditText = "";
            this.UIMap.RecordedMethodDangNhap1Params.UITxtPassEditSendKeys = "1";

            this.UIMap.RecordedMethodDangNhap1();
            this.UIMap.RecordedMethodThemChucVuParams.UIItemEditText = "";
            this.UIMap.RecordedMethodThemChucVu();

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
