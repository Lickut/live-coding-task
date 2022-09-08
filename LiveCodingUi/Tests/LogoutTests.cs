global using NUnit.Framework;
using LiveCodingUi.Pages;
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
        public async Task LogoutAsStandardUser()
        {
            //arrange
            await Page.GotoAsync("https://www.saucedemo.com/");
            var loginPage = new LoginPage(Page);
            await loginPage.Login("standard_user", "secret_sauce");

            //act
            var inventoryPage = new InventoryPage(Page);
            await inventoryPage.OpenSideMenu();
            await inventoryPage.ClickLogout();

            //assert
            bool isDisplayed = await loginPage.IsLoginPageDisplayed();
            Assert.That(isDisplayed, Is.True);
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