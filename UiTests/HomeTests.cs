using FluentAssertions;
using OpenQA.Selenium;
using System;
using UiTests.Fixtures;
using UiTests.PageObjects;
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
            new HomePage(this.fixture.WebDriver, "http://localhost").EditFirstProduct();

            new ProductPage(this.fixture.WebDriver).Form.Displayed.Should().BeTrue();

        }
    }
}
