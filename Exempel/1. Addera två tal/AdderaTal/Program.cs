using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdderaTal
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklarera variabler
            int forstaTalet = 0;        // första inmatade talet
            int andraTalet = 0;         // andra inmatade talet
            int summa = 0;
            string inmatatTal;

            // läsa in talen
            Console.Write("Mata in första talet: ");
            inmatatTal = Console.ReadLine();
            forstaTalet = int.Parse(inmatatTal);

            Console.Write("Mata in andra talet: ");
            inmatatTal = Console.ReadLine();
            andraTalet = int.Parse(inmatatTal);

            // beräkna summan
            summa = forstaTalet + andraTalet;


            // presentera summan
            Console.WriteLine("Summan av {0} och {1} är {2}!", forstaTalet, andraTalet, summa);

        }

    }
}
