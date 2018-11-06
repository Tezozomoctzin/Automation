using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;
using System.Configuration;

namespace selenium_try
{

    class LoginPage:PageBase
    {

        private static readonly By UsernameField = By.Id("user_nickname");
        private static readonly By PasswordField = By.Id("user_password");
        private static readonly By SubmitButton = By.Id("submit_user");

        private IWebDriver driver;

        public LoginPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public LoginPage NavigateToLogin()
        {
            string url = CredsConfiguration.LoginUrl;
            this.driver.Navigate().GoToUrl(new Uri(url));
            return this;
        }

        public LoginPage EnterUsername(string login)
        {
            this.driver.FindElement(UsernameField).SendKeys(login);
            return this;
        }

        public LoginPage EnterPassword(string password)
        {
            this.driver.FindElement(PasswordField).SendKeys(password);
            return this;
        }

        public PageBase SubmitLogin()
        {
            this.driver.FindElement(SubmitButton).Click();
            return new PageBase(driver);
        }

    }
}
