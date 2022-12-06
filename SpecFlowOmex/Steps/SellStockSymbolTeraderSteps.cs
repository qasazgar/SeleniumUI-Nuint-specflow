using SpecFlowOmex.Drivers;
using SpecFlowOmex.Pages.Client.Cardboard;
using SpecFlowOmex.Pages.Public;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowOmex.Steps
{
    [Binding]
    public class SellStockSymbolTeraderSteps
    {
        private readonly LoginPage loginUser;
        private readonly CardboardStationPage cardboard;
        [Given(@"Go to tab Sell Station")]
        public void GivenGoToTabSellStation()
        {
            cardboard.TabSellStation();
        }

        public SellStockSymbolTeraderSteps(BrowserDriver browserDriver)
        {
            loginUser = new LoginPage(browserDriver.Current);
            cardboard = new CardboardStationPage(browserDriver.Current);
        }
        [When(@"Save stock symbol Sell order Trader information")]
        public void WhenSaveStockSymbolSellOrderTraderInformation()
        {
            cardboard.Sellorder();
        }        
        [Then(@"the result should Sell shares of the Stock symbol")]
        public void ThenTheResultShouldSellSharesOfTheStockSymbol()
        {
            Console.WriteLine("OK");
        }
    }
}
