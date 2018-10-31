using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace TestCase1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.blinds.com");
            driver.Manage().Window.Maximize();

            IWebElement elementsearchbox = driver.FindElement(By.Id("gcc-typeahead-input"));
            IWebElement elementsearchbutton = driver.FindElement(By.Id("gcc-typeahead-submit"));

            //Populate search key
            elementsearchbox.SendKeys("Room Darkening Blinds");

            //Click search button
            driver.FindElement(By.Id("gcc-typeahead-submit")).Click();       

            //Search results are displayed now
            // Find and click appropriate hyperlink to sort by Price Low-To High
            driver.FindElement(By.LinkText("Price Low-High")).Click();
        }
    }
}
