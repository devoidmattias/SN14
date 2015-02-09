//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Web;
//using System.Web.Razor.Parser.SyntaxTree;
//using System.Web.UI;

//namespace ViewModelsDemo.Models
//{
//    public class ProductDb
//    {
//        private static List<Product> _products = null;

//        private List<Product> Products
//        {
//            get
//            {
//                if (_products == null)
//                {
//                    var hp = new Supplier { SupplierId = Guid.NewGuid(), SupplierName = "HP" };
//                    var dell = new Supplier { SupplierId = Guid.NewGuid(), SupplierName = "Dell" };
//                    var ms = new Supplier { SupplierId = Guid.NewGuid(), SupplierName = "Microsoft"};

//                    var lillapc = new Product{ Name = "Lilla PC'n", Category = Category.Hardware, Description = "Den lilla billiga", Price = 4595, ProductId = Guid.NewGuid(), Supplier = dell, PurchasePrice = 2582, StockCount = 10, WarehouseLocation = "A0"};
//                    var storaPC = new Product{ Name = "Stora PC'n", Category = Category.Hardware, Description = "Den onödigt dyra", Price = 17995, ProductId = Guid.NewGuid(), Supplier = hp, PurchasePrice = 13255, StockCount = 2, WarehouseLocation = "A1"};
//                    var operativ = new Product{ Name = "Windows 8", Category = Category.Software, Description = "Det bästa operativsystemet!", Price = 1995, ProductId = Guid.NewGuid(), Supplier = ms, PurchasePrice = 259, StockCount = 0, WarehouseLocation = "Z0"};

//                    _products = new List<Product> { lillapc, storaPC, operativ };
//                }

//                return _products;

//            }
//        }


//        public Product Get(Guid productId)
//        {
//            return Products.Find(p => p.ProductId == productId);
//        }

//        public Product Add(Product product)
//        {
//            if (product == null)
//            {
//                throw new ArgumentNullException("product");
//            }
//            product.ProductId = Guid.NewGuid();
//            Products.Add(product);
//            return product;
//        }

//        public bool Update(Product product)
//        {
//            if (product == null)
//            {
//                throw new ArgumentNullException("product");
//            }
//            int index = Products.FindIndex(p => p.ProductId == product.ProductId);
//            if (index == -1)
//            {
//                return false;
//            }
//            Products.RemoveAt(index);
//            Products.Add(product);
//            return true;  
//        }

//        public void Remove(Guid productId)
//        {
//            Products.RemoveAll(p => p.ProductId == productId);
//        }

//        public IEnumerable<Product> GetAll()
//        {
//            return Products; 
//        }
//    }
//}