namespace Automation.OnlinerSuite
{
    public class Preparation:OnlBasePage
    {
        
        public Preparation(IWebDriver driver):base(driver)
        {

        }

        public Preparation goToPage(){
            Driver.Manage().Timeouts().IplicitWait = TimeSpan.FromSeconds(10);
            Driver.Navigate().GoToUrl("https://www.onliner.by/");
            //Driver.FindElement(By.XPath("//div[@class='auth-bar__item auth-bar__item--text']"));
            Driver.FindElement(By.XPath(ElementPaths.loginButton));
            return this;
        }

    }
}