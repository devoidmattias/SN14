using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollFrequencyTable
{
    /// <summary>
    /// Applikationen simulerar tärningskast och presenterar utfallet i en frekvenstabell.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Startpunkt för applikationen
        /// </summary>
        /// <param name="args">Argument som kan skickas till applikationen från kommandoraden</param>
        static void Main(string[] args)
        {
            // deklarerar lokala variabler
            int antal = 0;
            int[] frekvenstabell = new int[6];

            // Läser in hurmånga tärningskast som ska simuleras då
            // en frekvenstabell över tärningskast skapas och presenteras
            antal = LasInAntalKast();
            frekvenstabell = KastaTarning(antal);

            VisaFrekvenstabell(frekvenstabell);
        }

        /// <summary>
        /// Läser in och returnerar antalet tärningskast som skall simuleras
        /// </summary>
        /// <returns></returns>
        private static int LasInAntalKast()
        {
            // deklarerar en lokal variabel
            int antal = 0;

            // läser in och returnerar ett heltal mellan 100 och 1000
            while(true)
            {
                try
                {
                    Console.Write("Ange antal tärningskast [100-1000]: ");
                    antal = int.Parse(Console.ReadLine());

                    if(antal < 100 || antal > 1000)
                    {
                        throw new ApplicationException();
                    }

                    return antal;
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nFEL! Ange ett heltal mellan 100 och 1000\n");
                    Console.ResetColor();
                }
            } 
        }

        /// <summary>
        /// Simulerar tärningskast och skapar en frekvenstabell över utfallet.
        /// </summary>
        /// <param name="antalKast">Antal tärningskast att simulera.</param>
        /// <returns>Array innehållande frekvenstabell över simulerade tärningskast.</returns>
        private static int[] KastaTarning(int antalKast)
        {
            // deklarerar lokala variabler
            int[] frekvenstabell = new int[6];
            Random tarning = new Random();

            // slumpar tärningskast och uppdaterar frekvenstabellen som därefter returneras
            for (int i = 0; i < antalKast; i++)
            {
                frekvenstabell[tarning.Next(0, 6)]++;
            }

            return frekvenstabell;
        }

        /// <summary>
        /// Presenterar en frekvenstabell över tärningskast.
        /// </summary>
        /// <param name="frekvenstabell">Referns till frekvenstabell i form av en array
        /// innehållande utfallet av tärningskasten.</param>
        private static void VisaFrekvenstabell(int[] frekvenstabell)
        {
            // deklarerar lokal variabel
            string[] sidnamn = { "Ettor", "Tvåor", "Treor", "Fyror", "Femmor", "Sexor" };

            // Går igenom tärningssidan för tärningssida och skriver ut dess namn samt 
            // antalet gånger den blivit resultatet av ett kast.
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n---------------");
            Console.WriteLine(" Frekvenstabell");
            Console.WriteLine("---------------");
            Console.ResetColor();

            for (int i = 0; i < sidnamn.Length; i++)
            {
                Console.WriteLine(" {0,-7} | {1,4}", sidnamn[i], frekvenstabell[i]);
                Console.WriteLine("---------------");
            }
        }
    }
}
