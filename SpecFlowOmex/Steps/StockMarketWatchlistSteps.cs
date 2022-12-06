using SpecFlowOmex.Drivers;
using SpecFlowOmex.Pages.Client.Cardboard;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowOmex.Steps
{
    [Binding]
    public class StockMarketWatchlistSteps
    {
        private readonly CardboardClinetPage cardboard;
        public StockMarketWatchlistSteps(BrowserDriver browserDriver)
        {
            cardboard = new CardboardClinetPage(browserDriver.Current);
        }
        [Given(@"Create a watch list with the name (.*)")]
        public void GivenCreateAWatchListWithTheName(string p0)
        {
            cardboard.AddWatchList(p0);
        }
        [When(@"Add stock symbol to watch list (.*)")]
        public void WhenAddStockSymbolToWatchList(string p0)
        {
            cardboard.AddStockSymbol(p0);
        } 
        [Then(@"The result should be a stock symbol is added to the new watch list")]
        public void ThenTheResultShouldBeAStockSymbolIsAddedToTheNewWatchList()
        {
            Console.WriteLine("The result should be a stock symbol is added to the new watch list");
        }
        [Given(@"Go to a watch list with the name اتومات")]
        public void GivenGoToAWatchListWithTheName()
        {
            cardboard.GotoWatchlistStockSymbols();
        }

        [When(@"Delete stock symbol to watch list")]
        public void WhenDeleteStockSymbolToWatchList()
        {
            cardboard.DeleteStockSymbol();
        }

        [Then(@"The result should be a stock symbol is Deleted to the new watch list")]
        public void ThenTheResultShouldBeAStockSymbolIsDeletedToTheNewWatchList()
        {
            Console.WriteLine("The result should be a stock symbol is Deleted to the new watch list");
        }
        [Given(@"Go to a watch list")]
        public void GivenGoToAWatchList()
        {
            cardboard.GotoWatchlist();
        }

        [When(@"Delete  watch list")]
        public void WhenDeleteWatchList()
        {
            cardboard.DeleteWatchlist();
        }

        [Then(@"The result should be  Deleted to the new watch list")]
        public void ThenTheResultShouldBeDeletedToTheNewWatchList()
        {
            Console.WriteLine("ok");
        }

    }
}
