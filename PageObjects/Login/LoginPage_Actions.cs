// LoginPage_Actions.cs
using ProjectRoot.Utilities.WebUtilities;

namespace ProjectRoot.PageObjects.Login
{
    public partial class LoginPage
    {
        private WebUtilities webUtilities;

        public LoginPage(WebUtilities utilities)
        {
            this.webUtilities = utilities;
        }

        public void EnterCredentials(string username, string password)
        {
            var usernameField = webUtilities.FindElement(UsernameField);
            var passwordField = webUtilities.FindElement(PasswordField);
            webUtilities.SendKeys(usernameField, username);
            webUtilities.SendKeys(passwordField, password);
        }

        public void ClickLoginButton()
        {
            var loginButton = webUtilities.FindElement(LoginButton);
            webUtilities.Click(loginButton);
        }

        // Add methods to interact with the homepage elements for assertion
    }
}