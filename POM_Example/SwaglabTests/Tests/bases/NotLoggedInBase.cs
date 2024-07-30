using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SwaglabTests.Tests;

[TestFixture("firefox")]
public class NotLoggedInBase
{
    
    protected IWebDriver? driver;

 
    [SetUp]
    public void Setup()
    {
        try
        {
            Start();
        }
        catch( WebDriverException)
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
    }

    private void End()
    {
        driver?.Quit();
        driver?.Dispose();
    }
}