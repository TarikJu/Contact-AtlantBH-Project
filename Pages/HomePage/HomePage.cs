using Contact.Pages;
using OpenQA.Selenium;


namespace Contacts.Pages.HomePage
{
    public class HomePage : BasePage
    {
        private readonly By emailField = By.Id("email");
        private readonly By pwField = By.Id("password");
        private readonly By signUpButton = By.Id("signup");
        private readonly By loginErrorMessage = By.Id("error");

        public HomePage(IWebDriver driver) : base(driver)
        {

        }

        public void EnterEmail(string txt)
        {
            WaitAndClick(emailField);
            driver.FindElement(emailField).SendKeys(txt);
        }

        public void ClickSignUpButton() 
        { 
            WaitAndClick(signUpButton);
        }

        public void ClearEmailInput() 
        {
            WaitAndClick(emailField);
            ClearInput(emailField);
        }
        public void ClearPwInput()
        {
            WaitAndClick(pwField);
            ClearInput(pwField);
        }

        public string GetErrorMessage()
        {
           return driver.FindElement(loginErrorMessage).Text;
        }
        
    }

}
