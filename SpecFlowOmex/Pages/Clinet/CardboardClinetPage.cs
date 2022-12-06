using OpenQA.Selenium;
using RestSharp;
using SpecFlowOmex.Support;
using System;
using System.Threading;
using static SpecFlowOmex.API.Model.NumberGetStockSymbol;
using static SpecFlowOmex.API.Model.PirceGetStockSymbol;

namespace SpecFlowOmex.Pages.Client.Cardboard
{
    public class CardboardClinetPage : BasePage
    {
        private readonly IWebDriver driver;

        public CardboardClinetPage(IWebDriver driver) : base(driver)
        {
        }
        //Search
        private readonly By TXTSearchSymbol = By.XPath("//div[@class='ng-input']/input[1]");
        private readonly By Famili = By.CssSelector(".scrollable-content > div:nth-of-type(1) span:nth-of-type(1)");
        // Panel   TextBox
        private readonly By TXTPriceSell = By.XPath("/html/body/app-root/ng-component/c-k-layout/client-sub-layout-main/section[2]/div[2]/div[2]/section[1]/client-page-main-layout-trade/div/client-trade-layout/client-trade-sell/div/div/client-trade-ui-input-price-advance/div/div[1]/label/input");
        private readonly By TXTNumberSell = By.XPath("/html/body/app-root/ng-component/c-k-layout/client-sub-layout-main/section[2]/div[2]/div[2]/section[1]/client-page-main-layout-trade/div/client-trade-layout/client-trade-sell/div/div/client-trade-ui-input-quantity-advance/div/div[1]/label/input");
        private readonly By TXTPrice = By.XPath("/html/body/app-root/ng-component/c-k-layout/client-sub-layout-main/section[2]/div[2]/div[2]/section[1]/client-page-main-layout-trade/div/client-trade-layout/client-trade-buy/div/div/client-trade-ui-input-price-advance/div/div[1]/label/input");
        private readonly By TXTNumber = By.XPath("/html/body/app-root/ng-component/c-k-layout/client-sub-layout-main/section[2]/div[2]/div[2]/section[1]/client-page-main-layout-trade/div/client-trade-layout/client-trade-buy/div/div/client-trade-ui-input-quantity-advance/div/div[1]/label/input");
        private readonly By TXTPirceAverage = By.XPath("//button[@class='e-deActive-icon -is-free -is-ghost -is-quaternary-icon-color -is-round-shape -is-small-icon-size -is-tertiary-hover-icon-color']");
        private readonly By TXTstocketransaction = By.XPath("//input[@id='d']");
        //Icon
        private readonly By Iconstocketransaction = By.CssSelector(".c-toggleComponent");


        //Button
        private readonly By BtnDraft = By.XPath("//span[contains(.,'پیش نویس')]");
        private readonly By BtnBuy = By.CssSelector(".e-buyButton");
        private readonly By BtnLauncher = By.CssSelector("[label='لانچر']");
        private readonly By BtnSell = By.CssSelector(".e-sellButton > .o-c");
        private readonly By BtnEdit = By.CssSelector(".-is-b-t span");
        //Tab Panel
        private readonly By TabSell = By.CssSelector(".-is-sell.e-tab");
        //Profile Meno
        private readonly By MenoProfile = By.XPath("//button[@class='e-serviceBarLink -profile -is-connected']");
        private readonly By MenoDashboard = By.CssSelector("[iconname='dashboard-filled']");
        //Profile-Btn
        private readonly By BtnExit = By.CssSelector(".e-exitButton");
        private readonly By BtnIconNote = By.CssSelector("[iconname='stickynote-outlined'] [width='16']");
        //ListBox Panel type
        private readonly By ListBoxAdvanced = By.XPath("//div[@class='e-dItem u-px-2']");
        private readonly By ListBoxAdvanced1 = By.XPath("//c-k-dropdown-item-regular[contains(.,'پیشرفته')]");
        //Order time
        private readonly By ListBoxValidUntilCancelled = By.XPath("//c-k-dropdown-item-regular[contains(.,'معتبر تا لغو')]");
        private readonly By ListBoxDoAndDelete = By.XPath("//c-k-dropdown-item-regular[contains(.,'انجام و حذف')]");
        private readonly By ListBoxRegistrationTime = By.XPath("//section[@class='-has-topCalendar -has-mediumCalendar']//div[@class='o-dInner']//c-k-dropdown-item-regular[contains(.,'روز')]");
        private readonly By ListBoxValidUntilDate = By.XPath("//c-k-dropdown-item-regular[contains(.,'معتبر تا تاریخ')]");
        private readonly By CalendarIcon = By.CssSelector("[toggletype='calendar']");
        //Message
        private readonly By TXTMessageErrorPriceOutOfrange = By.CssSelector(".u-pl-4 > span:nth-of-type(1)");
        private readonly By TXTMessageErrorNumberOutOfrange = By.CssSelector(".u-pl-4 > span:nth-of-type(2)");
        private readonly By TXTMessage = By.CssSelector(".e-toastMessage");
        private readonly By TXTMessageSuccess = By.CssSelector(".e-toastSuccess .e-toastMessage");
        //InitialPublicOfferings
        private readonly By BtnInitialPublicOfferings = By.XPath("//button[contains(.,'عرضه اولیه کسرا')]");
        private readonly By PriceInitialPublicOfferings = By.XPath("/html/body/app-root/ng-component/c-k-layout/client-sub-layout-main/section[1]/client-sidebar-layout/div/div[2]/client-sidebar-menu/section/div/client-ipo-menu/client-ipo-layout-menu/client-ipo-set-order/div/client-trade-ui-input-price-advance/div/div[1]/label/input");
        private readonly By NumberInitialPublicOfferings = By.XPath("/html/body/app-root/ng-component/c-k-layout/client-sub-layout-main/section[1]/client-sidebar-layout/div/div[2]/client-sidebar-menu/section/div/client-ipo-menu/client-ipo-layout-menu/client-ipo-set-order/div/client-trade-ui-input-quantity-advance/div/div[1]/label/input");
        private readonly By BtnSaveofflineInitialPublicOfferings = By.XPath("//button[@class='-is-b-t -is-l-is -is-l-s']");
        //
        private readonly By TextTheAmountOfCustomerPurchasingPower1 = By.XPath("/html/body/app-root/ng-component/c-k-layout/client-sub-layout-main/section[2]/div[1]/section[3]/client-user-financial-status-bar/div/swiper/div/div[1]/div/div/span[2]");
        private readonly By TextTheAmountOfCustomerPurchasingPower  = By.XPath("/html/body/app-root/ng-component/c-k-layout/client-sub-layout-main/section[2]/div[1]/section[3]/client-user-financial-status-bar/div/swiper/div/div[1]/div/div/span[2]");
        private readonly By TextTheAmountOfCustomerOrderAmount = By.XPath("/html/body/app-root/ng-component/c-k-layout/client-sub-layout-main/section[2]/div[2]/div[2]/section[1]/client-page-main-layout-trade/div/client-trade-layout/client-trade-buy/div/div/div[1]/div[2]/div[2]");


        //


        private readonly By IconEditOrder = By.CssSelector(".o-orderContainer:nth-child(1) .-is-ghost:nth-child(2) > .o-iconComponent");
        private readonly By IconDeleteOrder = By.CssSelector(".o-orderContainer:nth-child(1) .-is-danger-hover-icon-color svg");
        private readonly By Order = By.XPath("//client-orders-instrument-main-current[@class='o-ordersInstrumentCurrentComponent']/section[1]/div[1]//span[@class='e-orderType']");

        private readonly By BtnIconAdd = By.CssSelector("[iconname='add-1-outlined']");
        //Watchlist
        private readonly By BtnWatchlist = By.XPath("//span[.='دیده بان ها']");
        private readonly By TXTWatchlist = By.CssSelector("[placeholder='نام لیست جدید']");
        private readonly By BtnIconAddWatchlist = By.XPath("//button[@class='-is-large -is-null-hover-icon-color -is-null-icon-color -is-null-icon-size -is-primary -is-round-shape']");
        private readonly By BtnIconAddStockSymbolWatchlist = By.CssSelector(".-is-po-t");
        private readonly By TXTSearchAddStockSymbolWatchlist = By.CssSelector("[placeholder='جستجو نام نماد']");
        private readonly By SelectSearchAddStockSymbolWatchlist = By.XPath("//div[@class='ag-body-viewport ag-selectable ag-layout-normal ag-row-no-animation']/div[@name='right']//span[@class='ag-cell-value']");
        private readonly By BtnAddStockSymbolWatchlist = By.XPath("//span[.='ذخیره دیده‌بان']");
        private readonly By TabWatchlist = By.XPath("//button[contains(.,'اتومات')]");
        private readonly By ListItemFirstWatchlist = By.XPath("//client-grid[@class='o-gridComponent -has-leftHoverOperationColumn']//div[@name='center']//div[2]");
        private readonly By DeleteFirstWatchlist = By.XPath("//div[.='حذف']");
        private readonly By IconDeleteWatchlist = By.CssSelector(".cdk-drop-list > li:nth-of-type(5) > div:nth-of-type(1) > button:nth-of-type(1) svg:nth-of-type(1)");
        private readonly By listitemWatchlistAuto = By.XPath("//li[contains(.,'اتومات')]");
        //Note
        private readonly By BtnIconCreatenote = By.CssSelector(".-is-r-is span");
        private readonly By ListboxSearchInNotePanel = By.XPath("/html/body/app-root/ng-component/c-k-layout/client-sub-layout-main/section[1]/client-sidebar-layout/div/div[2]/client-sidebar-menu/section/div[3]/client-note-create-menu/client-note-create-layout-menu/client-notes-create/client-instrument-advanced-search");
        private readonly By SListboxSearchInNotePanel = By.XPath("//input[@type='text']");
        private readonly By CListboxSearchInNotePanel = By.CssSelector(".scrollable-content > div:nth-of-type(1)");
        private readonly By TxtNote = By.CssSelector(".c-textArea");
        private readonly By btnSaveNote = By.CssSelector(".-is-p-t span");
        //BtnInitialPublicOfferings
        public void BuyInitialPublicOfferings()
        {
            Click(BtnInitialPublicOfferings);
            SendKeys(PriceInitialPublicOfferings,"1500");
            SendKeys(NumberInitialPublicOfferings, "2");
            Click(BtnSaveofflineInitialPublicOfferings);
            AlertMassege();
        }
        public void GotoAdvanced()
        {
            Click(ListBoxAdvanced);
            Click(ListBoxAdvanced1);
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
        public void AddNote(string Textnote)
        {
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
        public void GotoPanelProfiestationNote()
        {
            Click(MenoProfile);
            Click(BtnIconNote);
        }
        public void GotoPanelProfieNote()
        {
            Click(MenoProfile);
            Click(BtnIconNote);
        }
        public void GotoWatchlistStockSymbols()
        {
            Thread.Sleep(2000);
            Click(TabWatchlist);
        }
        public void GotoWatchlist()
        {
            Thread.Sleep(2000);
            Click(BtnWatchlist);
        }
        public void DeleteStockSymbol()
        {
            Thread.Sleep(2000);
            RightClickMouse(ListItemFirstWatchlist);

            Click(DeleteFirstWatchlist);
        }
        public void DeleteWatchlist()
        {
            Thread.Sleep(2000);
            Click(listitemWatchlistAuto);
            Click(IconDeleteWatchlist);
        }

        public void AddStockSymbol(String SymbolWatch)
        {
            Click(BtnIconAddStockSymbolWatchlist);
            Click(TXTSearchAddStockSymbolWatchlist);

            SendKeys(TXTSearchAddStockSymbolWatchlist, SymbolWatch);
            Thread.Sleep(2000);
            Click(SelectSearchAddStockSymbolWatchlist);
            Click(BtnAddStockSymbolWatchlist);

        }

        public void AddWatchList(String SymbolWatch)
        {
            Click(BtnWatchlist);
            SendKeys(TXTWatchlist, SymbolWatch);
            /// Thread.Sleep(4000);
            Click(BtnIconAddWatchlist);
        }
        public void SearchSymbolCardboard(String Symbol)
        {
            Click(TXTSearchSymbol);
            SendKeys(TXTSearchSymbol, Symbol);
            Thread.Sleep(4000);
            Click(Famili);
        }
        public void SellStock()
        {
            Click(TXTPrice);
            Click(TXTNumber);
            Click(BtnSell);
            AlertMassege();
        }
        public void StockSymbolPriceSell(string price, int plusprice, string code12stocksymbol)
        {
            RestClient client = new RestClient("https://beta-red.tsetab.com/api/");
            RestRequest request = new RestRequest("PublicMessages/InstTrade?instrumentId=" + code12stocksymbol, Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            var res1 = System.Text.Json.JsonSerializer.Deserialize<RootPirce>(response.Content);
            int PriceMaxPlus = res1.response.data.psGelStaMax + plusprice;
            int PriceMinPlus = res1.response.data.psGelStaMin + plusprice;
            if (price == "min")
            {
                Console.WriteLine(PriceMinPlus);
                SendKeys(TXTPriceSell, PriceMinPlus.ToString());
            }
            else if (price == "max")
            {
                Console.WriteLine(PriceMaxPlus);
                SendKeys(TXTPriceSell, PriceMaxPlus.ToString());
            }
            else
            {
                SendKeys(TXTPriceSell, "0");
            }
        }
        public void StockSymbolNumberSell(string number, int plusnumber, string code12stocksymbol)
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
                SendKeys(TXTNumberSell, NumberMinPlus.ToString());
            }
            else if (number == "max")
            {
                Console.WriteLine(NumberMaxPlus);
                SendKeys(TXTNumberSell, NumberMaxPlus.ToString());
            }
            else
            {
                SendKeys(TXTNumberSell, "0");
            }
        }
        public void StockSymbolPrice(string price, int plusprice, string code12stocksymbol)
        {
            RestClient client = new RestClient("https://beta-red.tsetab.com/api/");
            RestRequest request = new RestRequest("PublicMessages/InstTrade?instrumentId=" + code12stocksymbol, Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            var res1 = System.Text.Json.JsonSerializer.Deserialize<RootPirce>(response.Content);
            int PriceMaxPlus = res1.response.data.psGelStaMax + plusprice;
            int PriceMinPlus = res1.response.data.psGelStaMin + plusprice;
            if (price == "min")
            {
                Console.WriteLine(PriceMinPlus);
                SendKeys(TXTPrice, PriceMinPlus.ToString());
            }
            else if (price == "max")
            {
                Console.WriteLine(PriceMaxPlus);
                SendKeys(TXTPrice, PriceMaxPlus.ToString());
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
        public void SelectTimerange(string timerange)
        {
            Click(ListBoxRegistrationTime);

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
                Click(CalendarIcon);
                DateDayPlus(1);
            }
            else
            {
                Console.WriteLine("Not Select");
            }
        }
        public void CheckmassageerrorOutOfRange(string messageoutofrangeNumber, string messageoutofrangeprice)
        {
            GetElementText(TXTMessageErrorPriceOutOfrange);
            GetElementText(TXTMessageErrorNumberOutOfrange);

            if (messageoutofrangeprice == "قیمت در بازه مجاز نیست")
            {
                AssertTextMassege(TXTMessageErrorPriceOutOfrange, messageoutofrangeprice);

            }
            else if (messageoutofrangeNumber == "تعداد در بازه مجاز نیست")
            {
                AssertTextMassege(TXTMessageErrorNumberOutOfrange, messageoutofrangeNumber);
            }
            else if (messageoutofrangeprice == "قیمت در بازه مجاز نیست" && messageoutofrangeNumber == "تعداد در بازه مجاز نیست")
            {
                AssertTextMassege(TXTMessageErrorPriceOutOfrange, messageoutofrangeprice);
                AssertTextMassege(TXTMessageErrorNumberOutOfrange, messageoutofrangeNumber);
            }
            else
            {
                Console.WriteLine("ok");
            }
        }


        public void SaveEditBuyAnOrder()
        {
            Click(BtnEdit);
            AlertMassege();
        }
        public void SaveEditSellAnOrder()
        {
            Click(BtnSell);
            AlertMassege();
        }
        public void SaveTheOrder()
        {
            Click(BtnBuy);
            AlertMassege();
        }
        public void SaveSellAnOrder()
        {
            Click(BtnSell);
            AlertMassege();
        }
        public void BuyStockAverage()
        {
            Click(TXTPirceAverage);
            SendKeys(TXTNumber, "1");
            Click(BtnBuy);
        }
        public void LauncherStock()
        {
            Click(BtnLauncher);
            AlertMassege();
        }
        public void DraftStock()
        {
            Click(BtnDraft);
            AlertMassege();
        }
        public void SellPanel()
        {
            Click(TabSell);
        }
        public void AssertTheAmountOfCustomerPurchasingPower(string operation)
        {
            if (operation == "Buy")
            {
                CheckPurchasingPower("subtraction", TextTheAmountOfCustomerPurchasingPower, TextTheAmountOfCustomerOrderAmount, BtnBuy, TextTheAmountOfCustomerPurchasingPower1);

            }
            else if (operation == "Sell")
            {
                CheckPurchasingPower("addition", TextTheAmountOfCustomerPurchasingPower, TextTheAmountOfCustomerOrderAmount, BtnSell, TextTheAmountOfCustomerPurchasingPower1);
            }
            else if (operation == "Launcher")
            {
                CheckPurchasingPower("subtraction", TextTheAmountOfCustomerPurchasingPower, TextTheAmountOfCustomerOrderAmount, BtnLauncher, TextTheAmountOfCustomerPurchasingPower1);
            }
        }
        public void stockexchangetransaction(int valueNumber)
        {
            Click(TXTstocketransaction);
            SendKeys(TXTstocketransaction, valueNumber.ToString());
            Click(Iconstocketransaction);

        }
        public void AssertPirceAndNumber(string Text)
        {
            Console.WriteLine("ok");
            GetElementText(TXTMessage);
            AssertTextMassege(TXTMessage, Text);

        }
        public void LogoutUser()
        {
            Click(MenoProfile);
            Click(BtnExit);
        }
        public void AssertPageLoadDashboard()
        {

        }
        public void Deleteorder()
        {
            Click(Order);
            Click(IconDeleteOrder);
          //  AlertMassege();
        }
        public void Editorder(string TypeEdit, string number, int plusnumber, string code12stocksymbol, string price, int plusprice)
        {
            if (TypeEdit == "تعداد")
            {
                Thread.Sleep(500);
                Click(Order);
                Click(IconEditOrder);
                Thread.Sleep(500);
                Clear(TXTNumber);
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
                    Console.WriteLine("NotfuondMax And min");
                }
            }
            else if (TypeEdit == "قیمت")
            {
                Thread.Sleep(500);
                Click(Order);
                Click(IconEditOrder);
                Thread.Sleep(500);
                Clear(TXTPrice);
                RestClient client = new RestClient("https://beta-red.tsetab.com/api/");
                RestRequest request = new RestRequest("PublicMessages/InstTrade?instrumentId=" + code12stocksymbol, Method.GET);
                IRestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
                var res1 = System.Text.Json.JsonSerializer.Deserialize<RootPirce>(response.Content);
                int PriceMaxPlus = res1.response.data.psGelStaMax + plusprice;
                int PriceMinPlus = res1.response.data.psGelStaMin + plusprice;
                if (price == "min")
                {
                    Console.WriteLine(PriceMinPlus);
                    SendKeys(TXTPrice, PriceMinPlus.ToString());
                }
                else if (price == "max")
                {
                    Console.WriteLine(PriceMaxPlus);
                    SendKeys(TXTPrice, PriceMaxPlus.ToString());
                }
                else
                {
                    Console.WriteLine("NotfuondMax And min");
                }

            }
            else
            {
                Console.WriteLine("notfoundType");
            }

        }


        public void AddStockSymbol()
        {
            Click(BtnIconAdd);
        }
        public void DoNotEditorderPrice()
        {

            DisabledButton(IconEditOrder);
        }
        public void CheckmassegeSuccess(string Massege)
        {

            AssertTextMassege(TXTMessageSuccess, Massege);

        }
        //.swiper[_ngcontent-qjh-c78] [data-swiper-slide-index='0'] .e-value
        public void CheckmassegeerrorPriceOutsiderange(string Massege)
        {

            AssertTextMassege(TXTMessageErrorPriceOutOfrange, Massege);
        }
        public void CheckmassegeerrorNumberOutsiderange(string Massege)
        {
            Thread.Sleep(1000);
            AssertTextMassege(TXTMessageErrorNumberOutOfrange, Massege);
        }
        public void CheckmessageDraftSavedSuccessfullytring(string Massege)
        {
            AssertTextMassege(TXTMessage, Massege);
        }
    }
}

