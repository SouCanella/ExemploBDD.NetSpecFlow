using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace ExemploBDDTesteSeleniumSpecFlow.Utils
{
    [Binding]
    public sealed class TestRunSingleBrowserHooks
    {
        private static IWebDriver _navegador;

        private TestRunSingleBrowserHooks()
        {

        }

        [BeforeFeature]
        public static void RegistrarPaginas()
        {
            _navegador = new ChromeDriver();

            //Utilizar o navegador Firefox
            //FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\romulo.canella\source\repos\sager.apuracao.fabrica\ONS.SagerApuracao.AutomatedTests\bin\Debug\netcoreapp2.1", "geckodriver.exe");
            //_navegador = new FirefoxDriver(service);
            _navegador.Manage().Window.Maximize();
        }

        public static IWebDriver RetornarDriver(string url)
        {
            _navegador.Navigate().GoToUrl(url);
            return _navegador;
        }

        // Reuse browser for the whole run.
        [AfterTestRun]
        public static void AfterTestRun()
        {
            _navegador.Quit();
        }
    }
}