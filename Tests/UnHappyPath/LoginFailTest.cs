using NUnit.Framework;


namespace Contacts.Tests.UnHappyPath
{
    public class LoginFailTest: Base
    {
        private readonly string loginErrorMessage = "Incorrect username or password";

        [Test]
        public void WrongCredentialsError()
        {
            CleanStart();
            // Check Error Message for Invalid Email
            string invalidEmail = config.GetSection("invalid_email").Value;
            addUserPage.EnterEmail(invalidEmail);
            string password = config.GetSection("password").Value;
            addUserPage.EnterPassword(password);
            addUserPage.ClickSubmitButton();
            Thread.Sleep(1200);
            Assert.AreEqual(homePage.GetErrorMessage(), loginErrorMessage);
            Thread.Sleep(2200);

            // Check Error Message for Wrong Password 
            homePage.ClearEmailInput();
            string email = config.GetSection("email").Value;
            addUserPage.EnterEmail(email); 
            string wrongPassword = config.GetSection("wrong_password").Value;
            homePage.ClearPwInput();
            addUserPage.EnterPassword(wrongPassword);
            addUserPage.ClickSubmitButton();
            Assert.AreEqual(loginErrorMessage, homePage.GetErrorMessage());
        }
        

    }
}
