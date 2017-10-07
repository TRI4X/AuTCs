using NUnit.Framework;  //using NUnit framework 
using OpenQA.Selenium; // added Selenium to can be used
using OpenQA.Selenium.Chrome; // using Selenium Chrome webdriver
using System; //In this case necesarry to add to use Assert class
using OnlineStore.PageObjects; //needs to add to be able to use PageObject's classes

namespace OnlineStore.TestCases
{

    class testcases
    {
        [Test] //create Test method
        public void REQ_UI_03_AND_REQ_UI_04_TestHome() // name of method will be TestCase name 
        {

            IWebDriver driver = new ChromeDriver(); //first, calls Chromedriver
            driver.Manage().Window.Maximize(); // windowsize of chrome app will be full screened
            driver.Url = "http://uitest.duodecadits.com/"; //gives url to the browser to load

            Assert.IsTrue(HomePage.ClickAndActive(driver)); //will be inpected whether ClickAndActive of HomePage class gives back ture or false value
            driver.Close(); // Closes browser
        }
        [Test]
        public void REQ_UI_05_AND_REQ_UI_06_TestForm()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://uitest.duodecadits.com/";
            
            Assert.IsTrue(FormPage.ClickAndActive(driver)); //will be inpected whether ClickAndActive of HomePage class gives back true or false value
            driver.Close();
        }

        [Test]
        public void REQ_UI_02_TestPictureOnPages()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://uitest.duodecadits.com/";

            Image image = new Image(driver);  //calls Image class and put that into variable
            Assert.IsTrue(image.ImageCheck("home")); // calls ImageCheck method of Image and will be inpected true or false here and will give it specific value to use inside of Image class
            Assert.IsTrue(image.ImageCheck("form")); // same situation as one line before
            driver.Close();
        }
        [Test]
        public void REQ_UI_01_TestTitleOnPages()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://uitest.duodecadits.com/";

            TitleCheck title = new TitleCheck(driver);
            Assert.IsTrue(title.Title("home"));  //very similiar usage to TestPictureOnPages class
            Assert.IsTrue(title.Title("form"));
            driver.Close();
        }
        [Test]
        public void REQ_UI_08_TestUI()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://uitest.duodecadits.com/";

            UiPage form = new UiPage(driver);  //calls UiPage class and put that into variable
            Assert.IsTrue(form.ClickAndActive()); //calls ClickAndActive of form and will be inpected true or false
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
            form.FillIn();  //calls FillIn method of form
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
            form.TagCheck(); //calls TagCheck method of form
            driver.Close();
        }

        [Test]
        public void REQ_UI_10_TestHomePageTagP() //same usage at TestHomePageTagH1
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

            ErrorPage.ClickAndActive(driver); //calls ClickAndActive method of ErrorPage
            driver.Close();
        }


        public static Boolean elementHasClass(IWebElement element, String active) //create public method; and static which means method is associated with the class
        {
            return element.GetAttribute("class").Contains(active); //returns value where GetAttribute "class" contains active
        }

    }
}