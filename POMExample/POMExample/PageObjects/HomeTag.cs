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
            IWebElement element = driver.FindElement(By.Id("home")); //use FindElement to find home by ID and if found it, use Click method to click on it
            IWebElement parent = element.FindElement(By.XPath("..")); //use FindElement again for home ID and XPath will be step back once in source
            driver.FindElement(By.Id("home"));  //order driver to find home by ID 
            System.Threading.Thread.Sleep(1000); //need some sleep due to when click method has been used, website temporarily unavailable (ms)
            return TestCases.testcases.elementHasClass(parent, "active");
        }

        public void TagCheck()   
        {
            IWebElement divElement = driver.FindElement(By.TagName("h1"));  //order driver to find "h1" by Tagname and put its value of divElement variable
            String str = divElement.Text; // make str string variable and its value will be content of divElement
            Console.Write("\n"+str); //Write value of str to the Console output 
        }
    }
}