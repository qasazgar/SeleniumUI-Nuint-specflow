using SpecFlowOmex.Drivers;
using SpecFlowOmex.Pages.Client.Cardboard;
using SpecFlowOmex.Pages.Public;
using TechTalk.SpecFlow;

namespace SpecFlowOmex.Steps.PublicSteps
{
    [Binding]
    public class PublicStockSymbolTraderSteps
    {
        private readonly LoginPage loginUser;
        private readonly CardboardStationPage cardboardStation;
        public PublicStockSymbolTraderSteps(BrowserDriver browserDriver)
        {
            loginUser = new LoginPage(browserDriver.Current);
            cardboardStation = new CardboardStationPage(browserDriver.Current);
        }
        [Given(@"LoginUser Trader With Username (.*) And Password (.*)")]
        public void GivenLoginUserTraderWithUsernameTesttraderAndPasswordP(string username, string password)
        {
            loginUser.LoginUser(username, password);
            loginUser.AssertCardboardStation();
        }
        [Given(@"Search Stock Symbol  (.*)")]
        public void GivenSearchStockSymbol(string search)
        {
            cardboardStation.SearchstocksymbolTrader(search);
        }
        [Given(@"Search And Select Customer name (.*)")]
        public void GivenSearchAndSelectCustomerName(string name)
        {
            cardboardStation.SearchCustomerStation(name);
        }
        [Given(@"Order the stock symbol (.*) Enter the (.*)imum price plus (.*) and the (.*)imum number plus (.*)")]
        public void GivenOrderTheStockSymbolEnterTheImumPricePlusAndTheImumNumberPlus(string code12stocksymbol, string price, int plus, string number, int plusNumber)
        {
            cardboardStation.StockSymbolNumber(number, plusNumber, code12stocksymbol);
            cardboardStation.StockSymbolPrice(price, plus, code12stocksymbol);
        }
    }
}
