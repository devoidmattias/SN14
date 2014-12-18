using System;

namespace Knacka
{
    class Program
    {
        static void Main(string[] args)
        {

            int antalKnackningar = 0;

            // mata in värde
            Console.Write("Hur många knackningar? ");
            antalKnackningar = int.Parse(Console.ReadLine());

          

            // initierar en kontrollvariabel
            while(antalKnackningar > 0)
            {
                Console.WriteLine("Knack");

                // uppdatera kontrollvariabeln
                antalKnackningar--;

            }
            Console.WriteLine("Klart!");
           

        }
    }
}
