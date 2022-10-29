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

        public async Task<string> Title() => await _page.InnerTextAsync("text=Products");

        public async Task ClickSauceLabsBackpackButton() => await _page.ClickAsync("id=add-to-cart-sauce-labs-backpack");
    }
}
