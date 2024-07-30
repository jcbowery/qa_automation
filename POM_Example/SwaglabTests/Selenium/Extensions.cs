using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SwaglabTests.Selenium;

public static class Extensions
{
    /// <summary>
    ///     Wait for all ajax actions to complete
    /// </summary>
    /// <param name="driver"></param>
    /// <param name="seconds"></param>
    public static void AjaxWait(this IWebDriver driver, int seconds = 3)
    {
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
        wait.Until(d =>
        {
            var js = (IJavaScriptExecutor)d;
            return (bool)js.ExecuteScript("return window.jQuery && window.jQuery.active == 0");
        });
    }

    /// <summary>
    ///     Wait for an element to be on the page.
    /// </summary>
    /// <param name="driver"></param>
    /// <param name="seconds"></param>
    /// <returns></returns>
    public static WebDriverWait ElementWait(this IWebDriver driver, int seconds = 5)
    {
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
        wait.IgnoreExceptionTypes([typeof(NoSuchElementException)]);
        return wait;
    }

    /// <summary>
    ///     Waits for the document ready state
    /// </summary>
    /// <param name="driver"></param>
    /// <param name="seconds"></param>
    public static void WaitForPageLoad(this IWebDriver driver, int seconds = 5)
    {
        WebDriverWait wait = new(driver, TimeSpan.FromSeconds(seconds));
        wait.Until(drv => ((IJavaScriptExecutor)drv).ExecuteScript("return document.readyState").Equals("complete"));
    }

    /// <summary>
    ///     Waits for at least 1 instance of an element on the page
    /// </summary>
    /// <param name="driver"></param>
    /// <param name="locator"></param>
    /// <param name="seconds"></param>
    /// <returns></returns>
    public static ICollection<IWebElement> ElementsExist(this IWebDriver driver, By locator, int seconds = 5)
    {
        WebDriverWait wait = new(driver, TimeSpan.FromSeconds(seconds));
        wait.Until(d => 
        {
            var elements = d.FindElements(locator);
            return elements.Count > 0;
        });
        return driver.FindElements(locator);
    }
}