using TechTalk.SpecFlow;
using NUnit.Framework;

[Binding]
public class LoginSteps
{
    private LoginPage loginPage;
    private ScenarioContext _scenarioContext;

    public LoginSteps(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
        loginPage = new LoginPage((WebUtilities)_scenarioContext["WebUtilities"]);
    }

    [Given("I am on the login page")]
    public void GivenIAmOnTheLoginPage()
    {
        loginPage.NavigateToUrl("https://www.saucedemo.com/");
    }

    [When("I enter valid username and password")]
    public void WhenIEnterUsernameAndPassword()
    {
        loginPage.EnterCredentials("standard_user", "secret_sauce");
    }

    [When("I enter invalid username and password")]
    public void WhenIEnterInvalidUsernameAndPassword()
    {
        loginPage.EnterCredentials("invalid_user", "invalid_password");
    }

    [When("I click on the login button")]
    public void WhenIClickOnTheLoginButton()
    {
        loginPage.ClickLoginButton();
    }

    [Then("I should be redirected to the products page")]
    public void ThenIShouldBeRedirectedToTheProductsPage()
    {
        Assert.IsTrue(loginPage.IsOnProductsPage());
    }

    [Then("I should see an error message indicating 'invalid credentials'")]
    public void ThenIShouldSeeAnErrorMessageIndicatingInvalidCredentials()
    {
        Assert.AreEqual("invalid credentials", loginPage.GetErrorMessage());
    }
}