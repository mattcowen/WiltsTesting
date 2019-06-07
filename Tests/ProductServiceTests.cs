using System;
using System.Collections.Generic;
using System.Text;
using WiltsTesting.Models;
using WiltsTesting.Services;
using Xunit;

namespace Tests
{
    public class ProductServiceTests
    {
        [Theory]
        [InlineData("widget")]
        [InlineData("1")]
        public void SearchProductsTest(string searchText)
        {
            // Arrange
            var sut = new ProductService();

            // Act
            var result = sut.SearchProducts(searchText);

            // Assert
            Assert.NotEmpty(result);
        }

        [Fact]
        public void DeleteProductTest()
        {
            // Arrange
            var sut = new ProductService();

            Assert.Throws<NotImplementedException>(() => sut.DeleteProduct());
        }
    }
}
