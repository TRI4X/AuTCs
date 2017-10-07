
using OpenQA.Selenium;  // added Selenium to can be used
using OpenQA.Selenium.Support.PageObjects;// needs to be added to PageFactory will be used in code 
using System; //In this case necesarry to add to use sleep
using OnlineStore.TestCases; //will be return value and need access to the Testcase's class 

namespace OnlineStore.PageObjects
{
    class HomePage
    {
        private IWebDriver driver;    //calls webdriver and names it driver

        public HomePage(IWebDriver driver) //calls webdriver into 
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this); // Needs to allow PageObjects to exists and PageObjects are classes that contains WebElements 
        }

        public static Boolean ClickAndActive(IWebDriver driver) //create public method; and static which means method is associated with the class 
        {
            driver.FindElement(By.Id("home")).Click(); //use FindElement to find home by ID and if found it, use Click method to click on it
            System.Threading.Thread.Sleep(1000);//need some sleep due to when click method has been used, website temporarily unavailable (ms)
            IWebElement parent = driver.FindElement(By.Id("home")).FindElement(By.XPath("..")); //use FindElement again for home ID and XPath will be step back once in source
            return testcases.elementHasClass(parent, "active"); //return value of parent to the elementHasClass
        }     
       
    }
}