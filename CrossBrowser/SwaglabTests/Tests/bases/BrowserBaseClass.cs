using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SwaglabTests.Tests;

public class BrowserBaseClass
{
    private IWebDriver? _driver;

    protected string? Browser;

    public IWebDriver Driver => _driver ?? throw new NullReferenceException("driver must be set");

    protected void SetDriver()
    {
        try
        {
            _driver = (Browser?.ToLower()) switch
            {
                "chrome" => new ChromeDriver(),
                "firefox" => new FirefoxDriver(),
                _ => throw new ArgumentException($"{Browser} not yet implemented"),
            };
        }
        catch (WebDriverException)
        {
            End();
            SetDriver();
        }
    }

    protected void End()
    {
        _driver?.Quit();
        _driver?.Dispose();
    }
}