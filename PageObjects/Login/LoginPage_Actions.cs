using YourProject.Utilities.WebUtilities;
using OpenQA.Selenium;

namespace YourProject.PageObjects.Login
{
    public partial class LoginPage
    {
        private readonly WebUtilities webUtilities;

        public LoginPage(WebUtilities webUtilities)
        {
            this.webUtilities = webUtilities;
        }

        public void EnterCredentials(string username, string password)
        {
            webUtilities.SendKeys(webUtilities.FindElement(UsernameField), username);
            webUtilities.SendKeys(webUtilities.FindElement(PasswordField), password);
        }

        public void ClickLoginButton()
        {
            webUtilities.Click(webUtilities.FindElement(LoginButton));
        }

        public bool IsProductsPageDisplayed()
        {
            return webUtilities.FindElement(ProductsPageElement).Displayed;
        }
    }
}