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
        public Boolean ImageCheck(String pageName) //create method and give it a string variable and its value comes from TestCases Class
        {
            driver.FindElement(By.Id(pageName)).Click(); //use click method by pageName
            System.Threading.Thread.Sleep(500); //use some sleep for loading of images properly
            Boolean result = driver.FindElement(By.Id("dh_logo")).Displayed;  //because logo has ID also, so can be used for identify it and use Displayed attribute as well, this value will be given to result variable
            WriteOnConsolole(result, pageName); //will be written values of result and pageName
            return result;
        }

        public void WriteOnConsolole(Boolean result, String page)
        {
            if (result) //if result is true =
            {
                Console.Write("\nThe logo presented on " + page); //will be written this line plus PageName where was
            }
            else // if result is not true
            {
                Console.Write("\nThe logo is not presented on " + page); //will be written this line plus PageName where was
            }
        }

    }
}
