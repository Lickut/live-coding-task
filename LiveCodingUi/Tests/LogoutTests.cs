global using NUnit.Framework;
using Microsoft.Playwright;

namespace LiveCodingUi.Tests
{
    public class LogoutTests
    {
        protected IBrowser Browser { get; private set; }
        protected IBrowserContext Context { get; private set; }
        protected IPlaywright PlaywrightInstance { get; private set; }
        protected IPage Page { get; private set; }

        [SetUp]
        public async Task Setup()
        {
            PlaywrightInstance = await Playwright.CreateAsync();
            Browser = await PlaywrightInstance.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false, Channel = "chrome" });
            Context = await Browser.NewContextAsync();
            Page = await Context.NewPageAsync();
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
        public async Task TearDown()
        {
            await Context.CloseAsync();
            await Browser.CloseAsync();
            PlaywrightInstance.Dispose();
        }
    }
}