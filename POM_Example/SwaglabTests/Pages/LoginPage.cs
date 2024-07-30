using OpenQA.Selenium;

namespace SwaglabTests.Pages;

public class LoginPage(IWebDriver driver) : Page(driver, "https://www.saucedemo.com/")
{
    IWebElement LoginField => Driver.FindElement(By.Id("user-name"));
    IWebElement PasswordField => Driver.FindElement(By.Id("password"));
    IWebElement LoginButton => Driver.FindElement(By.Id("login-button"));

    public LoginPage EnterUsername(string username)
    {
        LoginField.SendKeys(username);
        return this;
    }

    public LoginPage EnterPassword(string password)
    {
        PasswordField.SendKeys(password);
        return this;
    }

    public ProductsPage ClickLoginButton()
    {
        LoginButton.Click();
        return new ProductsPage(Driver);
    }
}