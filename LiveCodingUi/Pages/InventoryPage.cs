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
    }
}
