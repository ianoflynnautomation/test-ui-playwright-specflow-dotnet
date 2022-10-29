using Microsoft.Playwright;
using System.Threading.Tasks;


namespace PlaywrightDemo.Pages
{
    public class LoginPage
    {
        private readonly IPage _page;
        public LoginPage(IPage page)
        {
            _page = page;
        }

        public async Task GoTo() => await _page.GotoAsync("https://www.saucedemo.com/");
        public async Task InputUserName(string userName) => await _page.FillAsync("id=user-name", userName);
        public async Task InputPassword(string password) => await _page.FillAsync("id=password", password);
        public async Task ClickLoginButton() => await _page.ClickAsync("id=login-button");

        public async Task Login(string userName, string password)
        {
            await InputUserName(userName);
            await InputPassword(password);
            await ClickLoginButton();
        }

        public async Task<string> GetLoginErrorMessage()
        {
            return await _page.InnerTextAsync("data-test=error");
        }
    }
}
