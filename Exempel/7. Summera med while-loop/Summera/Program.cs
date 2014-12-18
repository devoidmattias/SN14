using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summera
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;
            int tal = 0;

            // mata in värde
            Console.Write("Ange heltal som skall summeras: ");
            tal = int.Parse(Console.ReadLine());
           
            while (tal != 0)
            {
                summa += tal;
                tal = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Summan är {0}!", summa);
        }
    }
}
