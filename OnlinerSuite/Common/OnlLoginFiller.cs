namespace Automation.OnlinerSuite
{
    public class OnlLoginFiller:OnlBasePage
    {

        private OnlLogin lgn;
        private IWebDriver driver;

        public OnlLoginFiller(IWebDriver driver)
        {
            lgn = new OnlLogin();
            this.driver = driver;
        }

        public OnlLoginFiller fillLogin(){
            driver.FindElement(By.XPath(ElementPaths.loginFieldName)).SendKeys(OnlLoginCreds.loginName);
            driver.FindElement(By.Xpath(ElementPaths.loginFieldPass)).SendKeys(OnlLoginCreds.loginPass);
            return this;
        }

        public OnlLogin Finalaize(){
            return lgn;
        }
        
    }
}