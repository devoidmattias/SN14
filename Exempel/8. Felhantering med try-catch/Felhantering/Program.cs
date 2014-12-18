using System;

namespace Felhantering
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal = 0;

            while(true)
            {
                try
                {
                    Console.Write("Ange ett heltal: ");
                    tal = int.Parse(Console.ReadLine());

                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Du måste ange ett heltal!");
                }

            }
          // efter break




            Console.WriteLine("Inmatat tal: {0}", tal);

        }
    }
}
