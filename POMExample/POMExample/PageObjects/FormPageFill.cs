using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using OnlineStore.TestCases;
using System.Collections.Generic;

namespace OnlineStore.PageObjects
{ 

  
    class FormPageFill
    {      
        private IWebDriver driver;

            [FindsBy(How = How.Id, Using = "hello-input")]
            //[CacheLookup]
            public IWebElement TextInput { get; set; }

            [FindsBy(How = How.Id, Using = "hello-submit")]
            //[CacheLookup]
            public IWebElement Submit { get; set; }

        public FormPageFill(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void FillIn()
        {
            List<String> list = new List<String>();
            list.Add("John");
            list.Add("Sophia");
            list.Add("Charlie");
            list.Add("Emily");
            foreach (String name in list)
            {
                TextInput.Clear();
                TextInput.SendKeys(name);
                Submit.Submit();
                System.Threading.Thread.Sleep(500);//need some sleep due to when click method has been used, website temporarliy unavailable (ms)
                driver.Navigate().Back();
                System.Threading.Thread.Sleep(1000);//need some sleep due to when click method has been used, website temporarliy unavailable (ms)
            }
        }      
    
    }
}