using SpecFlowOmex.Drivers;
using SpecFlowOmex.Pages.Client.Cardboard;
using SpecFlowOmex.Pages.Public;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowOmex.Steps
{
    [Binding]
    public class LauncherStockSymbolTeraderSteps
    {
        private readonly LoginPage loginUser;
        private readonly CardboardStationPage cardboard;
        public LauncherStockSymbolTeraderSteps(BrowserDriver browserDriver)
        {
            loginUser = new LoginPage(browserDriver.Current);
            cardboard = new CardboardStationPage(browserDriver.Current);
        }
        [When(@"Save stock symbol Launcher order Trader information")]
        public void WhenSaveStockSymbolLauncherOrderTraderInformation()
        {
            cardboard.Launcherorder();
        }
        
        [Then(@"the result should Launcher shares of the Stock symbol")]
        public void ThenTheResultShouldLauncherSharesOfTheStockSymbol()
        {
            Console.WriteLine("ok");
            Thread.Sleep(2000);
        }
    }
}
