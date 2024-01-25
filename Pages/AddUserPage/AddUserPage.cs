using Contact.Pages;
using OpenQA.Selenium;



namespace Contacts.Pages.AddUserPage
{
    public class AddUserPage : BasePage
    {
        private readonly By firstName = By.Id("firstName");
        private readonly By lastName = By.Id("lastName");
        private readonly By email = By.Id("email");
        private readonly By password = By.Id("password");
        private readonly By submitButton = By.Id("submit");
        private readonly By logOutButton = By.Id("logout");

        public AddUserPage(IWebDriver driver) : base(driver)
        {
        }

        public void EnterFirstName(string txt)
        {
            WaitAndClick(firstName);
            EnterString(firstName, txt);
        }
        public void EnterLastName(string txt) 
        {
            WaitAndClick(lastName);
            EnterString(lastName, txt);
        }
        public void EnterEmail(string txt) 
        {
            WaitAndClick(email);
            EnterString(email, txt);
        }
        public void EnterPassword(string txt) 
        {
            WaitAndClick(password);
            EnterString(password, txt);
        }      
        public void ClickSubmitButton() 
        {
            WaitAndClick(submitButton);
        }
        public void ClickLogOutButton()
        {
            WaitAndClick(logOutButton);
        }

    }
}
