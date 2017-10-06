using NUnit.Framework;
using OnlineStore.TestCases;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace OnlineStore.PageObjects
{
    class TitleCheck
    {
        private IWebDriver driver;

        public TitleCheck(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public Boolean Title(String pageName)
        {
            driver.FindElement(By.Id(pageName)).Click();
            System.Threading.Thread.Sleep(500);
            String result = driver.Title;
            Boolean isequal = result.Equals("UI Testing Site");
            Assert.IsTrue(isequal);
            Console.Write(isequal + " for "+ pageName);
            return isequal;
            
        }
    }
}
