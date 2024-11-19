using TechTalk.SpecFlow;

[Binding]
public class Hooks
{
    private WebUtilities webUtilities;
    private ScenarioContext _scenarioContext;

    public Hooks(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [BeforeScenario]
    public void Initialize()
    {
        webUtilities = new WebUtilities();
        _scenarioContext["WebUtilities"] = webUtilities.InitializeDriver("chrome");
    }

    [AfterScenario]
    public void CleanUp()
    {
        webUtilities.Quit();
    }
}