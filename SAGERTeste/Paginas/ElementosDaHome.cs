using ExemploBDDTesteSeleniumSpecFlow.Pagina.Base;
using OpenQA.Selenium;

namespace ExemploBDDTesteSeleniumSpecFlow.Paginas
{
    class ElementosDaHome : PaginaBase
    {
        public IWebElement CampoDePesquisa => RetornarElementoPorNome("q");
        public IWebElement LogoHome => RetornarElementoPorId("hplogo");


        public ElementosDaHome(IWebDriver navegador) : base(navegador)
        {
        }
    }
}