using NUnit.Framework;



namespace Contacts.Tests.HappyPath
{
    public class AddNewContact : Base
    {
        [Test]
        public void AddContact()
        {
            CleanStart();
            // Login
            string email = config.GetSection("Email").Value;
            addUserPage.EnterEmail(email);
            string password = config.GetSection("Password").Value;
            addUserPage.EnterPassword(password);
            addUserPage.ClickSubmitButton();

            // Add New Contact
            contactListPage.ClickOnAddNewContactButton();
            addUserPage.EnterFirstName(config.GetSection("first_name").Value);
            addUserPage.EnterLastName(config.GetSection("last_name").Value);
            addContactPage.EnterDateOfBirth("2001-01-01");
            addUserPage.EnterEmail(config.GetSection("new_contact_email").Value);
            addContactPage.EnterPhone(config.GetSection("phone_number").Value);
            addContactPage.EnterStreetAddress(config.GetSection("street_address").Value);
            addContactPage.EnterCity(config.GetSection("city").Value);
            addContactPage.EnterPostalCode(config.GetSection("postal_code").Value);
            addContactPage.EnterCountry(config.GetSection("country").Value);
            addUserPage.ClickSubmitButton();
        }
    }
}