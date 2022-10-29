using Microsoft.Playwright;
using System.Threading.Tasks;

namespace PlaywrightDemo.Pages.Sections
{
    public class HeaderSection
    {

        private readonly IPage _page;

        public HeaderSection(IPage page)
        {
            _page = page;
        }

        public async Task ClickShoppingCartButton() => await _page.ClickAsync("#shopping_cart_container a");
        
    }
}
