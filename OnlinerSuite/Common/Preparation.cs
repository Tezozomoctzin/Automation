namespace Automation.OnlinerSuite
{
    public class Preparation
    {
        private IWebDriver driver;

        public Preparation(IWebDriver driver)
        {
            this.driver = driver;
        }

        public static Preparation goToPage(){
            driver.Manage().Timeouts().IplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://www.onliner.by/");
            //Driver.FindElement(By.XPath("//div[@class='auth-bar__item auth-bar__item--text']"));
            driver.FindElement(By.XPath(ElementPaths.loginButton));
            return this;
        }

    }
}