using TechTalk.SpecFlow;
using ExemploBDDTesteSeleniumSpecFlow.Utils;
using NUnit.Framework;
using ExemploBDDTesteSeleniumSpecFlow.Paginas;
using System;

namespace ExemploBDDTesteSeleniumSpecFlow.Steps
{
    [Binding]
    public class RealizarPesquisaNoGoogleSteps
    {
        private readonly ElementosDaHome _elementosDaHome;


        public RealizarPesquisaNoGoogleSteps()
        {
            _elementosDaHome = new ElementosDaHome(TestRunSingleBrowserHooks.RetornarDriver(Config.URL_HOME));
        }

        [Given(@"que estou na página")]
        public void DadoQueEstouNaPagina()
        {           
            var paginaInicial = _elementosDaHome.LogoHome;
            Assert.IsTrue(paginaInicial.Displayed);
        }
        
        [When(@"realizo um pesquisa")]
        public void QuandoRealizoUmPesquisa()
        {
            var campoPesquisa = _elementosDaHome.CampoDePesquisa;
            campoPesquisa.Click();
            campoPesquisa.SendKeys("SpecFlow");
            campoPesquisa.Submit();
           
        }

        [Then(@"Verifico resultado da pesquisa")]
        public void EntaoVerificoResultadoDaPesquisa()
        {
            var resultadodaPesquisa = _elementosDaHome.ResultadoDaPesquisa;
            Assert.IsTrue(resultadodaPesquisa.Displayed);
        }
    }
}