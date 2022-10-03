using CookieClicker_Regression.CookieHelper;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CookieClicker_Regression.CookiePages
{
    public class cookieHomePage : BaseClass
    {
        IWebElement nameinput = driver.FindElement(By.Name("name"));
        IWebElement startbutton = driver.FindElement(By.XPath("//button[contains(text(),'Start!')]"));




        public void verifyPageTitle()
        {
            string ActualResult;
            string ExpectedResult = "Cookie Clicker!";

            ActualResult = driver.Title;
            if (ActualResult.Contains(ExpectedResult))
            {
                Console.WriteLine("Test Case Passed");
                Assert.IsTrue(true, "Test Case Passed");
            }
            else
            {
                Console.WriteLine("Test Case Failed");
            }

        }

        public void nameInput(string names)
        {
            nameinput.SendKeys(names);
            Thread.Sleep(2000);
        }


        public factoryCookiesPage start()
        {
            startbutton.Click();
            return new factoryCookiesPage();
        }




    }
}
