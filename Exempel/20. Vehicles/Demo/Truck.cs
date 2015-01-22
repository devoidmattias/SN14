using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    public class Truck : LandVehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Lastbilen startar motorn");
        }
    }
}
