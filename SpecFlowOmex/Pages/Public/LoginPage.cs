using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowOmex.Support;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SpecFlowOmex.Pages.Public
{
    public class LoginPage:BasePage
    {
        private const string UrlClient = "https://dev-client.tsetab.com/login/index.html";
        private const string UrlAdmin = "https://dev-admin.tsetab.com/login/index.html";
        private const string UrlStationDev = "https://dev-station.tsetab.com/#/";


        //The Selenium web driver to automate the browser
        private readonly IWebDriver _webDriver;

        //The default wait time in seconds for wait.Until
        public const int DefaultWaitInSeconds = 5;
        public LoginPage(IWebDriver webDriver):base(webDriver)
        {
            _webDriver = webDriver;
        }
        //Finding elements by ID
        private readonly By TXTUsername = By.Id("js-loginFormStep1-usernameInput");
        private readonly By TXTPassword = By.Id("js-loginFormStep1-passwordInput");
        private readonly By TXTCaptcha = By.Id("js-loginFormStep1-captchaInput");
        private readonly By BtnsignIn = By.Id("js-loginFormStep1-submitButton");
        private readonly By TextorderSymbolClient = By.CssSelector(".e-mainTitle");
        private readonly By TextorderSymbolAdmin = By.CssSelector("[routerlink='account/profile']");
        private readonly By TextorderSymbolStation= By.CssSelector("[aria-controls='mat-tab-content-1-0'] .e-tabLabel");
        private IWebElement ResetButtonElement => _webDriver.FindElement(By.Id("reset-button"));

        public void LoginUser(string username, string password)
        {
            SendKeys(TXTUsername, username);
            SendKeys(TXTPassword, password);
            SendKeys(TXTCaptcha,"1");
           // Thread.Sleep(7000);
            Click(BtnsignIn);
        }
        public void GoToUrlAndLoadPageStationDev()
        {
            _webDriver.Navigate().GoToUrl(UrlStationDev);
            _webDriver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(10));
        }
        public void GoToUrlAndLoadPageClient()
        {
            _webDriver.Navigate().GoToUrl(UrlClient);
            _webDriver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(10));
        }
        public void GoToUrlAndLoadPageAdmin()
        {
            _webDriver.Navigate().GoToUrl(UrlAdmin);
            _webDriver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(10));
        }
        public void AssertCardboardStation()
        {
            AssertTextMassege(TextorderSymbolStation, "سفارشات");
        }
        public void AssertCardboardClinet()
        {
            AssertTextMassege(TextorderSymbolClient, "سفارشات نماد");
        }
        public void AssertCardboardstation()
        {
            AssertTextMassege(TextorderSymbolClient, "سفارشات نماد");
        }
        public void AssertCardboardAdmin()
        {
            AssertTextMassege(TextorderSymbolAdmin, "پروفایل");
        }
    }
}
