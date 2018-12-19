namespace Automation.OnlinerSuite
{
    public class Login:PageBase
    {
       
       
        public OnlLogin(IWebDriver driver):base(driver)
        {
            
        }

        public static OnlLoginFiller CreateFiller()
        {
            return new OnlLoginFiller();
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