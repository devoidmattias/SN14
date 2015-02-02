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

            List<int> intList = new List<int>();

            intList.Add(4);
            intList.Add(5);

            var person = new Person { Name = "Kalle", Age = 45 };
            var person2 = new Person { Name = "Nisse", Age = 35 };

            
            var personList = new List<Person>();
            personList.Add(person);
            personList.Add(person2);


            var personlist2 = new List<Person>
            {
                new Person { Name = "Kalle", Age = 45 },
                new Person { Name = "Nisse", Age = 35 }
            };



            var dict = new Dictionary<string, Person>();

            dict.Add("xxxxxx-yyyy", person2);




        }
    }
}
