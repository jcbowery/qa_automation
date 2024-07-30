using OpenQA.Selenium;
using SwaglabTests.Components;
using SwaglabTests.Selenium;

namespace SwaglabTests.Pages;

public class ProductsPage(IWebDriver driver) : Page(driver, "https://www.saucedemo.com/inventory.html")
{
    public InventoryItem Item(string title) => new(Driver, title);

    IWebElement ShoppingCart => Driver.FindElement(By.Id("shopping_cart_container"));
    IWebElement ShoppingCartBadge => Driver.ElementWait().Until(d => d.FindElement(By.ClassName("shopping_cart_badge")));

    public CartPage ClickShoppingCart()
    {
        ShoppingCart.Click();
        return new CartPage(Driver);
    }
}