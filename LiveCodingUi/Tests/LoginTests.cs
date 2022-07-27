using NUnit.Framework;
using LiveCodingUi.Pages;
using OpenQA.Selenium.Chrome;

namespace LiveCodingUi.Tests
{
    public class LoginTests
    {
        private ChromeDriver _driver;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            options.AddArgument("disable-extensions");
            options.AddArguments("--incognito");
            _driver = new ChromeDriver(options);
        }

        [Test]
        public void LoginAsStandardUserWithValidCredentials()
        {
            //arrange
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            //act
            var loginPage = new LoginPage(_driver);
            loginPage.SetUsername("standard_user");
            loginPage.SetPassword("secret_sauce");
            loginPage.ClickLoginButton();

            //assert
            //add verification steps that inventory page is displayed
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}