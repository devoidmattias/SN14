﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    public class Bus : LandVehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Bussen startar");
        }
    }
}
