using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;


namespace OnlineStore.PageObjects
{
    class HomePageTag
    {
        private IWebDriver driver;

        public HomePageTag(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public Boolean ClickAndActive()
        {
            IWebElement element = driver.FindElement(By.Id("home"));
            IWebElement parent = element.FindElement(By.XPath(".."));
            driver.FindElement(By.Id("home"));
            System.Threading.Thread.Sleep(1000); //need some sleep due to when click method has been used, website temporarily unavailable (ms)
            return TestCases.testcases.elementHasClass(parent, "active");
        }

        public void TagCheck()
        {
            IWebElement divElement = driver.FindElement(By.TagName("h1"));
            String str = divElement.Text;
            Console.Write("\n"+str);
        }
    }
}