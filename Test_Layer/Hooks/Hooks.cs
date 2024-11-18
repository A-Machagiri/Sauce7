using TechTalk.SpecFlow;
using ProjectRoot.Utilities.WebUtilities;

namespace ProjectRoot.Test_Layer.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly ScenarioContext _scenarioContext;
        private WebUtilities webUtilities;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            webUtilities = new WebUtilities();
            _scenarioContext["WebUtilities"] = webUtilities.InitializeDriver("chrome");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            webUtilities.Quit();
        }
    }
}