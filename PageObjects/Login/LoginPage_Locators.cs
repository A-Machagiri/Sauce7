using OpenQA.Selenium;

namespace PageObjects.Login
{
    public partial class LoginPage
    {
        public IWebElement UsernameField => _webUtilities.FindElement(By.Id("username"));
        public IWebElement PasswordField => _webUtilities.FindElement(By.Id("password"));
        public IWebElement LoginButton => _webUtilities.FindElement(By.Id("login-button"));
        public IWebElement ErrorMessage => _webUtilities.FindElement(By.CssSelector(".error-message"));
        public IWebElement ProductsPageTitle => _webUtilities.FindElement(By.CssSelector(".title"));
    }
}