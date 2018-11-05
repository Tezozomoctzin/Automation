using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;

namespace selenium_try
{

    class LoginPage
    {
        private IWebDriver driver;
        private IWebElement element;


        public static LoggerIn CreateLogger()
        {
            return new LoggerIn();
        }
        public IWebDriver Driver
        {
            get { return driver; }
            set { driver = value; }
        }

        public IWebElement Element
        {

            get { return element; }
            set { element = value; }
        }

        public LoginPage()
        {

        }

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public LoginPage(IWebDriver driver, IWebElement element)
        {
            this.driver = driver;
            this.element = element;
        }
        public void CallLoginPage()
        {
            driver.FindElement(By.Id("sign_in")).Click();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.FindElement(By.Id("user_nickname")));
            wait.Until(driver => driver.FindElement(By.Id("user_password")));
        }
        public void EnterCredentials(string login, string password)
        {
            driver.FindElement(By.Id("user_nickname")).SendKeys(login);
            driver.FindElement(By.Id("user_password")).SendKeys(password);
        }
         public void SubmitLoginForm()
        {
            driver.FindElement(By.Id("submit_user")).Click();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.FindElement(By.ClassName("avatar")));
        }

    }
}
