using SpecFlowOmex.Drivers;
using SpecFlowOmex.Pages;
using SpecFlowOmex.Pages.Client.Cardboard;
using SpecFlowOmex.Pages.Public;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowOmex.Steps
{
    [Binding]
    public class LauncherStockSymbolSteps
    {
        private readonly LoginPage loginUser;
        private readonly CardboardClinetPage cardboard;
        public LauncherStockSymbolSteps(BrowserDriver browserDriver)
        {
            loginUser = new LoginPage(browserDriver.Current);
            cardboard = new CardboardClinetPage(browserDriver.Current);
        }
        [When(@"Save stock symbol Launcher order Customer information")]
        public void WhenSavestocksymbolLauncherorderCustomerinformation()
        {
            cardboard.LauncherStock();
        }
        [Then(@"the result should Launcher Buy shares of the Stock symbol by the Customer")]
        public void ThenTheResultShouldBeLauncherStockSymbol()
        {
            cardboard.CheckmassegeSuccess("لانچر با موفقیت ثبت شد");
        }

    }
}
