using Microsoft.Playwright;

namespace LiveCodingUi.Pages
{
    public class LoginPage
    {
        private IPage _page;

        public LoginPage(IPage page)
        {
            _page = page;
        }

        public ILocator UsernameInput => _page.Locator("#user-name");
        public ILocator PasswordInput => _page.Locator("#password");
        public ILocator LoginButton => _page.Locator("#login-button");
    }
}
