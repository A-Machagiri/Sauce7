using NUnit.Framework;
using PageObjects.Login;
using TechTalk.SpecFlow;
using Utilities;

namespace Test_Layer.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private LoginPage _loginPage;

        public LoginSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _loginPage = new LoginPage((WebUtilities)_scenarioContext["WebUtilities"]);
        }

        [Given("the user is on the login page of the application")]
        public void GivenTheUserIsOnTheLoginPageOfTheApplication()
        {
            _loginPage.NavigateToLoginPage("https://example.com/login");
        }

        [When("the user enters valid username '(.*)' and valid password '(.*)'")]
        public void WhenTheUserEntersValidUsernameAndValidPassword(string username, string password)
        {
            _loginPage.EnterUsername(username);
            _loginPage.EnterPassword(password);
        }

        [When("the user enters invalid username '(.*)' and valid password '(.*)'")]
        public void WhenTheUserEntersInvalidUsernameAndValidPassword(string username, string password)
        {
            _loginPage.EnterUsername(username);
            _loginPage.EnterPassword(password);
        }

        [When("the user leaves the username field empty")]
        public void WhenTheUserLeavesTheUsernameFieldEmpty()
        {
            _loginPage.EnterUsername("");
        }

        [When("the user enters valid username '(.*)'")]
        public void WhenTheUserEntersValidUsername(string username)
        {
            _loginPage.EnterUsername(username);
        }

        [When("the user leaves the password field empty")]
        public void WhenTheUserLeavesThePasswordFieldEmpty()
        {
            _loginPage.EnterPassword("");
        }

        [When("clicks on the login button")]
        public void WhenClicksOnTheLoginButton()
        {
            _loginPage.ClickLoginButton();
        }

        [Then("the user should be logged in and redirected to the products page")]
        public void ThenTheUserShouldBeLoggedInAndRedirectedToTheProductsPage()
        {
            Assert.IsTrue(_loginPage.IsOnProductsPage());
        }

        [Then("an error message should be displayed indicating (.*)")]
        public void ThenAnErrorMessageShouldBeDisplayedIndicating(string message)
        {
            Assert.IsTrue(_loginPage.IsErrorMessageDisplayed());
            Assert.AreEqual(message, _loginPage.GetErrorMessage());
        }
    }
}