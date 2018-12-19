namespace Automation.OnlinerSuite

{
    public class OnlBasePage
    {
        private IWebDriver driver;

        public IWebDriver Driver { get => driver;}

        public OnlBasePage(IWebDriver driver)
        {
            this.Driver = driver;
        }

    }
}