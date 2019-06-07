using System;
using System.Collections.Generic;
using System.Text;
using WiltsTesting.Models;

namespace UnitTests.Fixtures
{
    public class ProductsFixture : IDisposable
    {
        public ProductsFixture()
        {

        }

        public List<Product> GetTestProducts()
        {
            return new List<Product>{
                new Product() { Id = Guid.Empty, Name = "Test Product 1", Price = 49.99 },
                new Product() { Id = Guid.Empty, Name = "Test Product 2", Price = 59.99 },
                new Product() { Id = Guid.Empty, Name = "Test Product 3", Price = 69.99 }

            };
        }

        public void Dispose()
        {
            // ... clean up test data
        }
    }
}
