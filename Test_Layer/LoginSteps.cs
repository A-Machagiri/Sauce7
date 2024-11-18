[Binding]
public class LoginSteps
{
    private readonly LoginPage _loginPage;

    public LoginSteps()
    {
        _loginPage = new LoginPage(new WebUtilities());
    }

    [Given("I navigate to the login page")]
    public void GivenINavigateToTheLoginPage()
    {
        _loginPage.NavigateTo("{{url}}"); // Replace "{{url}}" with actual URL
    }

    [When("I enter valid credentials")]
    public void WhenIEnterValidCredentials()
    {
        _loginPage.EnterCredentials(ConfigReader.TestUser, ConfigReader.TestPassword);
    }

    [When("I click the login button")]
    public void WhenIClickTheLoginButton()
    {
        _loginPage.ClickLoginButton();
    }

    [Then("I should be logged in successfully")]
    public void ThenIShouldBeLoggedInSuccessfully()
    {
        // Implement verification logic here
    }
}