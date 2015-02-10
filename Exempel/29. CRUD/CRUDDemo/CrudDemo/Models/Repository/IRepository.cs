using System;
using System.Collections.Generic;

namespace CrudDemo.Models.Repository
{
    public interface IRepository : IDisposable
    {
        List<Product> GetProducts();
        Product GetProduct(Guid id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        void Save();
    }
}

