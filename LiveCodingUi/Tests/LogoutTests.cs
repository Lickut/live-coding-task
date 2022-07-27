global using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace LiveCodingUi.Tests
{
    public class LogoutTests
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
        public void Test1()
        {
            //arrange
            //add steps to login to application

            //act
            //add logout steps by opening side panel and clicking Logout

            //assert
            //add verification steps that loging page is displayed
            throw new NotImplementedException();
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}