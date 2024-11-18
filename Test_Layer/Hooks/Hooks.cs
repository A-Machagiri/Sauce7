using TechTalk.SpecFlow;
using YourProject.Utilities.WebUtilities;

namespace YourProject.Test_Layer.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly WebUtilities webUtilities = new WebUtilities();
        private readonly ScenarioContext _scenarioContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _scenarioContext["WebUtilities"] = webUtilities.InitializeDriver("chrome");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            webUtilities.Quit();
        }
    }
}