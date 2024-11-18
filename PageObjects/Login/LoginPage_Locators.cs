using OpenQA.Selenium;

namespace YourNamespace.PageObjects.Login
{
    public partial class LoginPage
    {
        public By UsernameField => By.Id("user-name");
        public By PasswordField => By.Id("password");
        public By LoginButton => By.Id("login-button");
        // Add locators for product page after login for assertion
        public By ProductPageTitle => By.ClassName("title");
    }
}