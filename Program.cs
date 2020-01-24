using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace No_Such_Element_Exception_Handle
{
   
    class Entrypoint
    {
        static void Main()
        {

            IWebDriver driver = new ChromeDriver("./");
            driver.Navigate().GoToUrl("https://demo.nopcommerce.com/");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            Thread.Sleep(5000);

            IWebElement Reglink = driver.FindElement(By.ClassName("ico-register"));
            Reglink.Click();

            Explicit.Wait(driver, (By.Id("Email"))); // Calling Centralise method of Other Class  It pass the driver and relevant find element method as parameter.           
            driver.Close();
            driver.Quit();
        }
    }
}

//References
// https://stackoverflow.com/questions/6992993/selenium-c-sharp-webdriver-wait-until-element-is-present
//https://sqa.stackexchange.com/questions/15327/explicit-wait-is-not-reliable-with-selenium-c