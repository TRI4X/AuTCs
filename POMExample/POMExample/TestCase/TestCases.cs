using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OnlineStore.PageObjects;
using System.Collections.Generic;

namespace OnlineStore.TestCases
{

    class testcases
    {
        [Test]
        public void REQ_UI_03_AND_REQ_UI_04_TestHome()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://uitest.duodecadits.com/";

            HomePage homePage = new HomePage(driver);
            Assert.IsTrue(HomePage.ClickAndActive(driver));
            driver.Close();
        }
        [Test]
        public void REQ_UI_05_AND_REQ_UI_06_TestForm()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://uitest.duodecadits.com/";
            
            Assert.IsTrue(FormPage.ClickAndActive(driver));
            driver.Close();
        }

        [Test]
        public void REQ_UI_02_TestPictureOnPages()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://uitest.duodecadits.com/";

            Image image = new Image(driver);
            Assert.IsTrue(image.ImageCheck("home"));
            Assert.IsTrue(image.ImageCheck("form"));
            driver.Close();
        }
        [Test]
        public void REQ_UI_01_TestTitleOnPages()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://uitest.duodecadits.com/";

            TitleCheck title = new TitleCheck(driver);
            Assert.IsTrue(title.Title("home"));
            Assert.IsTrue(title.Title("form"));
            driver.Close();
        }
        [Test]
        public void REQ_UI_08_TestUI()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://uitest.duodecadits.com/";

            UiPage form = new UiPage(driver);
            Assert.IsTrue(form.ClickAndActive());
            driver.Close();
        }
        [Test]
        public void REQ_UI_11_TestFormPageContent()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://uitest.duodecadits.com/";

            FormPageContentCheck form = new FormPageContentCheck(driver);
            Assert.IsTrue(form.ClickAndActive());
            driver.Close();
        }

        [Test]
        public void REQ_UI_12_TestFormPageFillinger()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://uitest.duodecadits.com/";

            Assert.IsTrue(FormPage.ClickAndActive(driver));
            FormPageFill form = new FormPageFill(driver);
            form.FillIn();
            driver.Close();
        }

        [Test]
        public void REQ_UI_09_TestHomePageTagH1()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://uitest.duodecadits.com/";

            HomePageTag form = new HomePageTag(driver);
            Assert.IsTrue(form.ClickAndActive());
            form.TagCheck();
            driver.Close();
        }

        [Test]
        public void REQ_UI_10_TestHomePageTagP()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://uitest.duodecadits.com/";

            HomePageTagP form = new HomePageTagP(driver);
            Assert.IsTrue(form.ClickAndActive());
            form.TagCheck();
            driver.Close();
        }

        [Test]
        public void REQ_UI_07_TestError()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://uitest.duodecadits.com/";

            ErrorPage.ClickAndActive(driver);
            driver.Close();
        }


        public static Boolean elementHasClass(IWebElement element, String active)
        {
            return element.GetAttribute("class").Contains(active);
        }

    }
}