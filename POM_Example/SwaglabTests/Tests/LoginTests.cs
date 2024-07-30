using SwaglabTests.Actions;

namespace SwaglabTests.Tests;

public class Logintests : NotLoggedInBase
{
    [Test]
    public void LoginStandardUser()
    {
        if(driver != null)
        {
            var loginActions = new LoginActions(driver);
            var loggedIn = loginActions
            .Login("standard_user", "secret_sauce", UserType.Standard, true)
            .IsLoggedIn();
        
            Assert.That(loggedIn, Is.True);
        }
        else
        {
            Assert.Fail();
        }
    }
}