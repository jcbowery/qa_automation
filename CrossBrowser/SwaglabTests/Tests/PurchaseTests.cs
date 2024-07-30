using OpenQA.Selenium;
using SwaglabTests.Actions;

namespace SwaglabTests.Tests;

public class PurchaseTests : LoggedInBase
{
    [TestCase("chrome")]
    public void BuyAnItem(string browser)
    {
        Browser = browser;
        SetDriver();
        Driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        Driver.Manage().Cookies.AddCookie(new Cookie("session-username", "standard_user", "/"));
        Driver.Navigate().GoToUrl("https://www.saucedemo.com/inventory.html");

        var shoppingActions = new ShopActions(Driver);
        var text = shoppingActions
            .AddItemToCart("Sauce Labs Backpack")
            .MoveToCheckout()
            .Checkout("josh", "smith", "32725")
            .CompleteOrder()
            .GetCompletionText();

        Assert.That(text, Is.EqualTo("Thank you for your order!"));
    }

    [TestCase("firefox")]
    [TestCase("chrome")]
    public void BuyThreeItems(string browser)
    {
         Browser = browser;
         SetDriver();
         Driver.Navigate().GoToUrl("https://www.saucedemo.com/");
         Driver.Manage().Cookies.AddCookie(new Cookie("session-username", "standard_user", "/"));
         Driver.Navigate().GoToUrl("https://www.saucedemo.com/inventory.html");

         var shoppingActions = new ShopActions(Driver);
         var text = shoppingActions
            .AddItemToCart("Sauce Labs Backpack")
            .AddItemToCart("Sauce Labs Bike Light")
            .AddItemToCart("Sauce Labs Onesie")
            .MoveToCheckout()
            .Checkout("josh", "smith", "32725")
            .CompleteOrder()
            .GetCompletionText();

        Assert.That(text, Is.EqualTo("Thank you for your order!"));
    }
}