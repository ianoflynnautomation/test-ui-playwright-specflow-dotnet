using BoDi;
using Microsoft.Playwright;
using Practice.One.UI.Settings;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PlaywrightDemo.Tests.UI.Hooks
{
    [Binding]
    public class TestHooks
    {
        private readonly IObjectContainer _objectContainer;

        public TestHooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public async Task BeforeScenarioAsync()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = ConfigurationService.GetWebSettings().HeadLess,
                SlowMo = ConfigurationService.GetWebSettings().SlowMo,
            });
            var page = await browser.NewPageAsync();
            await page.GotoAsync(ConfigurationService.GetWebSettings().BaseUrl);
            _objectContainer.RegisterInstanceAs(browser);
            _objectContainer.RegisterInstanceAs(page);
        }

        [AfterScenario]
        public async Task AfterScenario()
        {
            var browser = _objectContainer.Resolve<IBrowser>();
            await browser.CloseAsync();
        }
    }
}
