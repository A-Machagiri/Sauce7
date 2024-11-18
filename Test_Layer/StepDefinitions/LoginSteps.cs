using TechTalk.SpecFlow;
using ProjectRoot.PageObjects.Login;
using ProjectRoot.Utilities.WebUtilities;
using FluentAssertions;
using OpenQA.Selenium;

namespace ProjectRoot.Test_Layer.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private LoginPage loginPage;

        public LoginSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            var webUtilities = (WebUtilities)_scenarioContext["WebUtilities"];
            loginPage = new LoginPage(webUtilities);
        }

        [Given("I navigate to the login page")]
        public void GivenINavigateToTheLoginPage()
        {
            loginPage.NavigateToUrl("{{url}}");
        }

        [When("I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            loginPage.EnterCredentials("validUser", "validPass");
            loginPage.ClickLoginButton();
        }

        [When("I enter invalid credentials")]
        public void WhenIEnterInvalidCredentials()
        {
            loginPage.EnterCredentials("invalidUser", "invalidPass");
            loginPage.ClickLoginButton();
        }

        [Then("I should be directed to the homepage")]
        public void ThenIShouldBeDirectedToTheHomepage()
        {
            // Add assertion to verify homepage navigation
        }

        [Then("I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            // Add assertion to verify error message
        }
    }
}