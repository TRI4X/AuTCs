using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using OnlineStore.TestCases;
using NUnit.Framework;

namespace OnlineStore.PageObjects
{
    class ErrorPage
    {
        public static Boolean ClickAndActive(IWebDriver driver)
        {
            driver.FindElement(By.Id("error")).Click();
            System.Threading.Thread.Sleep(1000);//need some sleep due to when click method has been used, website temporarliy unavailable (ms)
            IWebElement parent = driver.FindElement(By.TagName("h1"));
            String str = parent.Text;

            Assert.IsTrue(str.Equals("404 Error: File not found :-("));    //expect(TRUE) to be that specific value. if it will be not same value, that will mean this is not error page and TC will be failed.
            return testcases.elementHasClass(parent, "");
        }

    }
}