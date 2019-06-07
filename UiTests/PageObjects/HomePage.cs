using System;
using System.Threading;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UiTests.PageObjects
{
    public class HomePage
    {
        private readonly IWebDriver _driver;

        public HomePage(IWebDriver driver, string url)
        {
            _driver = driver;
            _driver.Navigate().GoToUrl(url);
            PageFactory.InitElements(_driver, this);

        }

        [FindsBy(How = How.XPath, Using = "//table[@class=\"table\"]/tbody/tr[1]/td[3]/a[1]")]
        public IWebElement FirstProductEditLink { get; set; }

        internal ProductPage EditFirstProduct()
        {
            FirstProductEditLink.Click();
            return new ProductPage(_driver);
        }
    }
}
