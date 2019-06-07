using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UiTests.PageObjects
{
    public class ProductPage
    {
        private IWebDriver _driver;

        public ProductPage(IWebDriver webDriver)
        {
            this._driver = webDriver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//form")]
        public IWebElement Form { get; internal set; }
    }
}
