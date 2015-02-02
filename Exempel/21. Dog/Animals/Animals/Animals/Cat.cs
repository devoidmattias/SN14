using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public class Cat
    {
        public IList<string> Jam(int numberOfTreats)
        {
            var response = new List<string>();

            if(numberOfTreats == 1)
                response.Add("Mjau");

            return response;
            
                
        }

        public void Sleep(int hours)
        {

        }
    }
}
