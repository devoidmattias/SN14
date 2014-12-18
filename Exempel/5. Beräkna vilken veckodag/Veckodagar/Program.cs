using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veckodagar
{
    class Program
    {
        static void Main(string[] args)
        {
            int dagnummer = 0;
            string dagensNamn = string.Empty;

            // Läs in
            Console.Write("Ange veckodag med en siffra (1-7): ");
            dagnummer = Convert.ToInt32(Console.ReadLine());

            // översätt till en veckodag
            switch(dagnummer)
            {
                case 1:
                    dagensNamn = "Måndag";
                    break;
                case 2:
                    dagensNamn = "Tisdag";
                    break;
                case 3:
                    dagensNamn = "Onsdag";
                    break;
                case 4:
                    dagensNamn = "Torsdag";
                    break;
                case 5:
                    dagensNamn = "Fredag";
                    break;
                case 6:
                    dagensNamn = "Lördag";
                    break;
                case 7:
                    dagensNamn = "Söndag";
                    break;
                default:
                    dagensNamn = "Ingen dag";
                    break;
            }
   

            // skriv ut
            Console.WriteLine("{0} har nummer {1}", dagensNamn, dagnummer);

        }
    }
}
