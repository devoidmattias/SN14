using System;
using System.Collections.Generic;

namespace ViewModelsDemo.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product Get(Guid id);
        Product Add(Product product);
        bool Update(Product product);
        void Remove(Guid id);
    }
}
