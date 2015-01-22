using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public abstract class Vehicle : IEngine
    {
        public double MaxSpeed { get; set; }
              
        public void StopEngine()
        {
            Console.WriteLine("Stoppar motorn");
        }

        public abstract void StartEngine();

        public abstract void Drive();
       
    }
}
