using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog
    {
        public IList<string> Bark(int numberOfTreats)
        {
            var responses = new List<string>();

            for (int i = 0; i < numberOfTreats; i++)
            {
                responses.Add("Woof");
            }

            return responses;
        }
    }
}
