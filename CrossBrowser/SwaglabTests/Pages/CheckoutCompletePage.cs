using OpenQA.Selenium;
using SwaglabTests.Selenium;

namespace SwaglabTests.Pages;

public class CheckoutCompletePage(IWebDriver driver) : Page(driver, "https://www.saucedemo.com/checkout-complete.html")
{
    IWebElement OrderCompleteTitle => Driver.ElementWait().Until(d => d.FindElement(By.ClassName("complete-header")));

    public string GetCompleteOrderTitleText()
    {
        return OrderCompleteTitle.Text;
    }
}