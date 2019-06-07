using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace UiTests.Fixtures
{
    public class TestFixture : IDisposable
    {
        public readonly IWebDriver WebDriver;
        public TestFixture()
        {
            //TODO : move to folder where is  docker-compose file
            //TODO run command docker-compose build
            //TODO run command docker-compose up
            ChromeOptions options = new ChromeOptions();
            WebDriver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options.ToCapabilities());

        }

        public void GoTo(string url )
        {
            WebDriver.Navigate().GoToUrl(url);
        }

        public void Dispose()
        {
            WebDriver.Dispose();
            //TODO run command docker-compose down
        }
    }
}
