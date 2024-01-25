using NUnit.Framework;
using RandomNumberGenerator = Contacts.Helpers.RandomNumberGenerator;


namespace Contacts.Tests.HappyPath
{
    public class RegistrationTest: Base
    {
        [Test]
        [Category("smoketest")]
        public void RegistrateUser() 
        {
            CleanStart();

            // Registrate User Flow
            homePage.ClickSignUpButton();
            addUserPage.EnterFirstName("John");
            addUserPage.EnterLastName("Doe");

            // Generate Random Number For Email So Test Passes Every Time We Run It
            string email = config.GetSection("Email").Value;
            string modifiedEmail = email.Split('@')[0] + "+" + RandomNumberGenerator.GenerateRandomNumericalString() + "@mail.com";
            addUserPage.EnterEmail(modifiedEmail);
            addUserPage.EnterPassword("password");
            addUserPage.ClickSubmitButton();
            addUserPage.EnterEmail(email);
            addUserPage.ClickLogOutButton();
        }
    }
}
