﻿using ExemploBDDTesteSeleniumSpecFlow.Utils;
using OpenQA.Selenium;

namespace ExemploBDDTesteSeleniumSpecFlow.Pagina.Base
{
    public abstract class PaginaBase
    {
        public IWebDriver _navegador;
       
        protected PaginaBase(IWebDriver navegador)
        {
            _navegador = navegador;
        }
             
        protected IWebElement RetornarElementoPorNome(string nome) => _navegador.FindElement(By.Name(nome), 5);

        protected IWebElement RetornarElementoPorId(string id) => _navegador.FindElement(By.Id(id), 5);

        protected IWebElement RetornarElementoPorClass(string classe) => _navegador.FindElement(By.ClassName(classe), 5);
                
    }
}