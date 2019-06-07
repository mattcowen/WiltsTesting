using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiltsTesting.Models;

namespace WiltsTesting.Services
{
    public class ProductService : IProductService
    {
        public Product GetProduct(Guid productId)
        {
            return new Product() { Id = productId,  Name = "Widget 1", Price = 199.99 };
        }

        public IList<Product> SearchProducts(string searchText)
        {
            List<Product> products = new List<Product> {
                new Product() { Name = "Widget 1", Price = 199.99 },
                new Product() { Name = "Widget 2", Price = 99.99 },
                new Product() { Name = "Widget 3", Price = 299.99 },
                new Product() { Name = "Widget 4", Price = 399.99 },
                new Product() { Name = "Widget 5", Price = 599.99 }
            };

            return products.FindAll(x => x.Name.ToLowerInvariant().Contains(searchText.ToLowerInvariant()));
        }

        public void DeleteProduct()
        {
            throw new NotImplementedException();
        }

    }
}
