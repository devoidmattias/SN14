//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using ViewModelsDemo.Models;
//using ViewModelsDemo.ViewModels;

//namespace ViewModelsDemo.Controllers
//{
//    public class CartController : Controller
//    {
//        private ProductDb _productDb = new ProductDb();

//        public ViewResult Index(string returnUrl)
//        {
//            return View(new CartIndexViewModel
//            {
//                Cart = GetCart(),
//                ReturnUrl = returnUrl
//            });
//        }

//        [HttpPost]
//        public RedirectToRouteResult AddToCart(Guid productId, string returnUrl)
//        {
//            Product product = _productDb.Get(productId);
//            if (product != null)
//            {
//                GetCart().AddItem(product, 1);
//            }
//            return RedirectToAction("Index", new { returnUrl });
//        }

//        public RedirectToRouteResult RemoveFromCart(Guid productId, string returnUrl)
//        {
//            Product product = _productDb.Get(productId);
//            if (product != null)
//            {
//                GetCart().RemoveLine(product);
//            }
//            return RedirectToAction("Index", new { returnUrl });
//        }

//        private Cart GetCart()
//        {
//            Cart cart = (Cart)Session["Cart"];
//            if (cart == null)
//            {
//                cart = new Cart();
//                Session["Cart"] = cart;
//            }
//            return cart;
//        }
//    }
//}
