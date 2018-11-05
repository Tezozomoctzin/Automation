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
    class LoggerIn
    {
        private LoginPage loginPage;

        public LoggerIn()
        {
            loginPage = new LoginPage();
        }

        public LoggerIn SetDriver(IWebDriver driver)
        {
            loginPage.Driver = driver;
            return this;
        }

        public LoggerIn SetElement(IWebElement element)
        {
            loginPage.Element = element;
            return this;
        }

        public LoggerIn CallLoginPage()
        {
            loginPage.CallLoginPage();
            return this;
        }

        public LoggerIn EnterCredentials(string login, string password)
        {
            loginPage.EnterCredentials(login, password);
            return this;
        }

        public LoggerIn SubmitLoginForm()
        {
            loginPage.SubmitLoginForm();
            return this;
        }

        public LoginPage Finalize()
        {
            return loginPage;
        }

    }
}
