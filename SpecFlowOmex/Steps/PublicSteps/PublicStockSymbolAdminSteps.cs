using SpecFlowOmex.Drivers;
using SpecFlowOmex.Pages;
using SpecFlowOmex.Pages.Client.Cardboard;
using SpecFlowOmex.Pages.Public;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowOmex.Steps.PublicSteps
{
    [Binding]
    public class PublicStockSymbolAdminSteps
    {
        private readonly LoginPage loginUser;
        private readonly CardboardClinetPage cardboard;
        public PublicStockSymbolAdminSteps(BrowserDriver browserDriver)
        {
            loginUser = new LoginPage(browserDriver.Current);
            cardboard = new CardboardClinetPage(browserDriver.Current);
        }
        [Given(@"LoginUser Admin With Username (.*) And Password (.*)")]
        public void GivenLoginUserAdminWithUsernameAdministratorAndPasswordAdministratorIFS(string username, string password)
        {
            loginUser.LoginUser(username, password);
            loginUser.AssertCardboardAdmin();
        }
    }
}
