using ExemploBDDTesteSeleniumSpecFlow.Pagina.Base;
using OpenQA.Selenium;

namespace ExemploBDDTesteSeleniumSpecFlow.Paginas
{
    class ElementosDocadastro : PaginaBase
    {
        
        /// Exemplos
              
        //public IWebElement CampoDePesquisa => RetornarElementoPorNome("q");
        //public IWebElement LogoHome => RetornarElementoPorId("hplogo");


        public ElementosDocadastro(IWebDriver navegador) : base(navegador)
        {
        }
    }
}