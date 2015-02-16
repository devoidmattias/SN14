using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModelsDemo.Models;
using ViewModelsDemo.ViewModels;

namespace ViewModelsDemo.Controllers
{
    public class ProductsController : Controller
    {
        private ProductDb _productDb = new ProductDb();

        // GET: Product list
        public ActionResult Index()
        {
            var products = _productDb.GetAll().ToList();

            var productViewModels = products
                .OrderBy(x => x.Name)
                .Select(x => x.ToViewModel())
                .ToList();


            return View(productViewModels);

            //var productViewModels = new List<ProductViewModel>();
            //foreach (var product in products)
            //{
            //    var productViewModel = new ProductViewModel
            //    {
            //        ProductId = product.ProductId,
            //        Category = product.Category == Category.Hardware ? "Hårdavara" : "Mjukvara",
            //        Description = product.Description,
            //        Name = product.Name,
            //        Price = product.Price,
            //        Supplier = product.Supplier.SupplierName
            //    };
            //    productViewModels.Add(productViewModel);
            //}
          
        }
    }
}

