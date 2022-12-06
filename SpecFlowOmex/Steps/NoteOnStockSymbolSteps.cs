using SpecFlowOmex.Drivers;
using SpecFlowOmex.Pages.Admin;
using SpecFlowOmex.Pages.Client.Cardboard;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowOmex.Steps
{
    [Binding]
    public class NoteOnStockSymbolSteps
    {
        private readonly CardboardStationPage cardboardstationpage;
        private readonly NotePage notepage;
        private readonly CardboardClinetPage cardboardClient;

        public NoteOnStockSymbolSteps(BrowserDriver browserDriver)
        {
            cardboardstationpage = new CardboardStationPage(browserDriver.Current);
            notepage = new NotePage(browserDriver.Current);
            cardboardClient = new CardboardClinetPage(browserDriver.Current);
        }
        [Given(@"Go to the profile panel station")]
        public void GivenGoToTheProfilePanelStation()
        {
            cardboardstationpage.ClickMenoNote();
        }

        [Given(@"Go to the profile panel")]
        public void GivenGoToTheProfilePanel()
        {
            cardboardClient.GotoPanelProfieNote();
        }
        
        [Given(@"Click Icon sticky note")]
        public void GivenClickIconStickyNote()
        {
            notepage.ClickCreateNote();
        }
        [When(@"We edit a note station on stock symbol (.*) with text (.*)")]
        public void WhenWeEditANoteStationOnStockSymbolWithText(string search,string text)
        {
            notepage.SearchPanelstocksymbolnoteStation(search);
            notepage.GotoEditPanelstocksymbolnoteS();
            notepage.EditstocksymbolnoteS(text);
        }

        [When(@"We create a note station on stock symbol (.*) with text (.*)")]
        public void WhenWeCreateANoteStationOnStockSymbolWithText(string symbol,string text)
        {
            notepage.SearchingPanelstocksymbolnoteStation(symbol);
            notepage.Createnotestation(text);


        }
        [When(@"we create a note on stock symbol (.*) with text (.*) And Status (.*)")]
        public void WhenWeCreateANoteOnStockSymbolخساپاWithTextAndStatus(string symbol, string text, string status)
        {
            notepage.Searchingstocksymbolnote(symbol);
            notepage.AddNote(text, status);
        }

        //[When(@"We create a note on stock symbol (.*) with text (.*) And Status (.*)")]
        //public void WhenWeCreateANoteOnStockSymbolWithText(string symbol, string text)
        //{
            
        //    notepage.Searchingstocksymbolnote(symbol);
        //    notepage.AddNote(text,"انجام شده");
        //}
        
        [Then(@"Show stock symbol notes (.*)")]
        public void ThenShowStockSymbolNotes(string massege)
        {
            cardboardClient.CheckmassegeSuccess(massege);
            notepage.ClickDashboard();
        }
        [When(@"We edit a note on stock symbol (.*) with text (.*)")]
        public void WhenWeEditANoteOnStockSymbolWithText(string symbol, string text)
        {
            notepage.SearchingPanelstocksymbolnote(symbol);
            notepage.GotoEditPanelstocksymbolnote();
            notepage.EditNote(text);

        }
        [When(@"We Delete a note station on stock symbol (.*)")]
        public void WhenWeDeleteANoteStationOnStockSymbol(string search)
        {
            notepage.SearchPanelstocksymbolnoteStation(search);
            notepage.Deletestocksymbolnotestation();
        }
        [Then(@"Delete stock symbol notes station")]
        public void ThenDeleteStockSymbolNotesStation()
        {
          //  notepage.ClickDashboard();
        }

        [When(@"We Delete a note on stock symbol (.*)")]
        public void WhenWeDeleteANoteOnStockSymbol(string symbol)
        {
            notepage.SearchingPanelstocksymbolnote(symbol);
            notepage.ClickIconDelete();

        }
        [Then(@"Delete stock symbol notes")]
        public void ThenDeleteStockSymbolNotes()
        {
            notepage.ClickDashboardStation();
        }
        [Then(@"Show stock symbol station notes (.*)")]
        public void ThenShowStockSymbolStationNotes(string text)
        {
            cardboardClient.CheckmassegeSuccess(text);
        }


        [Given(@"Select the status of the note (.*)")]
        public void GivenSelectTheStatusOfTheNote(string Status)
        {
            notepage.SelectstatusNote(Status);
        }

    }
}
