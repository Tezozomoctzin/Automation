namespace Automation.OnlinerSuite
{
    public class OnlLoginFiller:OnlBasePage
    {

        private OnlLogin lgn;

        public OnlLoginFiller(IWebDriver driver):base(driver)
        {
            lgn = new OnlLogin();
        }

        public OnlLoginFiller fillLogin(){
            Driver.FindElement(By.XPath(ElementPaths.loginFieldName)).SendKeys(OnlLoginCreds.loginName);
            Driver.FindElement(By.Xpath(ElementPaths.loginFieldPass)).SendKeys(OnlLoginCreds.loginPass);
            return this;
        }

        public OnlLogin Finalaize(){
            return lgn;
        }
        
    }
}