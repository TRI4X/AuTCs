using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace OnlineStore.PageObjects
{
    class Image
    {
        private IWebDriver driver;

        public Image(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public Boolean ImageCheck(String pageName)
        {
            driver.FindElement(By.Id(pageName)).Click();
            System.Threading.Thread.Sleep(500);
            Boolean result = driver.FindElement(By.Id("dh_logo")).Displayed;
            WriteOnConsolole(result, pageName);
            return result;
        }

        public void WriteOnConsolole(Boolean result, String page)
        {
            if (result)
            {
                Console.Write("\nThe logo presented on " + page);
            }
            else
            {
                Console.Write("\nThe logo is not presented on " + page);
            }
        }

    }
}
