using LiveCodingUi.Pages;
using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;
namespace LiveCodingUi.Tests
{
    public class LoginTests
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
        public async Task LoginAsStandardUserWithValidCredentials()
        {
            //arrange
            await Page.GotoAsync("https://www.saucedemo.com/");

            //act
            var loginPage = new LoginPage(Page);
            await loginPage.UsernameInput.FillAsync("standard_user");
            await loginPage.PasswordInput.FillAsync("secret_sauce");
            await loginPage.LoginButton.ClickAsync();

            //assert           
            var inventoryPage = new InventoryPage(Page);
            await Expect(inventoryPage.TitlePage).ToBeVisibleAsync();
            await Expect(inventoryPage.Filter).ToBeVisibleAsync();
            await Expect(inventoryPage.BurgerMenu).ToBeVisibleAsync();
            await Expect(inventoryPage.ShopingCard).ToBeVisibleAsync();

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