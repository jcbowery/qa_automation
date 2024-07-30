using OpenQA.Selenium.Chrome;

namespace SwaglabTests.Tests;

[TestFixture("firefox")]
public class NotLoggedInBase : BrowserBaseClass
{
    public NotLoggedInBase(string browser)
    {
        Browser = browser;
    }

 
    [SetUp]
    public void Setup()
    {
       SetDriver();
       Driver.Navigate().GoToUrl("https://www.saucedemo.com/");
    }

    [TearDown]
    public void CloseDriver()
    {
        End();
    }
}