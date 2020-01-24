using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace No_Such_Element_Exception_Handle
{

    public static class Explicit

    {

        public static IWebDriver driver;

        public static void Wait (IWebDriver driver, By method)
        {


            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5)); // The default time out limit must be defined
                IWebElement abc = wait.Until(ExpectedConditions.ElementIsVisible(method));

                if (abc.Displayed)

                {
                    System.Console.WriteLine("The element found");

                }

            }

            catch (Exception e) // Insome case I have Nosuchelement Exception but in this case TimeOutException Throws by system,
            // code does not handle that exception , therefore I have set Catch block to handle any exception and its working.

            {
                System.Console.WriteLine("The element not found");

            }

        }




    }
}
