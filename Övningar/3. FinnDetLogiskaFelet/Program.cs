using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinnDetLogiskaFelet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Finn det logiska felet";

            // Namngiven konstant 
            const int Momssats = 25;    // moms i procent

            // Definierar och initierar variabler.
            double kostnad = 0d;       // varans pris
            double moms = 0d;        // moms i kronor
            double totalkostnad = 0d;  // kostnad för en vara inkl. moms

            // Användaren matar in priset.
            Console.Write("Ange varans pris exkl. moms: ");
            kostnad = Double.Parse(Console.ReadLine());

            // Beräknar momsen.
            moms = Momssats * kostnad;

            // Beräkna den totala kostnaden.
            totalkostnad = kostnad + moms;

            // Presenterar resultatet.
            Console.WriteLine("Varans pris inkl. moms är {0:c}.", totalkostnad);
        }
    }
}
