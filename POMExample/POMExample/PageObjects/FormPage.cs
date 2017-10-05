using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using OnlineStore.TestCases;

namespace OnlineStore.PageObjects
{
    class FormPage
    {
        public static Boolean ClickAndActive(IWebDriver driver)
        {
            driver.FindElement(By.Id("form")).Click();
            System.Threading.Thread.Sleep(1000);//need some sleep due to when click method has been used, website temporarliy unavailable (ms)
            IWebElement parent = driver.FindElement(By.Id("form")).FindElement(By.XPath(".."));
            return testcases.elementHasClass(parent, "active");
        }

    }
}