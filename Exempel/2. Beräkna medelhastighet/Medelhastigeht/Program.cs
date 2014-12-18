using System;

namespace Medelhastigeht
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometer = 0;
            int minuter = 0;
            double medelhastighet = 0;

            // inläsning
            Console.Write("Ange antal km: ");
            kilometer = int.Parse(Console.ReadLine());

            Console.Write("Ange antal minuter: ");
            minuter = int.Parse(Console.ReadLine());

            // räkna ut
            double timmar = minuter / 60;
            medelhastighet = kilometer / timmar;

            // skriv ut
            Console.WriteLine("Medelhastigheten över {0} km var {1:F1}", kilometer, medelhastighet);
        }
    }
}
