namespace YourNamespace.PageObjects.Login
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
            webUtilities.SendKeys(UsernameField, username);
            webUtilities.SendKeys(PasswordField, password);
        }

        public void ClickLoginButton()
        {
            webUtilities.Click(LoginButton);
        }

        // Add methods for interacting with product page elements if needed
    }
}