using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewModelsDemo.Models;

namespace ViewModelsDemo.ViewModels
{
    public static class ProductExtensions
    {
        public static ProductViewModel ToViewModel(this Product product)
        {
            return new ProductViewModel
                {
                    ProductId = product.ProductId,
                    Category = product.Category == Category.Hardware ? "Hårdavara" : "Mjukvara",
                    Description = product.Description,
                    Name = product.Name,
                    Price = product.Price,
                    Supplier = product.Supplier.SupplierName
                };
        }
    }
}