using Microsoft.VisualBasic;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SpecFlowOmex.API;
using SpecFlowOmex.Support;
using System;
using System.Globalization;
using System.Threading;

namespace SpecFlowOmex.Pages.Admin
{
    public class LimitationsAdminPage : BasePage
    {
        private readonly IWebDriver driver;

        public LimitationsAdminPage(IWebDriver driver) : base(driver)
        {
        }

        private readonly By ScrollPanel = By.XPath("//operation-panel-wrapper/div/div");

        //Search
        private readonly By BtnAddLimitation = By.CssSelector(".ant-btn-primary > span");
        //Add Limitations
        private readonly By TXTTitleLimitation = By.CssSelector("[novalidate] > app-dynamic-form-item:nth-of-type(1) input:nth-of-type(1)");

        private readonly By TXTSymoblStock = By.Name("InstrumentLimitation");
        private readonly By STXTSymoblStock = By.CssSelector(".multi-select-instrument .ant-select-selection-search-input");
        private readonly By CTXTSymoblStock = By.XPath("/html/body/div/div/div/nz-option-container/div/cdk-virtual-scroll-viewport/div[1]/nz-option-item[1]");


        private readonly By TXTMaseegeFarsi = By.CssSelector("app-dynamic-form-item:nth-of-type(6) [placeholder]");
        private readonly By BtnSaveLimitation = By.CssSelector("[nztype='primary']");
        private readonly By RadioBtnItHasTransactionOrderWithIt = By.CssSelector("app-dynamic-form-item:nth-of-type(8) .ant-switch");

        private readonly By BtnClose = By.XPath("//i[@class='anticon close-icon cursor-pointer anticon-close']");
        private readonly By BtnActive = By.XPath("/html/body/app-root/div/div/main/app-limitations/entity-wrapper/div/div[1]/entity-grid-client-side/app-grid/ag-grid-angular/div/div[2]/div[2]/div[3]/div[2]/div/div/div[1]/div[7]/div/span/app-grid-operations-rendrer/div/a[4]/span[1]");
        private readonly By BtnMassegeActiveYes = By.CssSelector(".ant-btn-dangerous");


        private readonly By TXTCalendarFrom = By.CssSelector("[placeholder='از تاریخ']");
        private readonly By TXTCalendarTo = By.CssSelector("[placeholder='تا تاریخ']");

        private readonly By DeletefirstItem = By.XPath("/html/body/app-root/div/div/main/app-limitations/entity-wrapper/div/div[1]/entity-grid-client-side/app-grid/ag-grid-angular/div/div[2]/div[2]/div[3]/div[2]/div/div/div[1]/div[7]/div/span/app-grid-operations-rendrer/div/a[5]/span");
        private readonly By btnlistEditLimitation = By.XPath("/html/body/app-root/div/div/main/app-limitations/entity-wrapper/div/div[1]/entity-grid-client-side/app-grid/ag-grid-angular/div/div[2]/div[2]/div[3]/div[2]/div/div/div[1]/div[7]/div/span/app-grid-operations-rendrer/div/a[3]/span[1]");

        private readonly By TimeFrom = By.CssSelector("[placeholder='تا ساعت']");
        private readonly By TimeTo = By.CssSelector("[placeholder='از ساعت']");
        //NumberOfStockExchange
        private readonly By NumberOfStockExchangeFrom = By.XPath("//f-input-number/div/nz-input-group/input");
        private readonly By NumberOfStockExchangeTo = By.XPath("//div[3]/app-dynamic-form-item/div/f-input-number/div/nz-input-group/input");

        //PriceOfStockExchange
        private readonly By PriceOfStockExchangeFrom = By.XPath("//f-input-currency/div/nz-input-group/input");
        private readonly By PriceOfStockExchangeTo = By.XPath("//div[3]/app-dynamic-form-item/div/f-input-currency/div/nz-input-group/input");

        //select Customer
        private readonly By SearchTXTCustomer = By.CssSelector("[name='CustomerLimitation'] .ant-select-selection-search-input");
        private readonly By SelectCustomer = By.CssSelector("[name='CustomerLimitation'] .ant-select-selection-search-input");

        //Select Industry
        private readonly By SearchTXTIndustry = By.XPath("//app-dynamic-layout-item[4]/div/div/app-dynamic-form-item/div/f-template/div/client-side-multi-select/div/nz-select/nz-select-top-control/nz-select-search/input");
        private readonly By SelectIndustry = By.CssSelector(".ant-select-item-option-content");
        //Market type
        private readonly By SearchTXTMarketType = By.CssSelector("[name='FlowLimitation'] .ant-select-selection-search-input");
        private readonly By SelectMarketType = By.CssSelector(".ant-select-item-option-active > .ant-select-item-option-content");
        //Transaction type
        private readonly By SearchTXTTransactionType = By.CssSelector("[name='OrderSideLimitation'] .ant-select-selection-search-input");
        private readonly By SelectTransactionType = By.CssSelector(".ant-select-item-option-content");
        //Transaction manager
        private readonly By SearchTXTTransactionManager = By.CssSelector("[name='ExecutorTypeLimitation'] .ant-select-selection-search-input");
        private readonly By SelectTransactionManager = By.CssSelector(".ant-select-item-option-content");
        //Transactional action
        private readonly By SearchTXTTransactionalAction = By.CssSelector("[name='FunctionalityLimitation'] .ant-select-selection-search-input");
        private readonly By SelectTransactionalAction = By.XPath("//div[@class='ant-select-item-option-content']");
        //TimeValidityType
        private readonly By SearchTXTTimeValidityType = By.CssSelector("[name='ValidityTypeLimitation'] .ant-select-selection-search-input");
        private readonly By SelectTimeValidityType = By.CssSelector(".ant-select-item-option-content");
        //Stock market value limit
        private readonly By TXTStockMarketValueMin = By.CssSelector("app-dynamic-layout-item:nth-of-type(12) [placeholder='از ']");
        private readonly By TXTStockMarketValueMax = By.CssSelector("app-dynamic-layout-item:nth-of-type(12) [placeholder='تا ']");



        public void TextCalendarFrom(int NumberDay)
        {
            var serverTime = DateTime.Now.AddDays(NumberDay).ToString("yyyy/MM/dd", new CultureInfo("fa-IR"));
            Console.WriteLine(serverTime);
            SendKeys(TXTCalendarFrom, serverTime);
        }
        public void TextCalendarTo(int NumberDay)
        {
            var serverTime = DateTime.Now.AddDays(NumberDay).ToString("yyyy/MM/dd", new CultureInfo("fa-IR"));
            Console.WriteLine(serverTime);
            SendKeys(TXTCalendarTo, serverTime);
        }
        public void BottunAddLimitation()
        {
            Click(BtnAddLimitation);
        }
        public void LimitationDelete()
        {
            Click(DeletefirstItem);
            Click(BtnMassegeActiveYes);
        }
        public void LimitationEdit()
        {
            Click(btnlistEditLimitation);
        }
        public void Editlimitlist(string search)
        {
            Scroll(ScrollPanel);
            Click(SearchTXTTransactionalAction);
            Thread.Sleep(1000);
            SendKeys(SearchTXTTransactionalAction, search);
            Thread.Sleep(1000);
            Click(SelectTransactionalAction);
        }
        public void LimitationsItHasTransactionOrderWithIt()
        {
            Click(RadioBtnItHasTransactionOrderWithIt);
        }
        public void ClickButtonSavelimitation()
        {
            Click(BtnSaveLimitation);
        }
        public void CloseFromlimitation()
        {
            if ( BtnClose != null)
            {
                Click(BtnClose);
            }
            else
            {
                Console.WriteLine("skip");
            }
           
        }
        
        public void AddLimitations(string titlelimitation, string symbolstock, string massagefarsi)
        {
            SendKeys(TXTTitleLimitation, titlelimitation);
            Click(TXTSymoblStock);
            SendKeys(STXTSymoblStock, symbolstock);
            Thread.Sleep(5000);
            Click(CTXTSymoblStock);
            SendKeys(TXTMaseegeFarsi, massagefarsi);         
        }
        public void ActiveLimitation()
        {
            Click(BtnActive);
            Click(BtnMassegeActiveYes);
        }
        public void AddTimefrom(int NumberDay)
        {
            var serverTime = DateTime.Now.AddMinutes(NumberDay).ToString("HH:mm", new CultureInfo("fa-IR"));
            Console.WriteLine(serverTime);
            SendKeysTab(TimeFrom, serverTime);
           // Click(TextBazar);


        }
        public void AddTimeTo(int NumberDay)
        {
            var serverTime = DateTime.Now.AddMinutes(NumberDay).ToString("HH:mm", new CultureInfo("fa-IR"));
            Console.WriteLine(serverTime);
            SendKeysTab(TimeTo, serverTime);
        }
        public void AddNumber(int from ,int to)
        {
            SendKeys(NumberOfStockExchangeFrom, from.ToString());
            SendKeys(NumberOfStockExchangeTo, to.ToString());
        }
        public void AddPrice(int from, int to)

        {
            var GetMAXAndMINGetPriceStockSymbol = new GetPriceStockSymbol();
          //  GetMAXAndMINGetPriceStockSymbol.GetPriceMax(hsStockSymbol);
            SendKeys(PriceOfStockExchangeFrom, from.ToString());
            SendKeys(PriceOfStockExchangeTo, to.ToString());
        }
        public void AddCustomer( string  search)
        {
            Click(SearchTXTCustomer);
            Thread.Sleep(1500);
            SendKeys(SearchTXTCustomer, search);
            Click(SelectCustomer);
        }
        public void AddIndustry(string search)
        {
            Click(SearchTXTIndustry);
            SendKeys(SearchTXTIndustry, search);
            Click(SelectIndustry);
        }
        public void AddtMarketType(string search)
        {
            Click(SearchTXTMarketType);
            SendKeys(SearchTXTMarketType, search);
            Click(SelectMarketType);
        }
        public void AddTransactionType(string search)
        {
            Click(SearchTXTTransactionType);
            // Thread.Sleep(1500);
            SendKeys(SearchTXTTransactionType, search);
            Click(SelectTransactionType);
        }
        public void AddTransactionManager(string search)
        {
            Click(SearchTXTTransactionManager);
            SendKeys(SearchTXTTransactionManager, search);
            Click(SelectTransactionManager);
        }
        public void AddTransactionalAction(string search)
        {
            Click(SearchTXTTransactionalAction);
            SendKeys(SearchTXTTransactionalAction, search);
            Click(SelectTransactionalAction);
        }
        public void AddTimeValidityType(string search)
        {
            Click(SearchTXTTimeValidityType);
            SendKeys(SearchTXTTimeValidityType, search);
            Click(SelectTimeValidityType);
        }
        public void AddStockMarketValue(int from,int to)
        {
            SendKeys(TXTStockMarketValueMin, from.ToString());
            SendKeys(TXTStockMarketValueMax, to.ToString());
        }
    }
}

