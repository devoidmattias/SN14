using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Product : IComparable<Product>
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Supplier { get; set; }
        public decimal Price { get; set; }

        #region Constructors
        public Product()
            : this(string.Empty, string.Empty, 0)
        {
        }

        public Product(string name)
        {
            Name = name;
        }

        public Product(string name, string supplier, decimal price)
        {
            ProductId = Guid.NewGuid();
            Name = name;
            Supplier = supplier;
            Price = price;
        }
        #endregion

        public int CompareTo(Product other)
        {
            if (other == null)
            {
                return 1;
            }
            if (other == this)
            {
                return 0;
            }

            return Price.CompareTo(other.Price);
        }
    }
}
