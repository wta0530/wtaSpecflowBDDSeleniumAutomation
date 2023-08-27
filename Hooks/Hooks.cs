using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecFlowBDDAutomation.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        
        private readonly IObjectContainer _container;

        public Hooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario("@SearchEntity")]
        public void BeforeScenarioWithTag()
        {
            Console.WriteLine("Running inside the Hooks");
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            _container.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = _container.Resolve<IWebDriver>();
            if(driver != null)
            {
                driver.Quit(); 
            }
        }
    }
}