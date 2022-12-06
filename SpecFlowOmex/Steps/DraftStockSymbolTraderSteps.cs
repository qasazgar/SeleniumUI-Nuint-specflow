using SpecFlowOmex.Drivers;
using SpecFlowOmex.Pages;
using SpecFlowOmex.Pages.Client.Cardboard;
using SpecFlowOmex.Pages.Public;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowOmex.Steps
{
    [Binding]
    public class DraftStockSymbolTraderSteps
    {
        private readonly LoginPage loginUser;
        private readonly CardboardStationPage cardboard;
        public DraftStockSymbolTraderSteps(BrowserDriver browserDriver)
        {
            loginUser = new LoginPage(browserDriver.Current);
            cardboard = new CardboardStationPage(browserDriver.Current);
        }

        [When(@"Save stock symbol Draft order Trader information")]
        public void WhenSaveStockSymbolDraftOrderTraderInformation()
        {
            cardboard.Drftorder();
        }
        [Then(@"the result should Draft Buy shares of the Stock symbol")]
        public void ThenTheResultShouldDraftBuySharesOfTheStockSymbol()
        {
            Thread.Sleep(5000);
            Console.WriteLine("ok");
        }

        [Then(@"the result should Draft Sell shares of the Stock symbol")]
        public void ThenTheResultShouldDraftSellSharesOfTheStockSymbol()
        {

            Thread.Sleep(5000);
            Console.WriteLine("ok");
        }

    }
}
