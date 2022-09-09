global using NUnit.Framework;
using LiveCodingUi.Pages;
using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;

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
        public async Task LogoutTest()
        {
            //arrange
            await Page.GotoAsync("https://www.saucedemo.com/");

            var loginPage = new LoginPage(Page);
            var inventoryPage = new InventoryPage(Page);
            await loginPage.UsernameInput.FillAsync("standard_user");
            await loginPage.PasswordInput.FillAsync("secret_sauce");
            await loginPage.LoginButton.ClickAsync();

            //act
            //add logout steps by opening side panel and clicking Logout
            await inventoryPage.BurgerMenu.ClickAsync();
            await inventoryPage.BurgerMenuLogout.ClickAsync();

            //assert
            await Expect(loginPage.UsernameInput).ToBeVisibleAsync();
            await Expect(loginPage.PasswordInput).ToBeVisibleAsync();
            await Expect(loginPage.LoginButton).ToBeVisibleAsync();
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