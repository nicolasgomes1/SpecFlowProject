using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyNamespace
{
    [Binding]
    public class StepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver driver;

        public StepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = ("https://www.youtube.com/");
            Thread.Sleep(5000);
        }

        [Then(@"Search for the Testers Talk")]
        public void ThenSearchForTheTestersTalk()
        {
            IWebElement Element = driver.FindElement(By.XPath(".//*[@name='search_query']"));
            Element.SendKeys("Testers Talk");
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
