using OpenQA.Selenium;
using SwaglabTests.Pages;

namespace SwaglabTests.Actions;

public class ShopActions(IWebDriver driver)
{
    readonly IWebDriver _driver = driver;

    ProductsPage productsPage => new(_driver);

    /// <summary>
    ///     Add's an item to the cart
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public ShopActions AddItemToCart(string item)
    {
        productsPage.Item(item).ClickAddToCartButton();
        return this;
    }

    /// <summary>
    ///     Move the user to checkout
    /// </summary>
    /// <returns></returns>
    public CheckoutActions MoveToCheckout()
    {
        productsPage.ClickShoppingCart();
        return new CheckoutActions(_driver);
    }
}