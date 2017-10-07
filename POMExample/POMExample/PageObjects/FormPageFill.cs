using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;

namespace OnlineStore.PageObjects
{ 

  
    class FormPageFill
    {      
        private IWebDriver driver;

            [FindsBy(How = How.Id, Using = "hello-input")]    //using FindsBy attribute of PageFactory for the ID of hello-input
          public IWebElement TextInput { get; set; }  //get and set value for TextInput variable

        [FindsBy(How = How.Id, Using = "hello-submit")] //same situation at hello-input
            public IWebElement Submit { get; set; }

        public FormPageFill(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void FillIn()
        {
            List<String> list = new List<String>();  //create a List with strings 
            list.Add("John");  //add element of List
            list.Add("Sophia");
            list.Add("Charlie");
            list.Add("Emily");
            foreach (String name in list)  //create foreach to put all element of list for TextInput
            {
                TextInput.Clear();  //first clear content of TextInput
                TextInput.SendKeys(name);  //second send a value of list for TextInput
                Submit.Submit(); //submit of hello-submit
                System.Threading.Thread.Sleep(500);//need some sleep due to when click method has been used, website temporarily unavailable (ms)
                driver.Navigate().Back(); //make an order for driver to step back by one page on the browser’s history.
                System.Threading.Thread.Sleep(1000);//need some sleep due to when click method has been used, website temporarily unavailable (ms)
            }
        }      
    
    }
}