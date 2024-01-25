using Contact.Pages;
using OpenQA.Selenium;


namespace Contacts.Pages.HomePage
{
    public class ContactListPage : BasePage
    {
        private readonly By addNewContactButton = By.Id("add-contact");

        public ContactListPage(IWebDriver driver) : base(driver)
        {

        }

        public void ClickOnAddNewContactButton()
        {
            WaitAndClick(addNewContactButton);
        }


    }
}
