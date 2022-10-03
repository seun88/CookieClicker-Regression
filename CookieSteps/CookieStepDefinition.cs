using CookieClicker_Regression.CookieHelper;
using CookieClicker_Regression.CookiePages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace CookieClicker_Regression.CookieSteps
{
    [Binding]
    public sealed class CookieStepDefinition
    {
        private cookieHomePage hp;
        private factoryCookiesPage cp;


        [Given(@"i navigate to CookieClicker website")]
        public void GivenINavigateToCookieClickerWebsite()
        {
            hp = BaseClass.andINavigateToCookieHomePage();
            hp.verifyPageTitle();
            
        }

        [Given(@"input ""(.*)""")]
        public void GivenInput(string names )
        {
            hp.nameInput(names);
        }

        [Given(@"click start")]
        public void GivenClickStart()
        {
            cp = hp.start();
        }

        [Given(@"click cookies button")]
        public void GivenClickCookiesButton()
        {
            cp.clicks();
        }

        [When(@"i click sell cookies button")]
        public void WhenIClickSellCookiesButton()
        {
            cp.inputCookiess();
            cp.clickSellCookies();
        }

        [Then(@"cookies button is functional")]
        public void ThenCookiesButtonIsFunctional()
        {
            cp.cookiesNumber();
        }








    }
}
