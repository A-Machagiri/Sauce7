using TechTalk.SpecFlow;

namespace TestLayer
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            // Setup code before each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // Cleanup code after each scenario
        }
    }
}