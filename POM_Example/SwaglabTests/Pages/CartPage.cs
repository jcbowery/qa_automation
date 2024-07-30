using OpenQA.Selenium;
using SwaglabTests.Selenium;

namespace SwaglabTests.Pages;

public class CartPage(IWebDriver driver) : Page(driver,"https://www.saucedemo.com/cart.html")
{
    IWebElement CheckoutButton => Driver.ElementWait().Until(d => d.FindElement(By.Id("checkout")));

    public YourInfoPage ClickCheckoutButton()
    {
        CheckoutButton.Click();
        return new YourInfoPage(Driver);
    }
}