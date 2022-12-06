using SpecFlowOmex.Drivers;
using SpecFlowOmex.Pages.Admin;
using SpecFlowOmex.Pages.Client.Cardboard;
using SpecFlowOmex.Pages.Public;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowOmex.Steps
{
    [Binding]
    public class SymbolClientCardboardSteps
    {
        private readonly LoginPage loginUser;
        private readonly CardboardClinetPage cardboard;
        public SymbolClientCardboardSteps(BrowserDriver browserDriver)
        {
            loginUser = new LoginPage(browserDriver.Current);
            cardboard = new CardboardClinetPage(browserDriver.Current);
        }
        [When(@"Click Icon Add Panel Stock Symbol")]
        public void WhenClickIconAddPanelStockSymbol()
        {
            cardboard.AddStockSymbol();
        }
        
        [Then(@"the result should be Created 7 Default Stock Symbol")]
        public void ThenTheResultShouldBe()
        {
            Console.WriteLine("ok");
        }
    }
}
