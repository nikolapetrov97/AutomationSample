using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Wikipedia
{
    [Binding]
    public class WikiPositive
    {
        private ChromeDriver driver = new ChromeDriver();

        [Given(@"I navigate to google")]
        public void GivenINavigateToGoogle()
        {
            GooglePage google = new GooglePage(driver);
            driver.Navigate().GoToUrl(google.homepage);

        }

        [Given(@"I search for ""(.*)""")]
        public void GivenISearchFor(string p0)
        {
            GooglePage google = new GooglePage(driver);
            google.EnterSearchValue(p0);
            Thread.Sleep(2000);
        }

        [Given(@"I click on the search buttonn")]
        public void GivenIClickOnTheSearchButtonn()
        {
            GooglePage google = new GooglePage(driver);
            google.ClickOnSearchButton();
        }
        
        [Given(@"I select wikipedia site")]
        public void GivenISelectWikipediaSite()
        {
            GooglePage google = new GooglePage(driver);
            google.ClickOnWiki();
        }

        [Given(@"I click on the login")]
        public void GivenIClickOnTheLogin()
        {
            GooglePage google = new GooglePage(driver);
            google.ClickOnLogin();
            Thread.Sleep(3000);
        }

        [When(@"I enter ""(.*)"" acc")]
        public void WhenIEnterAcc(string p0)
        {
            GooglePage google = new GooglePage(driver);
            google.EnterUserName(p0);
        }

        [When(@"I enter ""(.*)"" passwordd")]
        public void WhenIEnterPasswordd(string p0)
        {
            GooglePage google = new GooglePage(driver);
            google.EnterPassword(p0);
        }

        [When(@"I click on the Login button")]
        public void WhenIClickOnTheLoginButton()
        {
            GooglePage google = new GooglePage(driver);
            google.ClickOnLoginButton();
            Thread.Sleep(7000);
        }

        [Then(@"I should see successful login")]
        public void ThenIShouldSeeSuccessfulLogin()
        {
            GooglePage google = new GooglePage(driver);
            Assert.IsTrue(google.IsLogginSuccessful());
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
