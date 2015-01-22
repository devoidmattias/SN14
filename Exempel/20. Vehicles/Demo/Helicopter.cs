using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    public class Helicopter : Aircraft
    {
        public override void StartEngine()
        {
            Console.WriteLine("Startar motorn - helikopter");
        }
    }
}
