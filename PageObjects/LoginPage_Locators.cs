using OpenQA.Selenium;

public partial class LoginPage
{
    public static By UsernameField = By.Id("username");
    public static By PasswordField = By.Id("password");
    public static By LoginButton = By.Id("login");
    public static By ErrorMessage = By.Id("error");
    public static By ProductsPageTitle = By.CssSelector("title[content='Products']");
}