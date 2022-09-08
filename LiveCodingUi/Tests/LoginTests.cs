using LiveCodingUi.Pages;
using Microsoft.Playwright;

namespace LiveCodingUi.Tests
{
    public class LoginTests
    {
        protected IPlaywright PlaywrightInstance { get; private set; }
        protected IBrowser Browser { get; private set; }
        protected IBrowserContext Context { get; private set; }
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
        public async Task LoginAsStandardUserWithValidCredentials()
        {
            //arrange
            await Page.GotoAsync("https://www.saucedemo.com/");

            //act
            var loginPage = new LoginPage(Page);
            await loginPage.Login("standard_user", "secret_sauce");

            //assert
            var inventoryPage = new InventoryPage(Page);
            bool isDisplyed = await inventoryPage.IsInventoryPageDisplayed();
            Assert.That(isDisplyed);
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