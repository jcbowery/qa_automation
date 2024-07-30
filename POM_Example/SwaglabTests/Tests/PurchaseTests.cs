using SwaglabTests.Actions;

namespace SwaglabTests.Tests;

public class PurchaseTests : LoggedInBase
{
    [Test]
    public void BuyAnItem()
    {
        var shoppingActions = new ShopActions(driver);
        var text = shoppingActions
        .AddItemToCart("Sauce Labs Backpack")
        .MoveToCheckout()
        .Checkout("josh", "smith", "32725")
        .CompleteOrder()
        .GetCompletionText();

        Assert.That(text, Is.EqualTo("Thank you for your order!"));
    }

    [Test]
    public void BuyThreeItems()
    {
         var shoppingActions = new ShopActions(driver);
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