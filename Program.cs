using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;


namespace selenium_try
{
    class Program
    {
        static void Main(string[] args)
        {
            using (IWebDriver webDriver = new FirefoxDriver())
            {
                
                webDriver.Navigate().GoToUrl("http://www.google.com");
                IWebElement element = webDriver.FindElement(By.Name("q"));
                element.SendKeys("shikimori");
                element.Submit();

                var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(15));
                wait.Until(d => d.Title.StartsWith("shikimori", StringComparison.OrdinalIgnoreCase));

                Console.WriteLine("Page title is: " + webDriver.Title);
                webDriver.FindElement(By.CssSelector("[href*='https://shikimori.org/']")).Click();
                wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));              
                wait.Until(d => d.FindElement(By.CssSelector("[href*='https://shikimori.org/users/sign_in']")));
                /*loginPage.Driver = webDriver;
                loginPage.Element = element;
                loginPage.CallLoginPage();
                loginPage.EnterCredentials();
                loginPage.SubmitLoginForm();*/

                /*LoginPage loginPage = new LoggerIn()
                    .SetDriver(webDriver)
                    .SetElement(element)
                    .CallLoginPage()
                    .EnterCredentials(ConfigParameters.login, ConfigParameters.password)
                    .SubmitLoginForm()
                    .Finalize();*/

                wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(3));
                wait.Until(d => d.FindElement(By.ClassName("cc-second")));
                element = webDriver.FindElement(By.ClassName("ac_input"));
                element.SendKeys("Naruto Shippuuden");
                element.SendKeys(Keys.Enter);

                webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
                wait.Until(driv => driv.FindElement(By.CssSelector("[data-search_url='https://shikimori.org/animes']")));
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

                IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
                string script = "alert('" + contentList + "')";
                js.ExecuteScript(script);
                Console.ReadKey();
                webDriver.Close();
            }
        }
    }
}
