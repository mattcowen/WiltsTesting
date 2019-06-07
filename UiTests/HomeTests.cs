using OpenQA.Selenium;
using System;
using UiTests.Fixtures;
using Xunit;

namespace UiTests
{
    public class HomeTests : IClassFixture<TestFixture>
    {
        private TestFixture fixture;

        public HomeTests(TestFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void LoadHome()
        {
            fixture.GoTo("http://host.docker.internal");
            var element = fixture.WebDriver.FindElement(By.TagName("h1"));

            Assert.Equal("Products", element.Text);
        }
    }
}
