using CookieClicker_Regression.CookieHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace CookieClicker_Regression.CookieHooks
{
    [Binding]
    public sealed class CookieHooks
    {
        

        [BeforeScenario]
        public void BeforeScenario()
        {
            BaseClass.LaunchBrowser("Chrome");
            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            BaseClass.CloseBrowser();
        }
    }
}
