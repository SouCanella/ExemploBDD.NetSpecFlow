using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using ExemploBDDTesteSeleniumSpecFlow.Utils;
using System;
using TechTalk.SpecFlow;

[Binding]
public sealed class TestRunSingleBrowserHooks
{
    private static IWebDriver _driver;

    [BeforeFeature]
    public static void RegistrarPaginas()
    {
        _driver = new ChromeDriver();
        //FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\romulo.canella\source\repos\sager.apuracao.fabrica\ONS.SagerApuracao.AutomatedTests\bin\Debug\netcoreapp2.1", "geckodriver.exe");
        //driver = new FirefoxDriver(service);
        _driver.Manage().Window.Maximize();        
    }

    public static IWebDriver RetornarDriver(string url)
    {
        _driver.Navigate().GoToUrl(url);
        return _driver;
    }

    // Reuse browser for the whole run.
    [AfterTestRun]
    public static void AfterTestRun()
    {
        _driver.Quit();
    }
}