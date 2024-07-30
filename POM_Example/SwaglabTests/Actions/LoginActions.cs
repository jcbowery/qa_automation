using OpenQA.Selenium;
using SwaglabTests.Pages;

namespace SwaglabTests.Actions;

public enum UserType
{
    Standard
}

public class LoginActions(IWebDriver driver)
{
    readonly IWebDriver _driver = driver;
    LoginPage LoginPage => new(_driver);

    /// <summary>
    ///     Login a user. Uses a usertype and valid credentials input in case the output is dependent. 
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    /// <param name="usertype"></param>
    /// <param name="validCredentials"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    /// <exception cref="Exception"></exception>
    public LoginActions Login(string username, string password, UserType usertype, bool validCredentials)
    {
        LoginPage.EnterUsername(username);
        LoginPage.EnterPassword(password);
        LoginPage.ClickLoginButton();

        switch(usertype)
        {
            case UserType.Standard:
                if(validCredentials)
                {
                    return this;
                }
                else
                {
                    throw new NotImplementedException();
                }
            default:
                throw new Exception("user type not implemented");
        }
    }

    /// <summary>
    ///     Returns true if on the Products Page
    /// </summary>
    /// <returns></returns>
    public bool IsLoggedIn()
    {
        return _driver.Url == "https://www.saucedemo.com/inventory.html";
    }

}