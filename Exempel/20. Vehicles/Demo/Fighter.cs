using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    public class Fighter : Aircraft
    {
        public override void StartEngine()
        {
            Console.WriteLine("Startar motorn - Swissssh");
        }

        public void FireMissile()
        {
            Console.WriteLine("Fire missile");
        }
    }
}
