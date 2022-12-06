using SpecFlowOmex.Drivers;
using SpecFlowOmex.Pages.Client.Cardboard;
using SpecFlowOmex.Pages.Public;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowOmex.Steps.PublicSteps
{
    [Binding]
    public class PublicStockSymbolClientSteps
    {
        private readonly LoginPage loginUser;
        private readonly CardboardClinetPage cardboardclinet;
        public PublicStockSymbolClientSteps(BrowserDriver browserDriver)
        {
            loginUser = new LoginPage(browserDriver.Current);
            cardboardclinet = new CardboardClinetPage(browserDriver.Current);
        }
        [Given("LoginUser Customer With Username (.*) And Password (.*)")]
        public void GivenLoginUserCustomerWithUsernameAndPassword(string username, string password)
        {
            loginUser.LoginUser(username, password);
            loginUser.AssertCardboardClinet();
        }
        [Given(@"Search Stock Symbol Client  (.*)")]
        public void GivenSearchStockSymbolClient(string Symbol)
        {
            cardboardclinet.SearchSymbolCardboard(Symbol);
        }

        [Given(@"order the stock symbol (.*) Enter the (.*)imum price plus (.*) and the (.*)imum number plus (.*)  Client")]
        public void GivenOrderTheStockSymbolEnterTheImumPricePlusAndTheImumNumberPlusClient(string code12stocksymbol, string price, int Plusprice, string number, int Plusnumber)
        {
            cardboardclinet.StockSymbolNumber(number, Plusnumber, code12stocksymbol);
            cardboardclinet.StockSymbolPrice(price, Plusprice, code12stocksymbol);
        }
        [Given(@"Select Advanced panel type")]
        public void GivenSelectAdvancedPanelType()
        {
            cardboardclinet.GotoAdvanced();
        }
        [Given(@"Select Time range type Cleint (.*)")]
        public void GivenSelectTimeRangeTypeCleint(string timerange)
        {
            cardboardclinet.SelectTimerange(timerange);
        }
        [When(@"Error message (.*) And (.*)is displayed")]
        public void WhenErrorMessageAndIsDisplayed(string messageoutofrangeNumber, string messageoutofrangeprice)
        {
            cardboardclinet.CheckmassageerrorOutOfRange(messageoutofrangeNumber, messageoutofrangeprice);
        }
        [When(@"Get text And Assert And Save stock symbol (.*) order Customer information")]
        public void WhenGetTextAndAssertAndSaveStockSymbolSellOrderCustomerInformation(string operation)
        {
            cardboardclinet.AssertTheAmountOfCustomerPurchasingPower(operation);
        }
        [Then(@"The result is that the customer must Sell the shares of the stock symbol And Show massage (.*)")]
        public void ThenTheResultIsThatTheCustomerMustSellTheSharesOfTheStockSymbolAndShowMassage(string textmassage)
        {
            cardboardclinet.CheckmassegeSuccess(textmassage);
        }
    }
}
