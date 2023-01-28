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

        /// <summary>
        /// Clicks the shopping cart icon.
        /// </summary>
        public async Task OpenShoppingCart() => await _page.ClickAsync("#shopping_cart_container a");
        
    }
}
