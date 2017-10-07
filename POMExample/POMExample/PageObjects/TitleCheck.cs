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
        public Boolean Title(String pageName) //create method and give it a string variable and its value comes from TestCases Class again
        {
            driver.FindElement(By.Id(pageName)).Click(); //use click method by pageName again
            System.Threading.Thread.Sleep(500);//use some sleep for loading of page properly
            String result = driver.Title;  //get Title of html and give as value of result variable
            Boolean isequal = result.Equals("UI Testing Site"); //use Equals attribute to compare result's value and result will be added for isequal variable
            Assert.IsTrue(isequal); //inspect whether true or not value of isequal after comparing
            Console.Write(isequal + " for "+ pageName); //write to the Console output value of isequal + PageName  
            return isequal; 
            
        }
    }
}
