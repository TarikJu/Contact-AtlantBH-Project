using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace Contact.Pages
{
    public class BasePage
    {
        protected readonly IWebDriver driver;
        protected readonly IWebElement element;
        protected readonly WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, new System.TimeSpan(0, 0, 5));

        }

        public void WaitAndClick(By el)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(el));
            driver.FindElement(el).Click();
        }

        public void EnterString(By el, string txt) 
        { 
            driver.FindElement(el).SendKeys(txt); 
        }
        public void ClearInput(By el)
        {
            WaitAndClick(el);
            driver.FindElement(el).Clear();
        }
    }

}
