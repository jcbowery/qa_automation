using OpenQA.Selenium;
using SwaglabTests.Pages;

namespace SwaglabTests.Actions;

public class CheckoutActions(IWebDriver driver)
{
    readonly IWebDriver _driver = driver;

    CartPage CartPage => new(_driver);
    OverviewPage OverviewPage => new(_driver);
    CheckoutCompletePage CheckoutCompletePage => new(_driver);

    /// <summary>
    ///     Runs through the actions of checking out. Up to the overview page. 
    /// </summary>
    /// <param name="firstname"></param>
    /// <param name="lastname"></param>
    /// <param name="zip"></param>
    /// <returns></returns>
    public CheckoutActions Checkout(string firstname, string lastname, string zip)
    {
        CartPage.ClickCheckoutButton()
        .EnterFirstName(firstname)
        .EnterLastName(lastname)
        .EnterZipCode(zip)
        .ClickContinueButton();
        return this;
    }

    /// <summary>
    ///     Completes an order from the overview page.
    /// </summary>
    /// <returns></returns>
    public CheckoutActions CompleteOrder()
    {
        OverviewPage.ClickFinishButton();
        return this;
    }

    /// <summary>
    ///     returns the text from the header in the Checkout Complete page.
    /// </summary>
    /// <returns></returns>
    public string GetCompletionText()
    {
        return CheckoutCompletePage.GetCompleteOrderTitleText();
    }
}