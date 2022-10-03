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
    public class factoryCookiesPage:BaseClass
    {
        IWebElement clickCookieButton = driver.FindElement(By.Id("click"));
        IWebElement inputCookie = driver.FindElement(By.Id("cookies-to-sell"));
        IWebElement sellCookie = driver.FindElement(By.Id("sell-cookies"));
        IWebElement cookiesNumberr = driver.FindElement(By.Id("cookies"));



        public void clicks()
        {
            for (int i = 0; i < 2; i++)
            {
                clickCookieButton.Click();
                //Thread.Sleep(2000);
            }
        }

        public void inputCookiess()
        {
            inputCookie.SendKeys("1");
        }

        public void clickSellCookies()
        {
            sellCookie.Click();
        }

        public void cookiesNumber()
        {
            Assert.IsTrue(cookiesNumberr.Displayed);
            
        }
    }
}
