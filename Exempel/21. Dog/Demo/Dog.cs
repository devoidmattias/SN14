using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Dog
    {

        public IList<string> Bark(int numberOfTreats)
        {
            var response = new List<string>();

            if(numberOfTreats == 0)
            {
                return response;
            }

            response.Add("Woof");
            response.Add("Woof");
            response.Add("Woof");
            response.Add("Woof");
            response.Add("Woof");
            return response;

        }
    }
}
