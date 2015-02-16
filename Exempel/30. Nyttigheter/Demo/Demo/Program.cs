using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {


            var products = new List<Product>
            {
                
                new Product { Name = "iPhone 5S", Supplier = "Apple", Price = 3995 },
                new Product { Name = "XPeria Z3", Supplier = "Sony", Price = 4995 },
                new Product { Name = "S5", Supplier = "Samsung", Price = 5495 },
                new Product { Name = "iPhone 6", Supplier = "Apple", Price = 5995 }

            };



            var appleProdukter = (from product in products
                                  where product.Supplier.Equals("Apple")
                                  orderby product.Price descending
                                  select new
                                  {
                                      product.Name,
                                      product.Price
                                  })
                                 .ToList();




            // vad är totalpriset på alla Apple-produkter?
            var prisetPaAppleProdukter = products
                .Where(product => product.Supplier == "Apple")
               
                .TotalPrice();

            // vad är totalpriset på alla Apple-produkter som är billigare än 4000?
            var billigaAppleProdukter = products
                .Where(x => x.Supplier == "Apple" && x.Price < 5000)
                .TotalPrice();

            var billigaAppleProdukter2 = products
              .Where(x =>
              {
                  return x.Supplier == "Apple" && x.Price < 5000;
              })
              .TotalPrice();


        }

    }
}

/*
 * 
 *     decimal price = 0;
            products.ForEach(product =>
            {
                price += product.Price;
            });

            price = 0;
            foreach (var product in products)
            {
                price += product.Price;
            }
 * 
 *     private static bool IsExpensiveProduct(Product p)
        {
            return p.Price > 5000;
        }
 * 
 * 
            bool detFinnsProdukterSomArDyrareAn5000 = false;
            foreach (var product in products)
            {
                if(product.Price > 5000)
                {
                    detFinnsProdukterSomArDyrareAn5000 = true;
                    break;
                }
            }


            detFinnsProdukterSomArDyrareAn5000 = products.Any(x => x.Price > 5000);


          
 * 
 *             int tal = 10;
            int minusTal2 = tal.Negate();


     var totalPrice = products.TotalPrice();
            var medianPris = products.MedianPrice();


            var pArray = new[] {new Product { Name = "iPhone 5S", Supplier = "Apple", Price = 3995 },
                new Product { Name = "XPeria Z3", Supplier = "Sony", Price = 4995 }};

            pArray.TotalPrice();
            pArray.MedianPrice();    var totalPrice = products.TotalPrice();
            var medianPris = products.MedianPrice();


            var pArray = new[] {new Product { Name = "iPhone 5S", Supplier = "Apple", Price = 3995 },
                new Product { Name = "XPeria Z3", Supplier = "Sony", Price = 4995 }};

            pArray.TotalPrice();
            pArray.MedianPrice();
 */
/*
  var intList = new List<int> { 4, 9, 2, 33, 11, 1 };
            intList.Sort();

            var nameList = new List<string> { "Robin", "Andreas", "Nils", "Mattias", "Fredrik" };
            // sortera på namnets längd
            nameList.Sort(new StringLenghtComparer());


            var products = new List<Product>
            {
                
                new Product { Name = "iPhone 5S", Supplier = "Apple", Price = 3995 },
                new Product { Name = "XPeria Z3", Supplier = "Sony", Price = 4995 },
                new Product { Name = "S5", Supplier = "Samsung", Price = 5495 },
                new Product { Name = "iPhone 6", Supplier = "Apple", Price = 5995 }

            };
            
            // summera priset
            decimal price = 0;
            foreach (var product in products)
            {
                price += product.Price;
            }


 
 */

/*
   var p1 = new Product();

            var p2 = new Product("iPhone 6", "Apple", 5995);

            var p3 = new Product();
            p3.Name = "iPhone 6";
            p3.Supplier = "Apple";
           // p3.Price = 5995;

            var p4 = new Product { Name = "iPhone 6", Supplier = "Apple" };

            var list1 = new List<Product>();
            list1.Add(p1);
            list1.Add(p2);


            var list2 = new List<Product>();
           // list2.AddRange(list1);
           // var productsToAdd = new[] { p1, p2, p3 };
            list2.AddRange(new[] { p1, p2, p3 });


            var list3 = new List<Product>
            {
                p1,
                p2,
                new Product("Xperia Z3") { Supplier = "Sony", Price = 5495 },
                new Product { Name = "S5", Supplier = "Samsung", Price = 5000 }

            };
            

*/