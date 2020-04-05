using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wikipedia
{
    class GooglePage
    {
        public string homepage = "https://www.google.com/";

        private IWebDriver driver;

        readonly By searchField = By.CssSelector(".a4bIc > input[role='combobox']");
        readonly By searchButton = By.CssSelector("li:nth-of-type(1)  div[role='option']  span");
        readonly By WikiResult = By.CssSelector("#rso > div:nth-child(1) > div > div > div.r > a > h3");
        readonly By loginButton = By.CssSelector("#pt-login > a");
        readonly By accField = By.CssSelector("#wpName1");
        readonly By passField = By.CssSelector("#wpPassword1");
        readonly By loginButton1 = By.CssSelector("#wpLoginAttempt");
        readonly By errorMessage = By.CssSelector("#userloginForm > form > div.errorbox");
        readonly By successfulLogin = By.CssSelector("pt-logout");



        public GooglePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterSearchValue(string searchValue)
        {
            driver.FindElement(searchField).Clear();
            driver.FindElement(searchField).SendKeys(searchValue);
        }

        public void ClickOnSearchButton()
        {
            driver.FindElement(searchButton).Click();
        }
        public void ClickOnWiki()
        {
            driver.FindElement(WikiResult).Click();
        }
        public void ClickOnLogin()
        {
            driver.FindElement(loginButton).Click();
        }
        public void ClickOnLoginButton()
        {
            driver.FindElement(loginButton1).Click();
        }
        public void EnterUserName(string userName)
        {
            driver.FindElement(accField).Clear();
            driver.FindElement(accField).SendKeys(userName);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(passField).Clear();
            driver.FindElement(passField).SendKeys(password);
        }
        public bool IsLogginSuccessful()
        {
            return driver.FindElement(successfulLogin).Displayed;
        }
        public bool IsLogginUnsuccessful()
        {
            return driver.FindElement(errorMessage).Displayed;
        }
    }
}
