using Moq;
using System;
using WiltsTesting.Models;
using WiltsTesting.Services;
using Xunit;
using Microsoft.Extensions.Options;
using WiltsTesting.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UnitTests.Fixtures;

namespace Tests
{
    public class HomeControllerTests
    {

        [Fact]
        public void HomePageLoadsProducts()
        {
            // Arrange
            var productServiceMock = new Mock<IProductService>();
            var settingsMock = new Mock<IOptions<SampleWebSettings>>();

            productServiceMock.Setup(x => x.SearchProducts(It.IsAny<string>()))
                .Returns(GetTestProducts());

            HomeController sut = new HomeController(productServiceMock.Object, settingsMock.Object);

            // Act
            var result = sut.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<List<Product>>(viewResult.ViewData.Model);
            Assert.Equal(3, model.Count);

            productServiceMock.Verify(x => x.SearchProducts(It.IsAny<string>()), Times.Once);

        }

        private List<Product> GetTestProducts()
        {
            return new List<Product>{
                new Product() { Id = Guid.Empty, Name = "Test Product 1", Price = 49.99 },
                new Product() { Id = Guid.Empty, Name = "Test Product 2", Price = 59.99 },
                new Product() { Id = Guid.Empty, Name = "Test Product 3", Price = 69.99 }

            };
        }
    }


    public class HomeControllerTestsWithFixture : IClassFixture<ProductsFixture>
    {
        private readonly ProductsFixture productsFixture;

        public HomeControllerTestsWithFixture(ProductsFixture productsFixture)
        {
            this.productsFixture = productsFixture;
        }

        [Fact]
        public void HomePageLoadsProductsUsingFixture()
        {
            // Arrange
            var productServiceMock = new Mock<IProductService>();
            var settingsMock = new Mock<IOptions<SampleWebSettings>>();

            productServiceMock.Setup(x => x.SearchProducts(It.IsAny<string>()))
                .Returns(productsFixture.GetTestProducts());

            HomeController sut = new HomeController(productServiceMock.Object, settingsMock.Object);

            // Act
            var result = sut.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<List<Product>>(viewResult.ViewData.Model);
            Assert.Equal(3, model.Count);

            productServiceMock.Verify(x => x.SearchProducts(It.IsAny<string>()), Times.Once);

        }

    }

}
