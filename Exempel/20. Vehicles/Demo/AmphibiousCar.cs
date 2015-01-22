using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    public class AmphibiousCar : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Blubb blubb");
        }

        public override void Drive()
        {
            Console.WriteLine("Flyter omkring");
        }
    }
}
