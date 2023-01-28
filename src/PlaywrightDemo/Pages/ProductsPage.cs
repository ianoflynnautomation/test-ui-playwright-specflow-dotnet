using Microsoft.Playwright;
using System.Threading.Tasks;

namespace PlaywrightDemo.Pages
{
    public class ProductsPage
    {
        private readonly IPage _page;

        public ProductsPage(IPage page)
        {
            _page = page;
        }

        /// <summary>
        /// Gets the page title inner text.
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetTitle() => await _page.InnerTextAsync("text=Products");

        /// <summary>
        /// Clicks the back button.
        /// </summary>
        /// <returns></returns>
        public async Task ClickBack() => await _page.ClickAsync("id=add-to-cart-sauce-labs-backpack");
    }
}
