using Utilities;

namespace PageObjects.Login
{
    public partial class LoginPage
    {
        private readonly WebUtilities _webUtilities;

        public LoginPage(WebUtilities webUtilities)
        {
            _webUtilities = webUtilities;
        }

        public void EnterUsername(string username)
        {
            UsernameField.Clear();
            UsernameField.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            PasswordField.Clear();
            PasswordField.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            LoginButton.Click();
        }

        public bool IsErrorMessageDisplayed()
        {
            return ErrorMessage.Displayed;
        }

        public string GetErrorMessage()
        {
            return ErrorMessage.Text;
        }

        public bool IsOnProductsPage()
        {
            return ProductsPageTitle.Text.Contains("Products");
        }
    }
}