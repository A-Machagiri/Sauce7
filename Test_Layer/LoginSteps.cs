using TechTalk.SpecFlow;
using PageObjects;

namespace TestLayer
{
    [Binding]
    public class LoginSteps
    {
        private LoginPageActions loginPageActions;

        public LoginSteps()
        {
            loginPageActions = new LoginPageActions();
        }

        [Given("I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            loginPageActions.NavigateToLoginPage();
        }

        [When("I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            loginPageActions.EnterCredentials("validUser", "validPassword");
        }

        [When("I enter invalid credentials")]
        public void WhenIEnterInvalidCredentials()
        {
            loginPageActions.EnterCredentials("invalidUser", "invalidPassword");
        }

        [And("I click the login button")]
        public void AndIClickTheLoginButton()
        {
            loginPageActions.ClickLoginButton();
        }

        [Then("I should be redirected to the dashboard")]
        public void ThenIShouldBeRedirectedToTheDashboard()
        {
            loginPageActions.VerifySuccessfulLogin();
        }

        [Then("I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            loginPageActions.VerifyUnsuccessfulLogin();
        }
    }
}