using SpecFlowOmex.Drivers;
using SpecFlowOmex.Pages;
using SpecFlowOmex.Pages.Client.Cardboard;
using SpecFlowOmex.Pages.Public;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowOmex.Steps
{
    [Binding]
    public class SellStockSymbolSteps
    {
        private readonly LoginPage loginUser;
        private readonly CardboardClinetPage cardboard;
        public SellStockSymbolSteps(BrowserDriver browserDriver)
        {
            loginUser = new LoginPage(browserDriver.Current);
            cardboard = new CardboardClinetPage(browserDriver.Current);
        }

        [When(@"Save stock symbol Sell order Customer information")]
        public void WhenSaveStockSymbolSellOrderInformation()
        {
            cardboard.SaveSellAnOrder();
        }
        [Given(@"Go to tab Sell")]
        public void GivenGoToTabSell()
        {
            cardboard.SellPanel();
        }

        [Then(@"the result should Sell shares of the symbol")]
        public void ThenTheResultShouldSellSharesOfTheSymbol()
        {
            cardboard.CheckmassegeSuccess("سفارش با موفقیت ثبت شد");
        }

        [Then(@"The result is that the customer must Sell the shares of the stock symbol And Show massage (.*)")]
        public void ThenTheResultIsThatTheCustomerMustSellTheSharesOfTheStockSymbolAndShowMassage(string textmassage)
        {
            cardboard.CheckmassegeSuccess(textmassage);
        }



        [Then(@"the result should Delete Sell shares of the symbol And Show Massage")]
        public void ThenTheResultShouldDeleteSellSharesOfTheSymbolAndShowMassage()
        {
            cardboard.CheckmassegeSuccess("سفارش شما حذف شد.");
        }
        [Then(@"the result should Edit Sell shares of the symbol And Show Massage (.*)")]
        public void ThenTheResultShouldSellSharesOfTheSymbolAndShowMassage(string textMassage)
        {


            cardboard.CheckmassegeSuccess(textMassage);

         //   cardboard.CheckmassegeSuccess("ویرایش سفارش با موفقیت ثبت شد");
        }
     
    }
}



























        //[When(@"The minimum price plus (.*) and the number plus (.*) are used to Sell stock symbol (.*)")]
        //public void WhenTheMinimumPricePlusAndTheNumberPlusAreUsedTosellStockSymbol(int pirceminplus, int numberminplus, string codestocksymbol)
        //{
        //    cardboard.StockPriceMin(pirceminplus, codestocksymbol);
        //    cardboard.StockNumberMin(numberminplus, codestocksymbol);
        //    cardboard.SaveSellAnOrder();

//}
//[When(@"Maximum price plus (.*) and number plus (.*) are given to Sell stock symbol (.*) and error out of price range")]
//public void WhenMaximumPricePlusAndNumberPlusAreGivenTosellStockSymbolAndErrorOutOfPriceRange(int pircemaxplus, int numbermaxplus, string codestocksymbol)
//{
//    cardboard.StockPriceMax(pircemaxplus, codestocksymbol);
//    cardboard.StockNumberMin(numbermaxplus, codestocksymbol);
//}
//[When(@"Maximum price plus (.*) and number plus (.*) are given to Sell stock symbol (.*) and error out of number range")]
//public void WhenMaximumPricePlusAndNumberPlusAreGivenToSellStockSymbolIROSIPAAndErrorOutOfNumberRange(int pircemaxplus, int numbermaxplus, string codestocksymbol)
//{

//    cardboard.StockNumberMax(numbermaxplus, codestocksymbol);
//    cardboard.StockPriceMax(pircemaxplus, codestocksymbol);

//}

//[When(@"Maximum price plus (.*) and number plus (.*) are given to Sell stock symbol (.*) and error out of number And Price range")]
//public void WhenMaximumPricePlusAndNumberPlusAreGivenToSellStockSymbolIROSIPAAndErrorOutOfNumberAndPriceRange(int pircemaxplus, int numbermaxplus, string codestocksymbol)
//{
//    cardboard.StockNumberMin(numbermaxplus, codestocksymbol);
//    cardboard.StockPriceMin(pircemaxplus, codestocksymbol);
//}

//[When(@"The maximum price plus (.*) and the number plus (.*) are used to Sell stock symbol (.*)")]
//public void WhenTheMaximumPricePlusAndTheNumberPlusAreUsedToSellStockSymbolIROSIPA(int pircemaxplus, int numbermaxplus, string codestocksymbol)
//{
//    cardboard.StockPriceMax(pircemaxplus, codestocksymbol);
//    cardboard.StockNumberMax(numbermaxplus, codestocksymbol);
//    cardboard.SaveSellAnOrder();
//}
//[Given(@"The maximum price plus (.*) and the number plus (.*) are used to Sell stock symbol (.*)")]
//public void GivenTheMaximumPricePlusAndTheNumberPlusAreUsedToSellStockSymbolIROSIPA(int pircemaxplus, int numbermaxplus, string codestocksymbol)
//{
//    cardboard.StockPriceMax(pircemaxplus, codestocksymbol);
//    cardboard.StockNumberMax(numbermaxplus, codestocksymbol);
//    cardboard.SaveSellAnOrder();
//}

//[Then(@"The result should Sell shares of the symbol")]
//public void ThenTheResultShouldSellSharesOfTheSymbol()
//{
//    cardboard.CheckmassegeSuccess("سفارش با موفقیت ثبت شد");
//}



//[When(@"Sell shares of the symbol in the Moment")]
//public void WhenSellSharesOfTheSymbolInTheMoment()
//{
//    cardboard.InTheMoment();
//    cardboard.SellStock();
//}

//[When(@"Sell shares of the symbol Valid until order cancellation")]
//public void WhenSellSharesOfTheSymbolValidUntilOrderCancellation()
//{
//    cardboard.ValidUntilCancelled();
//    cardboard.SellStock();

//}

//[When(@"Sell Stock Symbol Valid Until Date")]
//public void WhenSellStockSymbolValidUntilDate()
//{
//    cardboard.ValidUntilDate();
//    cardboard.DateDayPlus(1);
//    cardboard.SellStock();
//}


//}
//}
