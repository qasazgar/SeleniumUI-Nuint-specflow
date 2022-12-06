using SpecFlowOmex.Drivers;
using SpecFlowOmex.Pages.Admin;
using SpecFlowOmex.Pages.Client.Cardboard;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowOmex.Steps
{
    [Binding]
    public class LimitationsStockSymbolSteps
    {
        private readonly LimitationsAdminPage LimitationsAdmin;
        private readonly CardboardAdminPage cardboardadmin;
        private readonly CardboardClinetPage cardboardClient;

        public LimitationsStockSymbolSteps(BrowserDriver browserDriver)
        {
            LimitationsAdmin = new LimitationsAdminPage(browserDriver.Current);
            cardboardadmin = new CardboardAdminPage(browserDriver.Current);
            cardboardClient = new CardboardClinetPage(browserDriver.Current);
        }
        [Given(@"Go to Menu limitations And Click Create limitation")]
        public void GivenGoToMenuLimitationsAndClickCreateLimitation()
        {
            cardboardadmin.GoToLimitations();
            LimitationsAdmin.BottunAddLimitation();
        }
        [Given(@"Create New limitations Enter Title (.*) And Symbol (.*) And Massage Farsi (.*)  And Active Stock symbol")]
        public void GivenCreateNewLimitationsEnterTitleAndSymbolAndMassageFarsiAndActiveStockSymbol(string p0, string p1, string p2)
        {
            LimitationsAdmin.AddLimitations(p0, p1, p2);

        }
        public void WhenActiveLimitationsItHasTransactionOrderWithIt()
        {
            LimitationsAdmin.LimitationsItHasTransactionOrderWithIt();
            LimitationsAdmin.ClickButtonSavelimitation();
            LimitationsAdmin.ActiveLimitation();
        }

        [Then(@"the result should Create New Limitation And Active Stock Symbol")]
        public void ThenTheResultShouldCreateNewLimitationAndActiveStockSymbol()
        {
            Console.WriteLine("ok");
        }

        [When(@"The restriction should be applied from date (.*) to date (.*) on the stock symbol")]
        public void WhenTheRestrictionShouldBeAppliedFromDateToDateOnTheStockSymbol(int from, int to)
        {
            LimitationsAdmin.TextCalendarFrom(from);
            LimitationsAdmin.TextCalendarTo(to);
            LimitationsAdmin.ClickButtonSavelimitation();
            LimitationsAdmin.CloseFromlimitation();
            LimitationsAdmin.ActiveLimitation();
        }
        [Then(@"the result should be time limit for advertising the stock symbol")]
        public void ThenTheResultShouldBeTimeLimitForAdvertisingTheStockSymbol()
        {
            Console.WriteLine("ok");
        }

       
        [Given(@"The restriction should be applied from date (.*) to date (.*) on the stock symbol.")]
        public void GivenTheRestrictionShouldBeAppliedFromDateToDateOnTheStockSymbol_(int from, int to)
        {
            LimitationsAdmin.TextCalendarFrom(from);
            LimitationsAdmin.TextCalendarTo(to);
        }
        [When(@"Delete limitations First one Item")]
        public void WhenDeleteLimitationsFirstOneItem()
        {
            LimitationsAdmin.LimitationDelete();
        }
        [Then(@"the result should be  delete")]
        public void ThenTheResultShouldBeDelete()
        {
            Console.WriteLine("ok");
        }
        [Given(@"Go to Menu limitations")]
        public void GivenGoToMenuLimitations()
        {
            cardboardadmin.GoToLimitations();
        }
        [Given(@"Edit Item  limitations")]
        public void GivenEditItemLimitations()
        {
            LimitationsAdmin.LimitationEdit();
        }

        [When(@"Go to Menu limitations And Click Edit limitation insert Time from (.*) to (.*)")]
        public void WhenGoToMenuLimitationsAndClickEditLimitationInsertTimeFromTo(int From, int To)
        {
            LimitationsAdmin.AddTimefrom(From);
            LimitationsAdmin.AddTimeTo(To);
            LimitationsAdmin.ClickButtonSavelimitation();
            LimitationsAdmin.CloseFromlimitation();
            LimitationsAdmin.ActiveLimitation();


        }
        [Then(@"The result Should be insert Time")]
        public void ThenTheResultShouldBeInsertTime()
        {
            Console.WriteLine("ok");
        }

        [When(@"Go to Menu limitations And Click Edit limitation insert Number from (.*) to (.*)")]
        public void WhenGoToMenuLimitationsAndClickEditLimitationInsertNumberFromTo(int from, int to)
        {
            LimitationsAdmin.AddNumber(from,to);
            LimitationsAdmin.ClickButtonSavelimitation();
        }

        [When(@"Go to Menu limitations And Click Edit limitation insert Price from (.*) to (.*)")]
        public void WhenGoToMenuLimitationsAndClickEditLimitationInsertPriceFromTo(int from, int to)
        {

            LimitationsAdmin.AddPrice(from, to);
            LimitationsAdmin.ClickButtonSavelimitation();
            LimitationsAdmin.CloseFromlimitation();
            LimitationsAdmin.ActiveLimitation();
        }
        [When(@"Go to Menu limitations And Click Edit limitation insert Customer Name (.*)")]
        public void WhenGoToMenuLimitationsAndClickEditLimitationInsertCustomerName(string searchcustmername)
        {
            LimitationsAdmin.AddCustomer(searchcustmername);
            LimitationsAdmin.ClickButtonSavelimitation();
            LimitationsAdmin.CloseFromlimitation();
            LimitationsAdmin.ActiveLimitation();
        }
        [When(@"Go to Menu limitations And Click Edit limitation insert Industy Name (.*)")]
        public void WhenGoToMenuLimitationsAndClickEditLimitationInsertIndustyName(string searchindustryname)
        {
            LimitationsAdmin.AddIndustry(searchindustryname);
            LimitationsAdmin.ClickButtonSavelimitation();
            LimitationsAdmin.CloseFromlimitation();
            LimitationsAdmin.ActiveLimitation();
        }
        [When(@"Go to Menu limitations And Click Edit limitation insert Market Type (.*)")]
        public void WhenGoToMenuLimitationsAndClickEditLimitationInsertMarketType(string searchmarkettype)
        {
            LimitationsAdmin.AddtMarketType(searchmarkettype);
            LimitationsAdmin.ClickButtonSavelimitation();
            LimitationsAdmin.CloseFromlimitation();
            LimitationsAdmin.ActiveLimitation();
        }
        [When(@"Go to Menu limitations And Click Edit limitation insert TransactionType (.*)")]
        public void WhenGoToMenuLimitationsAndClickEditLimitationInsertTransactionType(string searchtransactiontype)
        {
            LimitationsAdmin.AddTransactionType(searchtransactiontype);
            LimitationsAdmin.ClickButtonSavelimitation();
            LimitationsAdmin.CloseFromlimitation();
            LimitationsAdmin.ActiveLimitation();
        }
        [When(@"Go to Menu limitations And Click Edit limitation insert Transaction Manager (.*)")]
        public void WhenGoToMenuLimitationsAndClickEditLimitationInsertTransactionManager(string searchtransactionmanager)
        {
            LimitationsAdmin.AddTransactionManager(searchtransactionmanager);
            LimitationsAdmin.ClickButtonSavelimitation();
            LimitationsAdmin.CloseFromlimitation();
            LimitationsAdmin.ActiveLimitation();
        }
        [When(@"Go to Menu limitations And Click Edit limitation insert Transactional Action (.*)")]
        public void WhenGoToMenuLimitationsAndClickEditLimitationInsertTransactionalAction(string searchtransactionalaction)
        {
            LimitationsAdmin.AddTransactionalAction(searchtransactionalaction);
            LimitationsAdmin.ClickButtonSavelimitation();
            LimitationsAdmin.CloseFromlimitation();
            LimitationsAdmin.ActiveLimitation();
        }
        [Given(@"Search and unselect the value (.*) in the constraint edit")]
        public void GivenSearchAndUnselectTheValueInTheConstraintEdit(string searchtransactionalaction)
        {
            LimitationsAdmin.Editlimitlist(searchtransactionalaction);
            LimitationsAdmin.ClickButtonSavelimitation();

        }

        [When(@"Search and select the value (.*) in the constraint edit")]
        public void WhenSearchAndSelectTheValueInTheConstraintEdit(string searchtransactionalaction)
        {
            LimitationsAdmin.LimitationEdit();
            LimitationsAdmin.Editlimitlist(searchtransactionalaction);
            LimitationsAdmin.ClickButtonSavelimitation();
        }

        [When(@"Select the (.*) value in the  Time Validity Type search box")]
        public void WhenSelectTheValueInTheSearchBox(string searchtimevaliditytype)
        {
            LimitationsAdmin.AddTimeValidityType(searchtimevaliditytype);
            LimitationsAdmin.ClickButtonSavelimitation();
            LimitationsAdmin.CloseFromlimitation();
            LimitationsAdmin.ActiveLimitation();
        }
        [When(@"Stock market value limit between (.*) and (.*)")]
        public void WhenStockMarketValueLimitBetweenAnd(int from, int to)
        {
            LimitationsAdmin.AddStockMarketValue(from,to);
            LimitationsAdmin.ClickButtonSavelimitation();
            LimitationsAdmin.CloseFromlimitation();
            LimitationsAdmin.ActiveLimitation();
        }

    }
}
