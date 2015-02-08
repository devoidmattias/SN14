using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModelsDemo.Models
{
    public class Supplier 
    {
        public Guid SupplierId { get; set; }
        public string SupplierName { get; set; }
        public List<Product> Products { get; set; }
    }
    

    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }


        public int StockCount { get; set; }
        public string WarehouseLocation { get; set; }
        public decimal PurchasePrice { get; set; }
        public double Margin
        {
            // return margin percent
            get { return Convert.ToDouble((Price - PurchasePrice) / Price); }
        }


        public virtual Supplier Supplier {get; set;}
    }
}


