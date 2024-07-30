using SwaglabTests.Actions;

namespace SwaglabTests.Tests;

public class Logintests(string browser) : NotLoggedInBase(browser)
{
    [Test]
    public void LoginStandardUser()
    {
        var loginActions = new LoginActions(Driver);
            var loggedIn = loginActions
            .Login("standard_user", "secret_sauce", UserType.Standard, true)
            .IsLoggedIn();
        
            Assert.That(loggedIn, Is.True);
    }
}