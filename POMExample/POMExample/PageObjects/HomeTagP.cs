using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;


namespace OnlineStore.PageObjects
{
    class HomePageTagP
    {
        private IWebDriver driver;

        public HomePageTagP(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public Boolean ClickAndActive()
        {
            IWebElement element= driver.FindElement(By.Id("home"));
            IWebElement parent = element.FindElement(By.XPath(".."));
            driver.FindElement(By.Id("home"));
            System.Threading.Thread.Sleep(1000); //need some sleep due to when clickmethod has been used, website will be temporarily unavailable (ms)
            return TestCases.testcases.elementHasClass(parent, "active");
        }

        public void TagCheck()
        {
            IWebElement divElement = driver.FindElement(By.ClassName("lead")); //used here ClassName due to IF we would have more "P" tag in the source, Would not been unique to identify, it has unique class name btw so better to use that
            String str = divElement.Text;          //make string to store value of "lead" class                          
            Console.Write("\n"+str);               //then write value of str to the Console output
        }
    }
}