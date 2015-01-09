using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personer
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Person person = new Person("Nils", 44, Color.Blue);
            Person person2 = new Person("Stefan", 43, Color.Blue);

            person.ViewData();
   
        }

       
    }
}
