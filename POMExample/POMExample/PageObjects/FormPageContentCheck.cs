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
            driver.FindElement(By.Id("form")).Click(); //click method to form used by FindElement
            System.Threading.Thread.Sleep(1000);//need some sleep due to when click method has been used, website temporarily unavailable (ms)
            IWebElement parent = driver.FindElement(By.Id("form")).FindElement(By.XPath(".."));
            ContentCheck(); //calls ContentCheck method to execute
            return testcases.elementHasClass(parent, "active");    
        }

        public void ContentCheck()
        {
            try
            {
                Boolean parent = driver.FindElement(By.Id("hello-input")).Displayed; // find hello-input id to be displayed or not and give result to variable 
                Console.Write("\nText Input is there"); //if so write following text to the console
            }
            catch (NoSuchElementException) //if not catch that with exception
            { Console.Write("\nText Input is not there"); } //and write following text to the console

            try  //same mechanism at inspection of hello-submit
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