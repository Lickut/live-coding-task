using OpenQA.Selenium;

namespace LiveCodingUi.Pages
{
    public class InventoryPage
    {
        private IWebDriver _driver;

        public InventoryPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
