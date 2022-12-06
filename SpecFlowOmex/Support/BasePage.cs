using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Globalization;
using System.Threading;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace SpecFlowOmex.Support
{
    public class BasePage
    {
        public readonly IWebDriver driver;
        public static long za;

        public void RightClickMouse(By by)

        {
            Actions actions = new Actions(driver);
            var elementLocator = driver.FindElement(by);
            actions.ContextClick(elementLocator).Perform();

        }
        public void DateDayPlus(int NumberDay)
        {
            var serverTime = DateTime.Now.AddDays(NumberDay).ToString("dd", new CultureInfo("fa-IR"));
            Console.WriteLine(serverTime);
            int x = Int16.Parse(serverTime) + 1;
            Console.WriteLine(x);
            //IWebElement day = driver.FindElement(By.XPath("//tr[5]//div[contains(.," + serverTime + ")]"));
            IWebElement day = driver.FindElement(By.CssSelector("[aria-label='1401/08/" + x + "']"));
            day.Click();
            Thread.Sleep(1500);
        }

        public void IJavaScriptClick(By by)

        {

            WaitUntilElementVisible(by);
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript("arguments[1].click();", by);

        }
        public void IJavaScriptSendKeys(By by, string textsendkeys)
        {


            //WebElement webl = (WebElement)driver.FindElement(by);
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript()

            //WebElement webl = driver.FindElement(By.xpath(“xpath_expression”));

            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            //js.ExecuteScript("".value =’Avinash Mishra’;”);
            //WaitUntilElementVisible(by);
            //IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            //js1.ExecuteScript("arguments[1].sendkeys();", by);
            WebElement webl = (WebElement)driver.FindElement(by);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].value='" + textsendkeys + "';", webl);
        }

        public IWebElement WaitUntilElementVisible(By locator)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.ElementExists(locator));

            return wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public IWebElement WaitUntilElement(By locator)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);

            fluentWait.Timeout = TimeSpan.FromSeconds(8);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(5000);
            return fluentWait.Until(x => x.FindElement(locator));
        }

        protected BasePage(IWebDriver Webdriver)
        {
            this.driver = Webdriver;
        }

        protected IWebElement GetElement(By by)
        {
            WaitUntilElementVisible(by);
            return driver.FindElement(by);
        }


        protected void Click(By by)
        {
            Thread.Sleep(1000);
            WaitUntilElement(by);
            WaitUntilElementVisible(by);
            var elm = driver.FindElement(by);
            if (elm != null)
            {
                driver.FindElement(by).Click();
            }
            else
            {
                Thread.Sleep(1000);
                WaitUntilElement(by);
                driver.FindElement(by).Click();


            }
        }
        protected void Scroll(By by)
        {
            //WaitUntilElement(by);
            //WaitUntilElementVisible(by);




            //Actions actions = new Actions(driver);
            //actions.MoveToElement(driver.FindElement(by))
            //	   .ClickAndHold()
            //	   .Release().Perform();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");

        }

        protected void SendKeys(By by, string text)
        {
            //  WaitUntilElement(by);
            WaitUntilElementVisible(by);
            var elm = driver.FindElement(by);
            if (elm != null)
            {
                elm.SendKeys(text);
            }
            else
            {
                Thread.Sleep(500);
                WaitUntilElement(by);

                elm.SendKeys(text);

                driver.Quit();
            }
        }

        protected void SendKeysTab(By by, string text)
        {
            //  WaitUntilElement(by);
            WaitUntilElementVisible(by);
            var elm = driver.FindElement(by);
            if (elm != null)
            {
                elm.SendKeys(text);
                elm.SendKeys(Keys.Enter);
                elm.SendKeys(Keys.Tab);

            }
            else
            {
                Thread.Sleep(500);
                WaitUntilElement(by);

                elm.SendKeys(text);
                elm.SendKeys(Keys.Enter);

                driver.Quit();
            }
        }
        protected void AlertMassege()
        {
            Thread.Sleep(1000);
            var alert_win = driver.SwitchTo().Alert();

            if (alert_win != null)
            {
                alert_win.Accept();


            }
            else
            {
                Thread.Sleep(1000);
                Console.WriteLine("NoSuchAlert");
            }

        }
        protected void Clear(By by)
        {
            WaitUntilElementVisible(by);
            driver.FindElement(by).Clear();
        }
        protected void AssertTextMassege(By by, string Text)
        {
            Thread.Sleep(500);
            //WaitUntilElement(by);
            WaitUntilElementVisible(by);
            var TextMassege = driver.FindElement(by).Text;
            Assert.AreEqual(Text, TextMassege);
        }
        protected void DisabledButton(By by)
        {



            //driver.PageSource.Contains()
            //if (driver.FindElement(by) != null)
            //{

            //Console.WriteLine("Element is Present");

            //}
            //else
            //{

            //	Console.WriteLine("Element is Absent");

            //}
            //WaitUntilElementVisible(by);
            //var Button = driver.FindElement(by);

            //Assert.IsTrue(Button.Enabled);
            //Assert.AssertTrue(false, Button.Enabled);
        }
        protected void CheckDisabledButton(By by)
        {
            WaitUntilElementVisible(by);
            var Button = driver.FindElement(by);
            Assert.AreEqual(false, Button.Enabled);
        }
        protected void CheckPurchasingPower(string operation, By by, By by1, By by2, By by4)

        {
            WaitUntilElementVisible(by);
            WaitUntilElementVisible(by1);
            //قدرت خرید 
            var web1 = driver.FindElement(by).Text;
            //مبلغ کل معامله
            var web2 = driver.FindElement(by1).Text;
            long i = Convert.ToInt64(web1.Replace(",", ""));
            Console.WriteLine("قدرت خرید= " + i);
            long y = Convert.ToInt32(web2.Replace(",", ""));
            Console.WriteLine("مبلغ کل معامله =" + y);
            if (operation == "subtraction")
            {
                za = i - y;
                driver.FindElement(by2).Click();
            }
            else if (operation == "addition ")
            {
                za = i + y;
                driver.FindElement(by2).Click();
            }else
            {
                za = i ;
            }
         //   driver.FindElement(by2).Click();
            var alert_win = driver.SwitchTo().Alert();
            alert_win.Accept();
            Thread.Sleep(3000);
            var web3 = driver.FindElement(by4).Text;
            long e = Convert.ToInt64(web3.Replace(",", ""));
            Console.WriteLine("حاصل تفریق=" + za);
            Console.WriteLine("قدرت خرید جدید  " + e);
            Assert.AreEqual(e, za);
        }
        protected IWebElement GetElementText(By by)
        {
            WaitUntilElementVisible(by);
            var t = driver.FindElement(by).Text;

            Console.WriteLine(t);
            return driver.FindElement(by);
        }
        protected void UploadFile(By by, string file)
        {
            //  WaitUntilElement(by);
            WaitUntilElement(by);
            driver.FindElement(by).SendKeys(file);
            Thread.Sleep(1500);

        }

    }
}