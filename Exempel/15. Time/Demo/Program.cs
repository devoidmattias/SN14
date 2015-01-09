using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();


            time.Hour = 6;
            time.Hour += 30;


            Console.WriteLine(time.Hour);
        }
    }
}
