using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Application
    {
        public void Run()
        {
            string line;


            try
            {
                using (StreamReader reader = new StreamReader("12 flaskor whiskey.txt"))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }







           

          
        }
    }
}
