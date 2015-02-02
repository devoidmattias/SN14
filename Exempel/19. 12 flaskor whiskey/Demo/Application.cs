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

            List<int> testScores = new List<int>();
           
            try
            {
                using (StreamReader reader = new StreamReader("TestScores.csv"))
                {
                    while ((line = reader.ReadLine()) != null)
                    {

                        string[] values = line.Split(new char[]{',', ' '}, StringSplitOptions.RemoveEmptyEntries);

                        foreach(string value in values)
                        {
                            testScores.Add(int.Parse(value));
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            testScores.TrimExcess(); // finns, men Mattiasd använder inte...
            testScores.Sort();



           
            int count = 0;
            foreach (int value in testScores)
            {
                if(value % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Jämna tal: {0}", count);

            // lambda - uttryck
            int antalJamna = testScores.Where(value => value % 2 == 0).Count();

         
        }

    }
}




















