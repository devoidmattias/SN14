using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModelsDemo.Models
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }

    public class Cart
    {
        private List<CartLine> _lines = new List<CartLine>();

        public void AddItem(Product product, int quantity)
        {
            CartLine line = _lines
                .Where(p => p.Product.ProductId == product.ProductId)
                .FirstOrDefault();

            if (line == null)
            {
                _lines.Add(new CartLine
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        
        public void RemoveLine(Product product)
        {
            _lines.RemoveAll(l => l.Product.ProductId == product.ProductId);
        }
        public decimal ComputeTotalValue()
        {
            return _lines.Sum(e => e.Product.Price * e.Quantity);
        }
        public void Clear()
        {
            _lines.Clear();
        }
        public IEnumerable<CartLine> Lines
        {
            get { return _lines; }
        }
    }
}