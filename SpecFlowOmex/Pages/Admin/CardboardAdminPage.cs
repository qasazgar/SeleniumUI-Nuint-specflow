using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SpecFlowOmex.Support;
using System;
using System.Globalization;
using System.Threading;

namespace SpecFlowOmex.Pages.Admin
{
    public class CardboardAdminPage : BasePage
    {
        private readonly IWebDriver driver;
        
        public CardboardAdminPage(IWebDriver driver) : base(driver)
        {
        }
        // meno 
        private readonly By MenoLimitations = By.XPath("//span[.='محدودیت ها']");


        //Loguot
        private readonly By BtnExit = By.CssSelector(".justify-content-between > div:nth-of-type(3)");


        public void GoToLimitations()
        {
            Click(MenoLimitations);
        }

        public void LogoutUser()
        {
            Click(BtnExit);
        }
    }
}

//