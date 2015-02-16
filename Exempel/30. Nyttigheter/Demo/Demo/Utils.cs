using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{

    static class IntExtensions
    {
        public static int Negate(this int value)
        {
            return -value;
        }
    }

    static class ProductExtensions
    {
        public static decimal TotalPrice(this IEnumerable<Product> products)
        {
            decimal price = 0;
            foreach (var product in products)
            {
                price += product.Price;
            }

            return price;
        }

        public static decimal MedianPrice(this IEnumerable<Product> products)
        {
            decimal median = 0;

            // medianberäkning


            return median;
        }
    }




    #region Comparers


    class StringLenghtComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {

            // NULL-kontroller SKALL göras först, men inte i exemplet!
            return x.Length.CompareTo(y.Length);
        }
    }

    class ProductPriceComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {

            // NULL-kontroller SKALL göras först, men inte i exemplet!
            return x.Price.CompareTo(y.Price);
        }
    }

    #endregion

}
