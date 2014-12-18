using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inloggning
{
    class Program
    {
        private const string Anvandare = "Harry";
        private const string Losenord = "qwerty";

        static void Main(string[] args)
        {
            string anvandarnamn = "";
            string losenord = string.Empty;

            // mata in användarnamn
            Console.Write("Ange anvämndarnamn: ");
            anvandarnamn = Console.ReadLine();

            // mata in lösenord
            Console.Write("Ange lösenord: ");
            losenord = Console.ReadLine();

            // bekräfta anv och lösen
            if(anvandarnamn == Anvandare && losenord == Losenord)
            {
                 // skriv ut resultat
                Console.WriteLine("Inloggad!");
            }
            else
            {
                 // skriv ut resultat
                Console.WriteLine("Inte inloggad!");
            }

            // skriv ut klar
            Console.WriteLine("Körs alltid");
            

        }
    }
}
