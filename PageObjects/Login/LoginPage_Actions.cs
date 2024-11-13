using Utilities.WebUtilities;

namespace PageObjects.Login
{
    public partial class LoginPage
    {
        private WebUtilities _webUtilities;

        public LoginPage(WebUtilities webUtilities)
        {
            _webUtilities = webUtilities;
        }

        public void EnterCredentials(string username, string password)
        {
            _webUtilities.SendKeys(UsernameField, username);
            _webUtilities.SendKeys(PasswordField, password);
        }

        public void ClickLoginButton()
        {
            _webUtilities.Click(LoginButton);
        }

        public string GetErrorMessage()
        {
            return _webUtilities.FindElement(ErrorMessage).Text;
        }

        public string GetProductPageTitle()
        {
            return _webUtilities.FindElement(ProductPageTitle).Text;
        }
    }
}