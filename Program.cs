using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Configuration;


namespace selenium_try
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IWebDriver webDriver = new FirefoxDriver();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IWebElement element;
            /*webDriver.Navigate().GoToUrl("http://www.google.com");
            IWebElement element = webDriver.FindElement(By.Name("q"));
            element.SendKeys("shikimori");
            element.Submit();

            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(15));
            wait.Until(d => d.Title.StartsWith("shikimori", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Page title is: " + webDriver.Title);

            webDriver.FindElement(By.CssSelector("[href*='https://shikimori.org/']")).Click();
            wait.Until(d => d.FindElement(By.CssSelector("[class='entry userbox']")).Displayed);*/

            var page = new LoginPage(webDriver)
                    .NavigateToLogin()
                    .EnterUsername(CredsConfiguration.Login)
                    .EnterPassword(CredsConfiguration.Password)
                    .SubmitLogin();

            //wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(3));
            //wait.Until(d => d.FindElement(By.ClassName("cc-second")));
            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(15));
            wait.Until(driv => driv.FindElement(By.ClassName("avatar")));
            element = webDriver.FindElement(By.ClassName("ac_input"));
            element.SendKeys("Naruto Shippuuden");
            element.SendKeys(Keys.Enter);

            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until(driv => driv.FindElement(By.ClassName("b-collection_search")));
            IList < IWebElement > elements = webDriver.FindElements(By.ClassName("name-ru"));

            string contentList = "";
            Console.WriteLine("Длина списка: " + elements.Count);
            contentList += "Длина списка: " + elements.Count;
            Console.WriteLine("Список Аниме");
            foreach (IWebElement listElement in elements)
             {
                Console.WriteLine(listElement.GetAttribute("data-text"));
             }
             Console.WriteLine("Конец списка");
             webDriver.FindElement(By.CssSelector("[href*='https://shikimori.org/animes/1735-naruto-shippuuden']")).Click();
             webDriver.FindElement(By.XPath("//span[@data-text='Наруто: Ураганные хроники']/ancestor::a[@class='cover']")).Click();

             IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
             string script = "alert('" + contentList + "')";
             js.ExecuteScript(script);
             Console.ReadKey();
             webDriver.Close();
            
        }
    }
}
