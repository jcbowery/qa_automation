using OpenQA.Selenium;

namespace SwaglabTests.Pages;

public class YourInfoPage(IWebDriver driver) : Page(driver, "https://www.saucedemo.com/checkout-step-one.html")
{
    IWebElement FirstNameField => Driver.FindElement(By.Id("first-name"));
    IWebElement LastNameField => Driver.FindElement(By.Id("last-name"));
    IWebElement ZipCodeField => Driver.FindElement(By.Id("postal-code"));
    IWebElement ContinueButton => Driver.FindElement(By.Id("continue"));

    public YourInfoPage EnterFirstName(string firstname)
    {
        FirstNameField.SendKeys(firstname);
        return this;
    }

    public YourInfoPage EnterLastName(string lastname)
    {
        LastNameField.SendKeys(lastname);
        return this;
    }

    public YourInfoPage EnterZipCode(string zipCode)
    {
        ZipCodeField.SendKeys(zipCode);
        return this;
    }

    public OverviewPage ClickContinueButton()
    {
        ContinueButton.Click();
        return new OverviewPage(Driver);
    }
}