using FluentAssertions;
using PlaywrightDemo.Models;
using PlaywrightDemo.Pages;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace PlaywrightDemo.Tests.UI.Features
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginPage _loginPage;
        private readonly ProductsPage _productsPage;
        public LoginSteps(LoginPage homepage, ProductsPage productsPage)
        {
            _loginPage = homepage;
            _productsPage = productsPage;
        }

        [Given(@"I navigate to the website home page")]
        public async Task GivenINavigateToTheWebsiteHomePageAsync()
        {
            await _loginPage.GoTo();
        }

        [When(@"I login with a valid users credentials (.*) (.*)")]
        public async Task WhenILoginWithAValidUsersCredentials(string userName, string password)
        {
            await _loginPage.Login(userName, password);
        }

        [When(@"I login with users credentials")]
        public async Task WhenILoginWithUsersCredentials(Table table)
        {
            var testData = table.CreateInstance<User>();
            await _loginPage.Login(testData.UserName, testData.Password);
        }

        [Then(@"the user should be logged in successfully")]
        public async Task ThenTheUserShouldBeLoggedInSuccessfully()
        {
            string actualTitle = await _productsPage.GetTitle();
            actualTitle.Should().Be("Products");
        }

        [Then(@"the user should not be logged in")]
        public async Task ThenTheUserShouldNotBeLoggedIn()
        {
            var actualErrorMessage = await _loginPage.GetErrorMessage();
            actualErrorMessage.Should().Be("Epic sadface: Sorry, this user has been locked out.");
        }
    }
}
