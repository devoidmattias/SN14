using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    public class Airliner : Aircraft
    {
        public override void StartEngine()
        {
            Console.WriteLine("Airliner startar motorn");
        }
    }
}
