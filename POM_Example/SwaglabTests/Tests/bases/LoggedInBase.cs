using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SwaglabTests.Tests;

[TestFixture]
public class LoggedInBase
{
    
    protected IWebDriver? driver;
    
    [SetUp]
    public void Setup()
    {
        try
        {
            Start();
        }
        catch(WebDriverException)
        {
            End();
            Setup();
        }
    }

    [TearDown]
    public void CloseDriver()
    {
        End();
    }

    private void Start()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        driver.Manage().Cookies.AddCookie(new Cookie("session-username", "standard_user", "/"));
        driver.Navigate().GoToUrl("https://www.saucedemo.com/inventory.html");
    }

    private void End()
    {
        driver?.Quit();
        driver?.Dispose();
    }
}