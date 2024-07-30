using OpenQA.Selenium;

namespace SwaglabTests.Pages;

public class IncorrectUrlException : Exception
{
    // Default constructor
    public IncorrectUrlException() 
    { 
    }

    // Constructor that takes a message
    public IncorrectUrlException(string message) 
        : base(message) 
    { 
    }

    // Constructor that takes a message and an inner exception
    public IncorrectUrlException(string message, Exception inner) 
        : base(message, inner) 
    { 
    }
}

public class Page
{
    protected string Url {get; set;}
    protected IWebDriver Driver;

    public Page(IWebDriver driver, string url)
    {
        Driver = driver;
        Url = url;

        var actualUrl = driver.Url;
        if(actualUrl != Url)
        {
            throw new IncorrectUrlException($"Expected url of {Url} but got {actualUrl}");
        }
    }
}