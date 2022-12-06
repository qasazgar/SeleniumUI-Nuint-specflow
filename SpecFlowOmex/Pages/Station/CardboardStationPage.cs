using OpenQA.Selenium;
using RestSharp;
using SpecFlowOmex.Support;
using System;
using System.Threading;
using static SpecFlowOmex.API.Model.NumberGetStockSymbol;
using static SpecFlowOmex.API.Model.PirceGetStockSymbol;

namespace SpecFlowOmex.Pages.Client.Cardboard
{
    public class CardboardStationPage : BasePage
    {
        private readonly IWebDriver driver;

        public CardboardStationPage(IWebDriver driver) : base(driver)
        {
        }
        //Search
        private readonly By TXTSearchSymbol = By.CssSelector(".-has-truncateInParenthesisResult .c-placeHolder");
        private readonly By SelectFirstItem = By.XPath("(//input[@name='searchInstrument'])[3]");
        private readonly By CListboxSearchItem = By.CssSelector("td:nth-of-type(1)");
        //SelectCustomer
        private readonly By TXTSearchCustomer = By.XPath("//div[@class='c-searchOResult -has-actionBar -has-moreInfoBtnRight -has-refreshBtn -has-truncatePrimaryResult -is-stateIconSad -is-closeWithOutResult']//div[@class='o-inside']//span[@class='e-label']");
        private readonly By SelectFirstItemCustomer = By.Name("searchPrincipal");
        //textbox
        private readonly By TXTPrice = By.Id("tPInput");
        private readonly By TXTNumber = By.XPath("/html/body/app-root/div/div/div/app-trading-page/div/div[2]/div[2]/app-trade-panel/div[2]/app-trade-panel-tab/div/div/div[2]/app-trade-panel-tab-trade/div/div/app-trade/form/div[1]/div[1]/app-trade-ui-input-quantity/div[1]/input");
        //Buy
        private readonly By btnSaveBuy = By.CssSelector(".-tradeFormBuy");
        //Drft
        private readonly By btnSaveDrft = By.CssSelector(".-predefined");
        //Launcher
        private readonly By btnSaveLauncher = By.CssSelector(".-launcher");
        //Sell 
        private readonly By btnSaveSell = By.CssSelector(".-tradeFormSell");
        //Tab Panel
        private readonly By TabSell = By.XPath("//label[.='فـروش']");
        //Profile
        private readonly By MenoProfile = By.XPath(".o-profileWrapper");
        private readonly By MenoDashboard = By.CssSelector(".e-userIcon");
        private readonly By MenoNote = By.XPath("//span[.='یادداشت ها']");
        //Profile-Btn
        private readonly By BtnExit = By.CssSelector(".e-exitButton");

        //ListBox Panel type
        private readonly By ListBoxAdvanced = By.XPath("//div[@class='e-dItem u-px-2']");
        private readonly By ListBoxAdvanced1 = By.XPath("//c-k-dropdown-item-regular[contains(.,'پیشرفته')]");
        //Order time
        private readonly By ListBoxValidUntilCancelled = By.XPath("//span[.='معتبر تا لغو']");
        private readonly By ListBoxDoAndDelete = By.XPath("//span[.='انجام و حذف']");
        private readonly By ListBoxRegistrationTime = By.CssSelector("[aria-selected='true'][role='option'] .e-label");
        private readonly By Listboxrangetime = By.CssSelector("[bindlabel='translate']");
        private readonly By ListBoxValidUntilDate = By.XPath("//span[.='معتبر تا تاریخ']");
        public void TabSellStation()
        {

            Click(TabSell);
        }
        public void ClickMenoNote()
        {

            Click(MenoDashboard);
            Click(MenoNote);
        }
        public void LogoutUserStation()
        {
            Click(MenoProfile);
            Click(BtnExit);
        }
        public void SearchstocksymbolTrader(string search)
        {
            Click(TXTSearchSymbol);
            SendKeys(SelectFirstItem, search);
            Thread.Sleep(1500);
            Click(CListboxSearchItem);
        }
        public void SearchCustomerStation(string search)
        {
            Click(TXTSearchCustomer);
            SendKeys(SelectFirstItemCustomer, search);
            Thread.Sleep(1500);
            Click(CListboxSearchItem);
        }
        public void StockSymbolPrice(string price, int plus, string code12stocksymbol)
        {
            RestClient client = new RestClient("https://beta-red.tsetab.com/api/");
            RestRequest request = new RestRequest("PublicMessages/InstTrade?instrumentId=" + code12stocksymbol, Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            var res1 = System.Text.Json.JsonSerializer.Deserialize<RootPirce>(response.Content);
            int PirceMinPlus = res1.response.data.psGelStaMin + plus;
            int PirceMaxPlus = res1.response.data.psGelStaMax + plus;
            if (price == "min")
            {
                Console.WriteLine(PirceMinPlus);
                Click(TXTPrice);
                SendKeys(TXTPrice, PirceMinPlus.ToString());
            }
            else if (price == "max")
            {
                Console.WriteLine(PirceMaxPlus);
                SendKeys(TXTPrice, PirceMaxPlus.ToString());
            }
            else
            {
                SendKeys(TXTPrice, "0");
            }
        }
        public void StockSymbolNumber(string number, int plusnumber, string code12stocksymbol)
        {
            RestClient clientnumber = new RestClient("https://beta-red.tsetab.com/api/");
            RestRequest requestnumber = new RestRequest("PublicMessages/Instrument?instrumentId=" + code12stocksymbol, Method.GET);
            IRestResponse responsenumber = clientnumber.Execute(requestnumber);
            Console.WriteLine(responsenumber.Content);
            var res2 = System.Text.Json.JsonSerializer.Deserialize<RootNumber>(responsenumber.Content);
            int NumberMinPlus = res2.response.data.qTitMinSaiOmProd + plusnumber;
            int NumberMaxPlus = res2.response.data.qTitMaxSaiOmProd + plusnumber;
            if (number == "min")
            {
                Console.WriteLine(NumberMinPlus);
                SendKeys(TXTNumber, NumberMinPlus.ToString());

            }
            else if (number == "max")
            {
                Console.WriteLine(NumberMaxPlus);
                SendKeys(TXTNumber, NumberMaxPlus.ToString());
            }
            else
            {
                SendKeys(TXTNumber, "0");

            }
        }
        public void Buyorder()
        {

            Click(btnSaveBuy);
            // AlertMassege();
        }
        public void Drftorder()
        {
            Click(btnSaveDrft);
            //    AlertMassege();
        }
        public void Launcherorder()
        {
            Click(btnSaveLauncher);
            //     AlertMassege();
        }
        public void Sellorder()
        {
            Click(btnSaveSell);
            //     AlertMassege();
        }
        public void SelectTimerange(string timerange)
        {
            Click(Listboxrangetime);

            if (timerange == "روز")
            {
                Click(ListBoxRegistrationTime);

            }
            else if (timerange == "انجام و حذف")
            {
                Click(ListBoxDoAndDelete);
            }
            else if (timerange == "معتبر تا لغو")
            {
                Click(ListBoxValidUntilCancelled);
            }
            else if (timerange == "معتبر تا تاریخ")
            {
                Click(ListBoxValidUntilDate);
                Thread.Sleep(2000);
                DateDayPlus(1);
            }
            else
            {
                Console.WriteLine("Not Select");
            }

        }
    }





    //Console.WriteLine(res1.response.data.psGelStaMin);
    //Console.WriteLine(pirceMinplus);
    //Console.WriteLine(PirceMinPlus);
    //SendKeys(TXTPrice, PirceMinPlus.ToString());
}

//TXTSearchSymbol



//MenoDashboard


//[iconname='dashboard-filled']
//MenoDashboard
//.-is-p-t span

//public void ClickDashboard()
//{

//    Click(MenoDashboard);
//}

//public void EditNote(string Textnote)
//{
//    Clear(TxtNote);
//    SendKeys(TxtNote, Textnote);
//    Click(btnSaveNote);
//}
//public void AddNote(string Textnote)
//{
//    SendKeys(TxtNote, Textnote);
//    Click(btnSaveNote);
//}
//public void Searchingstocksymbolnote(string search)
//{
//    Click(ListboxSearchInNotePanel);
//    SendKeys(SListboxSearchInNotePanel, search);
//    Click(CListboxSearchInNotePanel);
//}

//public void ClickCreateNote()
//{
//    Click(BtnIconCreatenote);
//}

//public void GotoPanelProfieNote()
//{
//    Click(MenoProfile);
//    Click(BtnIconNote);
//}
//public void GotoWatchlistStockSymbols()
//{
//    Thread.Sleep(2000);
//    Click(TabWatchlist);
//}
//public void GotoWatchlist()
//{
//    Thread.Sleep(2000);
//    Click(BtnWatchlist);
//}
//public void DeleteStockSymbol()
//{
//    Thread.Sleep(2000);
//    RightClickMouse(ListItemFirstWatchlist);

//    Click(DeleteFirstWatchlist);
//}
//public void DeleteWatchlist()
//{
//    Thread.Sleep(2000);
//    Click(listitemWatchlistAuto);
//    Click(IconDeleteWatchlist);
//}

//public void AddStockSymbol(String SymbolWatch)
//{
//    Click(BtnIconAddStockSymbolWatchlist);
//    Click(TXTSearchAddStockSymbolWatchlist);

//    SendKeys(TXTSearchAddStockSymbolWatchlist, SymbolWatch);
//     Thread.Sleep(2000);
//    Click(SelectSearchAddStockSymbolWatchlist);
//    Click(BtnAddStockSymbolWatchlist);

//}

//public void AddWatchList(String SymbolWatch)
//{
//    Click(BtnWatchlist);
//    SendKeys(TXTWatchlist, SymbolWatch);
//   /// Thread.Sleep(4000);
//    Click(BtnIconAddWatchlist);
//}
//public void SearchSymbolCardboard(String Symbol)
//{
//    Click(TXTSearchSymbol);
//    SendKeys(TXTSearchSymbol, Symbol);
//    Thread.Sleep(4000);
//    Click(Famili);
//}
//public void SellStock()
//{
//    Click(TXTPirce);
//    Click(TXTNumber);     
//    Click(BtnSell);
//    AlertMassege();
//}
//public void StockPriceMin(int pirceMinplus, string code12stocksymbol)
//{
//    RestClient client = new RestClient("https://beta-red.tsetab.com/api/");
//    RestRequest request = new RestRequest("PublicMessages/InstTrade?instrumentId="+code12stocksymbol, Method.GET);
//    IRestResponse response = client.Execute(request);
//    Console.WriteLine(response.Content);
//    var res1 = System.Text.Json.JsonSerializer.Deserialize<RootPirce>(response.Content);
//    Console.WriteLine(res1.response.data.psGelStaMin);
//    Console.WriteLine(pirceMinplus);
//    int PirceMinPlus = res1.response.data.psGelStaMin + pirceMinplus;
//    Console.WriteLine(PirceMinPlus);
//    SendKeys(TXTPirce, PirceMinPlus.ToString());
//}
//public void StockNumberMin( int numberMinplus, string code12stocksymbol)
//{
//    RestClient clientnumber = new RestClient("https://beta-red.tsetab.com/api/");
//    RestRequest requestnumber = new RestRequest("PublicMessages/Instrument?instrumentId=" + code12stocksymbol, Method.GET);
//    IRestResponse responsenumber = clientnumber.Execute(requestnumber);
//    Console.WriteLine(responsenumber.Content);
//    var res2 = System.Text.Json.JsonSerializer.Deserialize<RootNumber>(responsenumber.Content);
//    int NumberMinPlus = res2.response.data.qTitMinSaiOmProd + numberMinplus;
//    Console.WriteLine(numberMinplus);
//     SendKeys(TXTNumber, NumberMinPlus.ToString());

//}
//public void StockPriceMax(int pirceMaxplus, string code12stocksymbol)
//{
//    RestClient client = new RestClient("https://beta-red.tsetab.com/api/");
//    RestRequest request = new RestRequest("PublicMessages/InstTrade?instrumentId=" + code12stocksymbol, Method.GET);
//    IRestResponse response = client.Execute(request);
//    Console.WriteLine(response.Content);
//    var res1 = System.Text.Json.JsonSerializer.Deserialize<RootPirce>(response.Content);
//    Console.WriteLine(res1.response.data.psGelStaMax);
//    Console.WriteLine(pirceMaxplus);
//    int PirceMaxPlus = res1.response.data.psGelStaMax + pirceMaxplus;
//    Console.WriteLine(PirceMaxPlus);
//    SendKeys(TXTPirce, PirceMaxPlus.ToString());
//}
//public void StockNumberMax(int numberMaxplus, string code12stocksymbol)
//{
//    RestClient clientnumber = new RestClient("https://beta-red.tsetab.com/api/");
//    RestRequest requestnumber = new RestRequest("PublicMessages/Instrument?instrumentId=" + code12stocksymbol, Method.GET);
//    IRestResponse responsenumber = clientnumber.Execute(requestnumber);
//    Console.WriteLine(responsenumber.Content);
//    var res2 = System.Text.Json.JsonSerializer.Deserialize<RootNumber>(responsenumber.Content);
//    int NumberMaxPlus = res2.response.data.qTitMaxSaiOmProd + numberMaxplus;
//    Console.WriteLine(numberMaxplus);
//    SendKeys(TXTNumber, NumberMaxPlus.ToString());       
//}
//public void SaveTheOrder()
//{
//    Click(BtnBuy);
//    AlertMassege();
//}
//public void SaveSellAnOrder()
//{
//    Click(BtnSell);
//    AlertMassege();
//}
//public void BuyStock( )
//{
//    Click(TXTPirceAverage);
//    SendKeys(TXTNumber, "1");
//    Click(BtnBuy);
//    AlertMassege();
//}
//public void LauncherStock()
//{
//    Click(BtnLauncher);
//    AlertMassege();
//}
//public void DraftStock()
//{

//    Click(BtnDraft);
//    AlertMassege();
//}

//public void InTheMoment()
//{
//    Click(ListBoxAdvanced);
//    Click(ListBoxAdvanced1);
//    Click(ListBoxRegistrationTime);
//    Click(ListBoxDoAndDelete);
//}
//public void ValidUntilCancelled()
//{
//    Click(ListBoxAdvanced);
//    Click(ListBoxAdvanced1);
//    Click(ListBoxRegistrationTime);
//    Click(ListBoxValidUntilCancelled);
//}
//public void ValidUntilDate()
//{
//    Click(ListBoxAdvanced);
//    Click(ListBoxAdvanced1);
//    Click(ListBoxRegistrationTime);
//    Click(ListBoxValidUntilDate);
//    Click(CalendarIcon);            
//}
//public void SellPanel()
//{
//    Click(TabSell);

//}
//public void AssertPirceAndNumber(string Text)
//{
//    Console.WriteLine("ok");
//    GetElementText(TXTMessage);
//    AssertTextMassege(TXTMessage, Text);
//   // GetElementText(AssertNumber);
//   // AssertTextMassege()
//}

//public void AssertPageLoadDashboard()
//{

//}
//public void Deleteorder()
//{
//    Click(DeleteOrder1);
//    Click(IconDeleteOrder);
//    AlertMassege();
//}
//public void EditorderNumber()
//{
//    Thread.Sleep(500);
//    Click(DeleteOrder1);
//    Click(IconEditOrder);
//    Thread.Sleep(500);
//    Click(IconIncreaseNumber);
//    Click(BtnEdit);            
//    AlertMassege();
//}
//public void EditorderPrice()
//{
//    Thread.Sleep(500);
//    Click(DeleteOrder1);
//    Click(IconEditOrder);
//    Thread.Sleep(1500);
//    Click(IconDecreasePrice);
//    Click(BtnEdit);
//    AlertMassege();
//}
//public void AddStockSymbol()
//{
//    Click(BtnIconAdd);
//}
//public void DoNotEditorderPrice()
//{

//    DisabledButton(IconEditOrder);

//}
//public void CheckmassegeSuccess(string Massege)
//{

//    AssertTextMassege(TXTMessageSuccess, Massege);

//}
//public void CheckmassegeerrorPriceOutsiderange(string Massege)
//{

//    AssertTextMassege(TXTMessageErrorPriceOutOfrange, Massege);
//}
//public void CheckmassegeerrorNumberOutsiderange(string Massege)
//{
//    Thread.Sleep(1000);
//    AssertTextMassege(TXTMessageErrorNumberOutOfrange, Massege);
//}
//public void CheckmessageDraftSavedSuccessfullytring(string Massege)
//{
//    AssertTextMassege(TXTMessage, Massege);
//}}


