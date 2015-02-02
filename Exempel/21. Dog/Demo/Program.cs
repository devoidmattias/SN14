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
            var dog = new Dog();

            var responses = dog.Bark(1);
            foreach (var response in responses)
            {
                Console.WriteLine(response);
            }


           
        }
    }
}
