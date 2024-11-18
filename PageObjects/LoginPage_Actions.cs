public partial class LoginPage
{
    private readonly WebUtilities _webUtilities;

    public LoginPage(WebUtilities webUtilities)
    {
        _webUtilities = webUtilities;
    }

    public void EnterCredentials(string username, string password)
    {
        _webUtilities.FindElement(UsernameField).SendKeys(username);
        _webUtilities.FindElement(PasswordField).SendKeys(password);
    }

    public void ClickLoginButton()
    {
        _webUtilities.FindElement(LoginButton).Click();
    }
}