using OpenQA.Selenium;

namespace SwaglabTests.Pages;

public class OverviewPage(IWebDriver driver) : Page(driver, "https://www.saucedemo.com/checkout-step-two.html")
{
    IWebElement FinishButton => Driver.FindElement(By.Id("finish"));

    public CheckoutCompletePage ClickFinishButton()
    {
        FinishButton.Click();
        return new CheckoutCompletePage(Driver);
    }
}