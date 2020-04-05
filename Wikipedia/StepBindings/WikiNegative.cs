using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Wikipedia
{
    [Binding]
    public class WikiNegative
    {
        private ChromeDriver driver = new ChromeDriver();

        [Given(@"I navigate to googlee")]
        public void GivenINavigateToGooglee()
        {
            GooglePage google = new GooglePage(driver);
            driver.Navigate().GoToUrl(google.homepage);
        }

        [Given(@"I search ""(.*)""")]
        public void GivenISearch(string p0)
        {
            GooglePage google = new GooglePage(driver);
            google.EnterSearchValue(p0);
            Thread.Sleep(2000);
        }
        [Given(@"I click on the search button")]
        public void GivenIClickOnTheSearchButton()
        {
            GooglePage google = new GooglePage(driver);
            google.ClickOnSearchButton();
        }

        [Given(@"I select wiki site")]
        public void GivenISelectWikiSite()
        {
            GooglePage google = new GooglePage(driver);
            google.ClickOnWiki();
        }

        [Given(@"I click on the login buttonn")]
        public void GivenIClickOnTheLoginButtonn()
        {
            GooglePage google = new GooglePage(driver);
            google.ClickOnLogin();
            Thread.Sleep(3000);
        }

        [When(@"I enter name ""(.*)""")]
        public void WhenIEnterName(string p0)
        {
            GooglePage google = new GooglePage(driver);
            google.EnterUserName(p0);
        }

        [When(@"I enter password ""(.*)""")]
        public void WhenIEnterPassword(string p0)
        {
            GooglePage google = new GooglePage(driver);
            google.EnterPassword(p0);
        }

        [When(@"I click on the Login")]
        public void WhenIClickOnTheLogin()
        {
            GooglePage google = new GooglePage(driver);
            google.ClickOnLoginButton();
            Thread.Sleep(7000);
        }


        [Then(@"I should see unsuccessful login")]
        public void ThenIShouldSeeUnsuccessfulLogin()
        {
            GooglePage google = new GooglePage(driver);
            Assert.IsTrue(google.IsLogginUnsuccessful());
        }
        public void Dispose()
        {
            if (driver != null)
            {
                driver.Dispose();
                driver = null;
            }
        }
    }
}
