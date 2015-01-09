using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaxelPengarA
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalsumma = 0;
            int avrundadSumma = 0;
            decimal avrundatBelopp = 0;
            int erhalletBelopp = 0;

            // Läs in totalsumma
            while(true)
            {
                try 
	            {	        
		            Console.Write("Ange totalsumma     : ");
                    totalsumma = decimal.Parse(Console.ReadLine());
                    break;
	            }
	            catch (Exception)
	            {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
		            Console.WriteLine("\nFEL! Totalsumma felaktig.\n");
                    Console.ResetColor();
	            }
            }
         
            // avrunda
            avrundadSumma = (int)Math.Round(totalsumma);
            avrundatBelopp = avrundadSumma - totalsumma;

            if(avrundadSumma < 1)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nTotalsumman är för liten. Köpet kunde inte genomföras.\n");
                Console.ResetColor();

                return;
            }

            // Läs in erhållet belopp
            while (true)
            {
                try
                {
                    Console.Write("Ange erhållet belopp: ");
                    erhalletBelopp = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nFEL! Erhållet belopp felaktigt.\n");
                    Console.ResetColor();
                }
            }

            if(avrundadSumma > erhalletBelopp)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nErhållet belopp är för litet. Köpet kunde inte genomföras.\n");
                Console.ResetColor();

                return;
            }

            int tillbaka = erhalletBelopp - avrundadSumma;

            // skriv kvitto
            Console.WriteLine("\nKVITTO");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("{0,-15} : {1, 15:c}", "Totalt", totalsumma);
            Console.WriteLine("{0,-15} : {1, 15:c}", "Öresavrundning", avrundatBelopp);
            Console.WriteLine("{0,-15} : {1, 15:c0}", "Att betala", avrundadSumma);
            Console.WriteLine("{0,-15} : {1, 15:c0}", "Kontant", erhalletBelopp);
            Console.WriteLine("{0,-15} : {1, 15:c0}", "Tillbaka", tillbaka);
            Console.WriteLine("---------------------------------\n");

            // skriv ut uppdelningen
            int femhundraLappar = tillbaka / 500;
            tillbaka = tillbaka % 500;
            int hundraLappar = tillbaka / 100;
            tillbaka = tillbaka % 100;
            int femtioLappar = tillbaka / 50;
            tillbaka = tillbaka % 50;
            int tjugoLappar = tillbaka / 20;
            tillbaka = tillbaka % 20;
            int tior = tillbaka / 10;
            tillbaka = tillbaka % 10;
            int femmor = tillbaka / 5;
            tillbaka = tillbaka % 5;


            if(femhundraLappar > 0)
            {
                Console.WriteLine(" {0,-14} : {1}", "500-lappar", femhundraLappar);
            }
            
            if (hundraLappar > 0)
            {
                Console.WriteLine(" {0,-14} : {1}", "100-lappar", hundraLappar);
            }

            if (femtioLappar > 0)
            {
                Console.WriteLine(" {0,-14} : {1}", "50-lappar", femtioLappar);
            }

            if (tjugoLappar > 0)
            {
                Console.WriteLine(" {0,-14} : {1}", "20-lappar", tjugoLappar);
            }
            if (tior > 0)
            {
                Console.WriteLine(" {0,-14} : {1}", "10-kronor", tior);
            }
            if (femmor > 0)
            {
                Console.WriteLine(" {0,-14} : {1}", "5-kronor", femmor);
            }
            if (tillbaka > 0)
            {
                Console.WriteLine(" {0,-14} : {1}", "1-kronor", tillbaka);
            }

        }
    }
}
