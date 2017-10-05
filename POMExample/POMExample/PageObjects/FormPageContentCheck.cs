using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using OnlineStore.TestCases;


namespace OnlineStore.PageObjects
{
    class FormPageContentCheck
    {
        private IWebDriver driver;

        public FormPageContentCheck(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public Boolean ClickAndActive()
        {
            driver.FindElement(By.Id("form")).Click();
            System.Threading.Thread.Sleep(1000);//need some sleep due to when click method has been used, website temporarliy unavailable (ms)
            IWebElement parent = driver.FindElement(By.Id("form")).FindElement(By.XPath(".."));
            ContentCheck();
            return testcases.elementHasClass(parent, "active");    
        }

        public void ContentCheck()
        {
            try
            {
                Boolean parent = driver.FindElement(By.Id("hello-input")).Displayed;
                Console.Write("\nText Input is there");
            }
            catch (NoSuchElementException)
            { Console.Write("\nText Input is not there"); }

            try
            {
                Boolean parent1 = driver.FindElement(By.Id("hello-submit")).Displayed;
                Console.Write("\nSubmit button is there");
            }
            catch (NoSuchElementException)
            {
                Console.Write("\nSubmit button is not there");
            }
            
        }

    }
}