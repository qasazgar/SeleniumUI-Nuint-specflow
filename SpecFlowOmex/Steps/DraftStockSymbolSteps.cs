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
    public class DraftStockSymbolSteps
    {
        private readonly LoginPage loginUser;
        private readonly CardboardClinetPage cardboard;
        public DraftStockSymbolSteps(BrowserDriver browserDriver)
        {
            loginUser = new LoginPage(browserDriver.Current);
            cardboard = new CardboardClinetPage(browserDriver.Current);
        }
        [When(@"Save stock symbol Draft order Customer information")]
        public void WhenSaveStockSymbolDraftOrderCustomerInformation()
        {
            cardboard.DraftStock();
        }
        [Given(@"order Sell the stock symbol (.*) Enter the (.*)imum price plus (.*) and the (.*)imum number plus (.*)  Client")]
        public void GivenOrderSellTheStockSymbolIROBPSTEnterTheMinimumPricePlusAndTheMinimumNumberPlusClient(string code12stocksymbol, string price, int plusprice, string number,int plusnumber)
        {
            cardboard.StockSymbolPriceSell(price,plusprice,code12stocksymbol);
            cardboard.StockSymbolNumberSell(number, plusnumber, code12stocksymbol);
        }

        [Then(@"the result should Draft Buy shares of the Stock symbol by the Customer")]
        public void ThenTheResultShouldDraftBuySharesOfTheStockSymbol()
        {
            cardboard.CheckmassegeSuccess("پیشنویس با موفقیت ثبت شد");
        }
        [Then(@"The result Should be Drft Stock Symbol")]
        public void ThenTheResultShouldBeDrftStockSymbol()
        {
            cardboard.CheckmessageDraftSavedSuccessfullytring("پیشنویس با موفقیت ثبت شد");
        }
    }
}
