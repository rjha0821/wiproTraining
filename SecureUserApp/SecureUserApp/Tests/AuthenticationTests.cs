using NUnit.Framework;

[TestFixture]
public class AuthenticationTests
{
    [Test]
    public void TestUserRegistration()
    {
        AuthenticationService.Register("testuser", "password123");
        Assert.DoesNotThrow(() => AuthenticationService.Login("testuser", "password123"));
    }
}
