using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    public class Generator : IEngine
    {
        public void StartEngine()
        {
            Console.WriteLine("Startar generatorn ");
        }

        public void StopEngine()
        {
            Console.WriteLine("Stoppar generatorn");
        }
    }
}
