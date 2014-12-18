using System;


namespace Milberakning
{
    class Program
    {
        // namngivna konstanter
        private const int MeterPerKilometer = 1000;
        private const int MeterPerMil = MeterPerKilometer * 10;

        static void Main(string[] args)
        {
            // 23456 m

            int meter = 23456;
            int mil = 0;
            int kilometer = 0;
            int kvarvarandeMeter = 0;


            // uppdelning i mil och km och m
            kvarvarandeMeter = meter;
            mil = kvarvarandeMeter / MeterPerMil;
            kvarvarandeMeter = kvarvarandeMeter % MeterPerMil;
          
            kilometer = kvarvarandeMeter / MeterPerKilometer;
            kvarvarandeMeter = kvarvarandeMeter % MeterPerKilometer;

            // utskrift
            Console.WriteLine("{0} meter blir {1} mil, {2} kilometer och {3} meter.",
                meter, 
                mil, // 1
                kilometer, 
                kvarvarandeMeter);
            

        }
    }
}
