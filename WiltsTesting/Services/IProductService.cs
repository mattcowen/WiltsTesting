using System;
using System.Collections.Generic;
using WiltsTesting.Models;

namespace WiltsTesting.Services
{
    public interface IProductService
    {
        Product GetProduct(Guid productId);
        IList<Product> SearchProducts(string searchText);
    }
}