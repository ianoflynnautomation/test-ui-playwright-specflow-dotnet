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

        private async Task EnterUserName(string userName) => await _page.FillAsync("id=user-name", userName);
        private async Task EnterPassword(string password) => await _page.FillAsync("id=password", password);
        private async Task ClickLoginButton() => await _page.ClickAsync("id=login-button");

        /// <summary>
        /// Navigates user to the application HomePage.
        /// </summary>
        /// <returns></returns>
        public async Task GoTo() => await _page.GotoAsync("https://www.saucedemo.com/");

        /// <summary>
        /// Login to the application with a user.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        ///  /// <returns></returns>
        public async Task Login(string userName, string password)
        {
            await EnterUserName(userName);
            await EnterPassword(password);
            await ClickLoginButton();
        }

        /// <summary>
        /// Gets the error message text.
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetErrorMessage()
        {
            return await _page.InnerTextAsync("data-test=error");
        }
    }
}
