using SpecFlowOmex.Drivers;
using SpecFlowOmex.Pages.Client.Cardboard;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowOmex.Steps
{
    [Binding]
    public class InitialPublicOfferingsSteps
    {
        private readonly CardboardStationPage cardboardstationpage;
        private readonly NotePage notepage;
        private readonly CardboardClinetPage cardboardClient;

        public InitialPublicOfferingsSteps(BrowserDriver browserDriver)
        {
            cardboardstationpage = new CardboardStationPage(browserDriver.Current);
            notepage = new NotePage(browserDriver.Current);
            cardboardClient = new CardboardClinetPage(browserDriver.Current);
        }
        [Given(@"Initial Public Offerings select (.*)")]
        public void GivenInitialPublicOfferingsSelect(int p0)
        {
            cardboardClient.BuyInitialPublicOfferings();
         }
        
        [When(@"order the Initial Public Offerings stock symbol IRO(.*)BPST(.*) Enter the (.*)imum price plus (.*) and the (.*)imum number plus (.*)  Client")]
        public void WhenOrderTheInitialPublicOfferingsStockSymbolIROBPSTEnterTheImumPricePlusAndTheImumNumberPlusClient(int p0, int p1, string p2, string p3, string p4, string p5)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be")]
        public void ThenTheResultShouldBe()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
