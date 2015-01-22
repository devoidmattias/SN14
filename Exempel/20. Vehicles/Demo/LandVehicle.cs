using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    public abstract class LandVehicle : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Jag åker på marken");
        }
    }
}
