using TechTalk.SpecFlow;
using ExemploBDDTesteSeleniumSpecFlow.Utils;
using NUnit.Framework;
using ExemploBDDTesteSeleniumSpecFlow.Paginas;

namespace ExemploBDDTesteSeleniumSpecFlow.Steps
{
    [Binding]
    public class RealizarPesquisaNoGoogleSteps
    {
        private ElementosDaHome _elementosDaHome;


        public RealizarPesquisaNoGoogleSteps()
        {
            _elementosDaHome = new ElementosDaHome(TestRunSingleBrowserHooks.RetornarDriver(Config.URL_HOME));
        }

        [Given(@"que estou na página")]
        public void DadoQueEstouNaPagina()
        {           
            var paginaInicial = _elementosDaHome.LogoHome;
            Assert.IsNotNull(paginaInicial);           
        }
        
        [When(@"realizo um pesquisa")]
        public void QuandoRealizoUmPesquisa()
        {
            var campoPesquisa = _elementosDaHome.CampoDePesquisa;
            campoPesquisa.Click();
            campoPesquisa.SendKeys("SpecFlow");                          
           
        }

        [Then(@"Verifico resultado da pesquisa")]
        public void EntaoVerificoResultadoDaPesquisa()
        {
            Assert.Pass();            
        }
    }
}
