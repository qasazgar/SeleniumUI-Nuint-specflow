using OpenQA.Selenium;
using SpecFlowOmex.Support;
using System;

namespace SpecFlowOmex.Pages.Client.Cardboard
{
    public class NotePage : BasePage
    {
        private readonly IWebDriver driver;

        public NotePage(IWebDriver driver) : base(driver)
        {
        }
        private readonly By MenoDashboardStation = By.CssSelector("[href='#/'][_ngcontent-rqg-c23] > [_ngcontent-rqg-c23]");

        private readonly By MenoDashboard = By.CssSelector("[iconname='dashboard-filled']");
        //Note
        private readonly By BtnIconCreatenote = By.XPath("//span[.='افزودن یادداشت جدید']");
        private readonly By ListboxSearchInNotePanel = By.XPath("/html/body/app-root/ng-component/c-k-layout/client-sub-layout-main/section[1]/client-sidebar-layout/div/div[2]/client-sidebar-menu/section/div[3]/client-note-create-menu/client-note-create-layout-menu/client-notes-create/client-instrument-advanced-search");
        private readonly By SListboxSearchInNotePanel = By.XPath("//input[@type='text']");
        private readonly By CListboxSearchInNotePanel = By.CssSelector(".scrollable-content > div:nth-of-type(1)");
        private readonly By TxtNote = By.CssSelector(".c-textArea");
        private readonly By btnSaveNote = By.CssSelector(".-is-p-t span");
        private readonly By IconSearchInNotePanel = By.CssSelector("[iconname='search-2-outlined']");
        private readonly By TxtSearchInNotePanel = By.CssSelector("[placeholder='جستجو یادداشت']");
        private readonly By btnIconEditNotePanel = By.XPath("//mat-panel-title[@class='mat-expansion-panel-header-title o-titleElement ng-tns-c245-1 -is-todo']//button[@class='-is-free -is-ghost -is-quaternary-icon-color -is-round-shape -is-small-icon-size -is-tertiary-hover-icon-color']");
        private readonly By btnIconDeletetNotePanel = By.XPath("//mat-panel-title[@class='mat-expansion-panel-header-title o-titleElement ng-tns-c245-1 -is-todo']//button[@class='u-ml-1 -is-danger-hover-icon-color -is-free -is-ghost -is-quaternary-icon-color -is-round-shape -is-small-icon-size']/c-k-icon[@class='o-iconComponent ng-star-inserted']");


        private readonly By ListboxSearchInNotePanelS = By.XPath("/html/body/app-root/div/app-sidebar-layout/main/section/app-sidebar-menu/section/div[3]/app-note-create-menu/app-note-create-layout-menu/app-notes-create/div[1]/app-common-search-box/div/div/div/div/input");
        private readonly By CListboxSearchInNotePanelS = By.CssSelector(".c-instrumentSearchResultTable > tbody > tr:nth-of-type(1)");
        private readonly By BtnSaveNotePanelS = By.CssSelector(".c-button[loadericontype = 'clip']");
        private readonly By IconSearchInNotePanelS = By.CssSelector(".c-searchIcon > [width='16']");
        private readonly By btnIconEditNotePanelS = By.XPath("/html/body/app-root/div/app-sidebar-layout/main/section/app-sidebar-menu/section/div[2]/app-notes-list-menu/app-notes-list-layout-menu/div[1]/app-notes-list/div[2]/mat-accordion/app-notes-list-note[1]/mat-expansion-panel/mat-expansion-panel-header/span/mat-panel-title/div[2]/div/div/button[2]");
        private readonly By btnEditSaveNoteS = By.CssSelector(".c-button[loadericontype='clip']");
        private readonly By btnIconDeletetNotePanelS = By.XPath("/html/body/app-root/div/app-sidebar-layout/main/section/app-sidebar-menu/section/div[2]/app-notes-list-menu/app-notes-list-layout-menu/div[1]/app-notes-list/div[2]/mat-accordion/app-notes-list-note[1]/mat-expansion-panel/mat-expansion-panel-header/span/mat-panel-title/div[2]/div/div/button[1]");

        private readonly By ListstatusNoteAwaitingaction = By.CssSelector("c-k-dropdown-item-regular-icon:nth-of-type(1) > .e-dItem");
        private readonly By ListstatusNotedoing = By.CssSelector("c-k-dropdown-item-regular-icon:nth-of-type(2) > .e-dItem");
        private readonly By ListstatusNotedone = By.CssSelector("c-k-dropdown-item-regular-icon:nth-of-type(3) > .e-dItem");

        public void Deletestocksymbolnotestation()
        {
            Click(btnIconDeletetNotePanelS);
        }
        public void EditstocksymbolnoteS(string Textnote)
        {
            Clear(TxtNote);
            SendKeys(TxtNote, Textnote);
            Click(btnEditSaveNoteS);
        }
        public void GotoEditPanelstocksymbolnoteS()
        {
            Click(btnIconEditNotePanelS);
        }
        public void SearchPanelstocksymbolnoteStation(string search)
        {
            Click(IconSearchInNotePanelS);
            SendKeys(TxtSearchInNotePanel, search);
            Click(By.XPath("//span[.='" + search + "']"));
        }
        public void SearchingPanelstocksymbolnoteStation(string search)
        {
            Click(ListboxSearchInNotePanelS);
            SendKeys(ListboxSearchInNotePanelS, search);
            Click(CListboxSearchInNotePanelS);
        }

        public void Createnotestation(string textnote)
        {
            SendKeys(TxtNote, textnote);
            Click(BtnSaveNotePanelS);
     
        }
        public void ClickIconDelete()
        {
            Click(btnIconDeletetNotePanel);
        }
        public void ClickDashboardStation()
        {
            Click(MenoDashboardStation);
        }
        public void ClickDashboard()
        {
            Click(MenoDashboard);
        }
        public void EditNote(string Textnote)
        {
            Clear(TxtNote);
            SendKeys(TxtNote, Textnote);
            Click(btnSaveNote);
        }
        public void AddNote(string Textnote,string status)
        {
            Click(ListstatusNoteAwaitingaction);

            if (status == "در حال اقدام")
            {
                Click(ListstatusNoteAwaitingaction);
            }
            else if (status == "در حال انجام")
            {
                Click(ListstatusNotedoing);
            }
            else if (status == "انجام شده")
            {
                Click(ListstatusNotedone);
            }
            else
            {
                Console.WriteLine("Not find");
            }
            SendKeys(TxtNote, Textnote);
            Click(btnSaveNote);
        }
        public void Searchingstocksymbolnote(string search)
        {
            Click(ListboxSearchInNotePanel);
            SendKeys(SListboxSearchInNotePanel, search);
            Click(CListboxSearchInNotePanel);
        }
        public void ClickCreateNote()
        {
            Click(BtnIconCreatenote);
        }

        public void SearchingPanelstocksymbolnote(string search)
        {
            Click(IconSearchInNotePanel);
            SendKeys(TxtSearchInNotePanel, search);
            Click(By.XPath("//span[.='" + search + "']"));
        }
        public void GotoEditPanelstocksymbolnote()
        {
            Click(btnIconEditNotePanel);
        }
        public void SelectstatusNote(string status)
        {
            if (status == "انجام شده")
            {
                Click(ListstatusNoteAwaitingaction);
            }
            else if(status == "در حال انجام")
            {
                Click(ListstatusNotedoing);
            }
            else if (status == "انجام شده")
            {
                Click(ListstatusNotedone);
            }
            else
            {
                Console.WriteLine("Not find");
            }

        }
    }
}

