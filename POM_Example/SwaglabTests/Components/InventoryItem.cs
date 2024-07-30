using OpenQA.Selenium;
using SwaglabTests.Selenium;

namespace SwaglabTests.Components;

public class InventoryItem
{
    readonly IWebDriver _driver;
    readonly IWebElement _inventoryItem;

    public InventoryItem(IWebDriver driver, string title)
    {
        _driver = driver;
        _inventoryItem = GetComponentByTitle(title);
    }

    IWebElement AddToCartButton => _inventoryItem.FindElement(By.TagName("button"));

    public InventoryItem ClickAddToCartButton()
    {
        AddToCartButton.Click();
        return this;
    }

    private IWebElement GetComponentByTitle(string title)
    {
        var componentList = _driver.ElementsExist(By.ClassName("inventory_item"));
        foreach (IWebElement item in componentList)
        {
            var testTitle = item.FindElement(By.ClassName("inventory_item_name")).Text;
            if(testTitle == title)
            {
                return item;
            }
        }
        throw new NoSuchElementException($"No item componet with the title {title}");
    }
}