using NUnit.Framework;
using OpenQA.Selenium;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium.Chrome;
using Contacts.Pages.HomePage;
using Contacts.Pages.AddUserPage;


namespace Contacts
{
    [TestFixture]
    public class Base
    {
        public IWebDriver driver;
        protected readonly IConfiguration config;
        protected readonly string url;

        protected readonly HomePage homePage;
        protected readonly AddUserPage addUserPage;
        protected readonly ContactListPage contactListPage;
        protected readonly AddContactPage addContactPage;


       public Base()
        {
            driver = new ChromeDriver();
            config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            url = config.GetSection("URL").Value;
            CleanStart();

            homePage = new HomePage(driver);
            addUserPage = new AddUserPage(driver);
            contactListPage = new ContactListPage(driver);
            addContactPage = new AddContactPage(driver);
        }

        protected void CleanStart()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl(url);
        }

        [OneTimeTearDown]
        protected void OneTimeTearDown()
        {
            System.Threading.Thread.Sleep(8100);
            driver.Quit();
        }
    }

}
