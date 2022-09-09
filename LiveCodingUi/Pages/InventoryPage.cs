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
        public ILocator BurgerMenu => _page.Locator("id=react-burger-menu-btn");
        public ILocator ShopingCard => _page.Locator("id=shopping_cart_container");
        public ILocator Filter => _page.Locator("data-test=product_sort_container");
        public ILocator TitlePage => _page.Locator("text='Products'");

        public ILocator BurgerMenuLogout => _page.Locator("id=logout_sidebar_link");

    }
}
