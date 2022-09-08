using Microsoft.Playwright;

namespace LiveCodingUi.Pages
{
    public class InventoryPage
    {
        private IPage _page;

        public InventoryPage(IPage page)
        {
            _page = page;
        }

        public ILocator SideMenuButton => _page.Locator("#react-burger-menu-btn");
        public ILocator AllItemsLink => _page.Locator("#inventory_sidebar_link");
        public ILocator AboutLink => _page.Locator("#about_sidebar_link");
        public ILocator LogoutLink => _page.Locator("#logout_sidebar_link");
        public ILocator ResetAppStateLink => _page.Locator("#reset_sidebar_link");
        public ILocator SideMenuCrossButton => _page.Locator("#react-burger-cross-btn");
        public ILocator CartButton => _page.Locator("#shopping_cart_container");
        public ILocator SortingDropdown => _page.Locator("data-test=product_sort_container");

        public async Task<bool> IsInventoryPageDisplayed() => await SideMenuButton.IsVisibleAsync();
        public async Task OpenSideMenu() => await SideMenuButton.ClickAsync();
        public async Task OpenAllItems() => await AllItemsLink.ClickAsync();
        public async Task OpenAbout() => await AboutLink.ClickAsync();
        public async Task ClickLogout() => await LogoutLink.ClickAsync();
        public async Task ClickResetAppStateLink() => await ResetAppStateLink.ClickAsync();
        public async Task CloseSideMenu() => await SideMenuButton.ClickAsync();
        public async Task OpenCart() => await CartButton.ClickAsync();
        public async Task SortNameAZ() => await SortingDropdown.SelectOptionAsync("az");
        public async Task SortNameZA() => await SortingDropdown.SelectOptionAsync("za");
        public async Task SortPriceLowHiigh() => await SortingDropdown.SelectOptionAsync("lohi");
        public async Task SortPriceHiLo() => await SortingDropdown.SelectOptionAsync("hilo");
    }
}
