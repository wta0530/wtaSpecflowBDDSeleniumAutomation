using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowBDDAutomation.StepDefinitions
{
    [Binding]
    public sealed class YoutubeSearchStepDefinitions
    {
        private IWebDriver driver;

        public  YoutubeSearchStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            //driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://www.youtube.com/";
            Thread.Sleep(2000);
        }

        [Then(@"Search for the Way To Automation")]
        public void ThenSearchForTheWayToAutomation()
        {
            driver.FindElement(By.XPath("//input[@id='search']")).SendKeys("Way To Automation");
            driver.FindElement(By.XPath("//input[@id='search']")).SendKeys(Keys.Enter);

            Thread.Sleep(2000);

            //driver.Quit();
        }

    }
}