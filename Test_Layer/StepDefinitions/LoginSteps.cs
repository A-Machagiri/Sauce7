using NUnit.Framework;
using PageObjects.Login;
using TechTalk.SpecFlow;

namespace Test_Layer.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private LoginPage _loginPage;

        public LoginSteps(LoginPage loginPage)
        {
            _loginPage = loginPage;
        }

        [Given("I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            _loginPage.NavigateToLoginPage();
        }

        [When("I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            _loginPage.EnterCredentials("standard_user", "secret_sauce");
        }

        [When("I enter invalid credentials")]
        public void WhenIEnterInvalidCredentials()
        {
            _loginPage.EnterCredentials("invalid_user", "invalid_password");
        }

        [Then("I should be redirected to the product page")]
        public void ThenIShouldBeRedirectedToTheProductPage()
        {
            Assert.AreEqual("PRODUCTS", _loginPage.GetProductPageTitle());
        }

        [Then("I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            Assert.IsTrue(_loginPage.GetErrorMessage().Contains("error"));
        }
    }
}