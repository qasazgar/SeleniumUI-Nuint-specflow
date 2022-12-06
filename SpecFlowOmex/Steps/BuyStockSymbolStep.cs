using SpecFlowOmex.API;
using SpecFlowOmex.Drivers;
using SpecFlowOmex.Pages.Client.Cardboard;
using SpecFlowOmex.Pages.Public;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowOmex.Steps
{
    [Binding]
    public sealed class BuyStockSymbolStep
    {
        private readonly LoginPage loginUser;
        private readonly CardboardClinetPage cardboard;
        public BuyStockSymbolStep(BrowserDriver browserDriver)
        {
            loginUser = new LoginPage(browserDriver.Current);
            cardboard = new CardboardClinetPage(browserDriver.Current);
        }
        [When(@"Delete order Bought shares of the symbol")]
        public void WhenDeleteOrderBoughtSharesOfTheSymbol()
        {
            cardboard.Deleteorder();
        }
        //[When(@"Get text And Assert And Save stock symbol (.*) order Customer information")]
        //public void WhenGetTextAndAssertAndSaveStockSymbolBuyOrderCustomerInformation(string operation)
        //{
        //    cardboard.AssertTheAmountOfCustomerPurchasingPower(operation);
        //}

        [When(@"Save stock symbol Buy order Customer information")]
        public void WhenSaveStockSymbolBuyOrderCustomerInformation()
        {
            
            cardboard.SaveTheOrder();
        }
        [Given(@"Select the average price value")]
        public void GivenSelectTheAveragePriceValue()
        {
            cardboard.BuyStockAverage();
         }

        [Given(@"Save stock symbol Buy order Customer information")]
        public void AndSaveStockSymbolBuyOrderCustomerInformation()
        {
            cardboard.SaveTheOrder();
        }

        [When(@"Save stock symbol Buy order information")]
        public void WhenSaveStockSymbolBuyOrderInformation()
        {
            cardboard.SaveTheOrder();
        }

        [When(@"Buy shares of the symbol in the Moment")]
        public void WhenBuySharesOfTheSymbolInTheMoment()
        {
           // cardboard.InTheMoment();
        }
        [When(@"Buy shares of the symbol Valid until order cancellation")]
        public void WhenBuySharesOfTheSymbolValidUntilOrderCancellation()
        {
           // cardboard.ValidUntilCancelled();
        }

        [Then(@"the result should Buy shares of the symbol Message (.*)")]
        public void ThenTheResultShouldBuySharesOfTheSymbolMessage(string text)
        {
            cardboard.AssertPirceAndNumber(text);
        }

        [Given(@"A share of stock symbol  (.*)  is bought")]
        public void GivenAShareOfStockSymbolIsBought(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        [When(@"Edit buy stock symbol on the day")]
        public void WhenEditBuyStockSymbolOnTheDay()
        {
            cardboard.DoNotEditorderPrice();
        }

        [Given(@"Editing (.*) order the stock symbol (.*) Enter the (.*)imum price plus (.*) and the (.*)imum number plus (.*)  Client")]
        public void GivenOrderTheStockSymbolEnterTheImumPricePlusAndTheImumNumberPlusClient(string typeedit, string code12stocksymbol, string price, int Plusprice, string number, int Plusnumber)
        {
            cardboard.Editorder(typeedit, number, Plusnumber,code12stocksymbol, price, Plusprice);

        }
        [When(@"Edit order Bought shares of the symbol")]
        public void WhenEditOrderBoughtSharesOfTheSymbol()
        {
            cardboard.SaveEditBuyAnOrder();
        }
        [Then(@"the result should Delete Buy shares of the symbol And Show Massage")]
        public void ThenTheResultShouldDeleteBuySharesOfTheSymbolAndShowMassage()
        {
            cardboard.CheckmassegeSuccess("سفارش شما حذف شد.");
        }
        [Then(@"the result should Edit Buy shares of the symbol And Show Massage")]
        public void ThenTheResultShouldBuySharesOfTheSymbolAndShowMassage()
        {
            cardboard.CheckmassegeSuccess("ویرایش سفارش با موفقیت ثبت شد");
        }
        [Then(@"The result is that the customer must buy the shares of the stock symbol And Show massage (.*)")]
        public void ThenTheResultIsThatTheCustomerMustBuyTheSharesOfTheStockSymbolAndShowmassage(string textMassege)
        {
            cardboard.CheckmassegeSuccess(textMassege);
           // cardboard.CheckmassegeSuccess("سفارش با موفقیت ثبت شد");
        }

        [Then(@"the result should Buy shares of the symbol")]
        public void ThenTheResultShouldBuySharesOfTheSymbol()
        {
            cardboard.CheckmassegeSuccess("سفارش با موفقیت ثبت شد");
        }
        [Then(@"the result should Error message The price is not in the allowed range")]

        public void ThenTheResultShouldErrormessageThepriceisnotintheallowedrange()
        {
            cardboard.CheckmassegeerrorPriceOutsiderange("قیمت در بازه مجاز نیست");
        }
        [Then(@"the result should Error message The number is not in the allowed range")]
        public void ThenTheResultShouldErrorMessageTheNumberIsNotInTheAllowedRange()
        {
            cardboard.CheckmassegeerrorNumberOutsiderange("تعداد در بازه مجاز نیست");
        }

        [Then(@"the result should Error message The number And Price is not in the allowed range")]
        public void ThenTheResultShouldErrorMessageTheNumberAndPriceIsNotInTheAllowedRange()
        {
            cardboard.CheckmassegeerrorNumberOutsiderange("تعداد در بازه مجاز نیست");
            cardboard.CheckmassegeerrorPriceOutsiderange("قیمت در بازه مجاز نیست");

        }
        [Given(@"Enter the value of the stock exchange transaction (.*)")]
        public void GivenEnterTheValueOfTheStockExchangeTransaction(int number)
        {
            cardboard.stockexchangetransaction(number);
        }

        [Given(@"order the stock symbol (.*) Enter the (.*)imum price plus (.*) Client")]
        public void GivenOrderTheStockSymbolIROBPSTEnterTheMinimumPricePlusClient( string code12stocksymbol, string price, int Plusprice)
        {
            cardboard.StockSymbolPrice(price, Plusprice, code12stocksymbol);

        }

    }
}
