using SpecFlowOmex.Drivers;
using SpecFlowOmex.Pages.Client.Cardboard;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowOmex.Steps
{
    [Binding]
    public class BuyStockSymbolTraderSteps
    {
        private readonly CardboardStationPage cardboardstationpage;
        private readonly NotePage notepage;
        private readonly CardboardClinetPage cardboardClient;

        public BuyStockSymbolTraderSteps(BrowserDriver browserDriver)
        {
            cardboardstationpage = new CardboardStationPage(browserDriver.Current);
            notepage = new NotePage(browserDriver.Current);
            cardboardClient = new CardboardClinetPage(browserDriver.Current);
        }
        [Given(@"Order the stock symbol (.*) Enter the (.*)imum price plus (.*) and the (.*)imum number plus (.*)")]
        public void GivenOrderTheStockSymbolEnterTheImumPricePlusAndTheImumNumberPlus(string code12stocksymbol, string price, int plus, string number, int plusNumber)
        {
            cardboardstationpage.StockSymbolNumber(number, plusNumber, code12stocksymbol);
            cardboardstationpage.StockSymbolPrice(price, plus, code12stocksymbol);
        }
        [Given(@"select Time range type (.*)")]
        public void GivenSelectTimeRangeType(string timerange)
        {
            cardboardstationpage.SelectTimerange(timerange);
        }
        [When(@"Save stock symbol Buy order Trader information")]
        public void WhenSaveStockSymbolBuyOrderTraderInformation()
        {
            cardboardstationpage.Buyorder();
        }
        [Then(@"the result should Buy shares of the Stock symbol")]
        public void ThenTheResultShouldBuySharesOfTheStockSymbol()
        {
            Console.WriteLine("OK");
        }
    }
}
