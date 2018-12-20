namespace Automation.OnlinerSuite
{
    public class OnlLogin:PageBase
    {
       
       
        public OnlLogin(IWebDriver driver):base(driver)
        {
            
        }

        public static OnlLoginFiller CreateFiller()
        {
            return new OnlLoginFiller(this.Driver);
        }

        public void toLoginForm()
        {
            Driver.FindElement(By.XPath(ElementPaths.loginButton)).Click();
        }

        public void Submit()
        {
            Driver.FindElement(By.XPath(ElementPaths.loginButtonSubmit)).Click();
        }

    }
}