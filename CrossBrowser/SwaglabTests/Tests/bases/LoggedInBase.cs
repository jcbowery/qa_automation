namespace SwaglabTests.Tests;

[TestFixture]
public class LoggedInBase : BrowserBaseTest
{
    
    [TearDown]
    public void CloseDriver()
    {
        End();
    }
}