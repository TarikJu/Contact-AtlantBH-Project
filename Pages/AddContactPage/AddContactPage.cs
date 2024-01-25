using Contact.Pages;
using OpenQA.Selenium;



namespace Contacts.Pages.AddUserPage
{
    public class AddContactPage : BasePage
    {
        private readonly By birthDate = By.Id("birthdate");
        private readonly By phone = By.Id("phone");
        private readonly By streetAddress = By.Id("street1");
        private readonly By city = By.Id("city");
        private readonly By postalCode = By.Id("postalCode");
        private readonly By country = By.Id("country");

        public AddContactPage(IWebDriver driver) : base(driver)
        {

        }
        public void EnterDateOfBirth(string txt)
        {
            WaitAndClick(birthDate);
            EnterString(birthDate, txt);
        }
        public void EnterPhone(string txt)
        {
            WaitAndClick(phone);
            EnterString(phone, txt);
        }
        public void EnterStreetAddress(string txt)
        {
            WaitAndClick(streetAddress);
            EnterString(streetAddress, txt);
        }

        public void EnterCity(string txt)
        {
            WaitAndClick(city);
            EnterString(city, txt);
        }

        public void EnterPostalCode(string txt)
        {
            WaitAndClick(postalCode);
            EnterString(postalCode, txt);
        }
        public void EnterCountry(string txt)
        {
            WaitAndClick(country);
            EnterString(country, txt);
        }

    }
}
