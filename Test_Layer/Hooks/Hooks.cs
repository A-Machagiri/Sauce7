using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Utilities;

namespace Test_Layer.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly ScenarioContext _scenarioContext;
        private WebUtilities _webUtilities;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _webUtilities = new WebUtilities();
            _webUtilities.InitializeDriver("Chrome");
            _scenarioContext["WebUtilities"] = _webUtilities;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _webUtilities.Quit();
        }
    }
}