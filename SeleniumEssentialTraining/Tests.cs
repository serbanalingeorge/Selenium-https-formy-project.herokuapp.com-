using FormyProject.Browser;
using FormyProject.PageObjects;
using FormyProject.pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SeleniumEssentialTraining
{
    [TestClass]
    public class Tests
    {
        private DriverManager _driverManager;
        private IWebDriver _driver;

        [TestMethod]
        public void TestSwitchWindow()
        {
            _driverManager = new FirefoxDriverManager();
            _driver = _driverManager.GetWebDriver();
            var switchWindow = new SwitchWindow(_driver);
            switchWindow.GoTo();
            switchWindow.IsAt();
            switchWindow.OpenNewWindow(1);
            //Thread.Sleep(2000);
            switchWindow.SwitchToFirstWindow();
            //Thread.Sleep(2000);
            _driverManager.QuitWebDriver();
        }

        [TestMethod]
        public void TestRadioButton()
        {
            _driverManager = new FirefoxDriverManager();
            _driver = _driverManager.GetWebDriver();

            var radioButton = new RadioButton(_driver);
            radioButton.GoTo();
            radioButton.IsAt();
            radioButton.ClickButton("1");
            _driverManager.QuitWebDriver();
        }

        [TestMethod]
        public void TestDatePicker()
        {
            _driverManager = new FirefoxDriverManager();
            _driver = _driverManager.GetWebDriver();

            var datePicker = new DatePicker(_driver);
            datePicker.GoTo();
            datePicker.IsAt();
            datePicker.Input("10/10/2010");
            _driverManager.QuitWebDriver();
        }

        [TestMethod]
        public void TestDropDown()
        {
            _driverManager = new FirefoxDriverManager();
            _driver = _driverManager.GetWebDriver();
            var dropDown = new DropDown(_driver);

            dropDown.GoTo();
            dropDown.IsAt();
            dropDown.ClickButton();
            dropDown.Autocomplete();
            dropDown.AssertIsTrue();
            _driverManager.QuitWebDriver();
        }


        [TestMethod]
        public void TestUploadFile()
        {
            _driverManager = new FirefoxDriverManager();
            _driver = _driverManager.GetWebDriver();
            var fileUpload = new FileUpload(_driver);

            fileUpload.GoTo();
            fileUpload.IsAt();
            fileUpload.Perform();

            _driverManager.QuitWebDriver();

        }

        [TestMethod]
        public void TestDragAndDrop()
        {
            _driverManager = new FirefoxDriverManager();
            _driver = _driverManager.GetWebDriver();
            var dragAndDrop = new DragAndDrop(_driver);
            dragAndDrop.GoTo();
            dragAndDrop.IsAt();
            dragAndDrop.DragDrop();
            _driverManager.QuitWebDriver();
        }


        [TestMethod]
        public void TestJavaScriptExecution()
        {
            _driverManager = new FirefoxDriverManager();
            _driver = _driverManager.GetWebDriver();
            var executeJavaScript = new ExecuteJavaScript(_driver);
            executeJavaScript.GoTo();
            executeJavaScript.ClickButton();
            executeJavaScript.MoveToElementForInteraction(executeJavaScript.CloseButton());
            executeJavaScript.IsAt();
            _driverManager.QuitWebDriver();
        }

        [TestMethod]
        public void TestCheckBox()
        {
            _driverManager = new FirefoxDriverManager();
            _driver = _driverManager.GetWebDriver();
            var checkBox = new CheckBox(_driver);

            checkBox.GoTo();
            checkBox.IsAt();
            checkBox.SelectBox1();
            checkBox.SelectBox2();
            checkBox.SelectBox3();
            _driverManager.QuitWebDriver();
        }

        [TestMethod]
        public void TestScrollPageToElement()
        {
            _driverManager = new FirefoxDriverManager();
            _driver = _driverManager.GetWebDriver();
            var pageScroll = new PageScroll(_driver);

            pageScroll.GoTo();
            pageScroll.IsAt();

            pageScroll.MoveToElementForInteraction();
            pageScroll.InputName("random name");
            pageScroll.InputDate("10/10/2010");

            _driverManager.QuitWebDriver();
        }

        [TestMethod]
        public void TestCompleteWebForm()
        {
            _driverManager = new FirefoxDriverManager();
            _driver = _driverManager.GetWebDriver();
            var formPage = new CompleteWebForm(_driver);
            
            formPage.GoTo();
            formPage.SubmitForm("George","Serban","Engineer","05/05/2011");
            formPage.IsAt();
            _driverManager.QuitWebDriver();
        }

        [TestMethod]
        public void TestGoToHomePage()
        {
            _driverManager = new FirefoxDriverManager();
            _driver = _driverManager.GetWebDriver();
            var homePage = new HomePage(_driver);

            homePage.GoTo();
            homePage.IsAt();
            _driverManager.QuitWebDriver();
        }

        [TestMethod]
        public void TestCloseAlert()
        {
            _driverManager = new FirefoxDriverManager();
            _driver = _driverManager.GetWebDriver();
            var alert = new Alert(_driver);

            alert.GoTo();
            alert.IsAt();
            alert.OpenAlert();
            alert.CloseAlert();
            _driverManager.QuitWebDriver();
        }

        [TestMethod]
        public void TestAutocompletePage()
        {
            _driverManager = new FirefoxDriverManager();
            _driver = _driverManager.GetWebDriver();
            var autocomplete = new Autocomplete(_driver);
            autocomplete.CreateImplicitWait(5);
            autocomplete.GoTo();
            autocomplete.IsAt();
            autocomplete.SendAddress("1216 5th Avenue, New York, NY, USA");
            autocomplete.Validate();
            
            _driverManager.QuitWebDriver();
        }

    }
}
