﻿using CookieClicker_Regression.CookiePages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace CookieClicker_Regression.CookieHelper
{
    public class BaseClass
    {
        public static IWebDriver driver { get; set; }




        static BaseClass()
        {
            driver = null;

        }




        public static void LaunchBrowser(String browser)
        {


            switch (browser)
            {
                case "Chrome":
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;
                case "Firefox":
                    new DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;
                case "InternetExplorer":
                    new DriverManager().SetUpDriver(new InternetExplorerConfig());
                    driver = new InternetExplorerDriver();
                    break;

                default:
                    Console.WriteLine(browser + " is not recognised. So Firefox is launched instead");
                    driver = new FirefoxDriver();
                    break;
            }

            driver.Manage().Window.Maximize();
        }

        private static IWebDriver initialiseChrome()
        {
            driver = new ChromeDriver();

            return driver;
        }

        private static IWebDriver initialiseFirefox()
        {
            driver = new FirefoxDriver();

            return driver;
        }

        private static IWebDriver initialiseInternetExplorer()
        {
            driver = new InternetExplorerDriver();

            return driver;
        }

        public static void CloseBrowser()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Close();
            driver.Quit();
        }

        public static void LaunchUrl(String Url)
        {
            driver.Navigate().GoToUrl(Url);
        }


        public static cookieHomePage andINavigateToCookieHomePage()
        {
            LaunchUrl("https://seun-akinbode-2022-09-29.cookieclickertechtest.airelogic.com/");
            return new cookieHomePage();
        }

    }

}
