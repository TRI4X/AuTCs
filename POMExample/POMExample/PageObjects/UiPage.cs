using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using OnlineStore.TestCases;

namespace OnlineStore.PageObjects
{
    class UiPage
    {
        private IWebDriver driver;

        public UiPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public Boolean ClickAndActive()
        {
            driver.FindElement(By.Id("site")).Click(); //click method to
            System.Threading.Thread.Sleep(1000);  //need some sleep due to when click method has been used, website temporarily unavailable (ms)

            IWebElement parent = driver.FindElement(By.Id("home")).FindElement(By.XPath("..")); //check home is active, if so
            Boolean result = testcases.elementHasClass(parent, "active");
            WriteOnConsole(result);
            return result;                                 //will be write to the console it is or not
            
        }
        public void WriteOnConsole(Boolean parent)   
        {
            if (parent)
            {
                Console.Write("\nThis is home page");
            }
            else
            {
                Console.Write("\nThis is not home page");
            }
        }

    }

}
