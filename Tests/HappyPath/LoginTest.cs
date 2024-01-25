using NUnit.Framework;
using System.ComponentModel.DataAnnotations;


namespace Contacts.Tests.HappyPath
{
    public class LoginTest: Base
    {
        [Test]
        public void LoginUser()
        {
            CleanStart();
            string email = config.GetSection("Email").Value; 
            addUserPage.EnterEmail(email);
            string password = config.GetSection("Password").Value;
            addUserPage.EnterPassword(password);
            addUserPage.ClickSubmitButton();
            addUserPage.ClickLogOutButton();
        }
    }
}
