//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using ViewModelsDemo.Models;
//using ViewModelsDemo.ViewModels;

//namespace ViewModelsDemo.Controllers
//{
//    public class StockController : Controller
//    {
//        private ProductDb _productDb = new ProductDb();

//        public ActionResult Index()
//        {
//            var products = _productDb.GetAll().ToList();
//            var stockViewModels = new List<StockListViewModel>();

//            foreach (var product in products)
//            {

//                var productViewModel = new StockListViewModel
//                {
//                    ProductId = product.ProductId,
//                    Category = product.Category == Category.Hardware ? "Hårdavara" : "Mjukvara",
//                    Name = product.Name,
//                    SalesPrice = product.Price,
//                    PurchasePrice = product.PurchasePrice,
//                    Supplier = product.Supplier.SupplierName,
//                    StockCount = product.StockCount,
//                    Margin = product.Margin
//                };

//                stockViewModels.Add(productViewModel);
//            }

//            return View(stockViewModels);
//        }
//    }
//}

