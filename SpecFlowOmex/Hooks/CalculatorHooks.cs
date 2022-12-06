
using SpecFlowOmex.Drivers;
using SpecFlowOmex.Pages;
using SpecFlowOmex.Pages.Admin;
using SpecFlowOmex.Pages.Client.Cardboard;
using SpecFlowOmex.Pages.Public;
using TechTalk.SpecFlow;

namespace SpecFlowProject.Hooks
{
    [Binding]
    public sealed class CalculatorHooks
    {

        private readonly ScenarioContext _scenarioContext;

        public CalculatorHooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [BeforeScenario]
        [Scope(Tag = "GotostationBeta")]
        public static void BeforeScenarioBeta(BrowserDriver browserDriver)
        {
            var loginPage = new LoginPage(browserDriver.Current);
            loginPage.GoToUrlAndLoadPageStationDev();
        }
        [BeforeScenario]
        [Scope(Tag = "GotostationDev")]
        public static void BeforeScenarioDev(BrowserDriver browserDriver)
        {
            var loginPage = new LoginPage(browserDriver.Current);
            loginPage.GoToUrlAndLoadPageStationDev();
        }
        [BeforeScenario]
        [Scope(Tag = "GotoClient")]
        public static void BeforeScenario(BrowserDriver browserDriver)
        {
            var loginPage = new LoginPage(browserDriver.Current);
            loginPage.GoToUrlAndLoadPageClient();
        }
        [BeforeScenario]
        [Scope(Tag = "GoToUrlAndLoadPageAdmin")]
        public static void GoToUrlAndLoadPageAdmin(BrowserDriver browserDriver)
        {
            var loginPage = new LoginPage(browserDriver.Current);
            loginPage.GoToUrlAndLoadPageAdmin();
        }
        [AfterScenario]
        [Scope(Tag = "LogoutClient")]

        public void LogoutClinet(BrowserDriver browserDriver)
        {
            var cardboard = new CardboardClinetPage(browserDriver.Current);

            cardboard.LogoutUser();
        }
        [AfterScenario]
        [Scope(Tag = "LogoutAdmin")]

        public void LogoutAdmin(BrowserDriver browserDriver)
        {
            var cardboard = new CardboardAdminPage(browserDriver.Current);

            cardboard.LogoutUser();
        }
    }
}
