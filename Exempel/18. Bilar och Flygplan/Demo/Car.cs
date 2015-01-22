using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Car : Vehicle, IComparable
    {
       
        public int Weight { get; set; }

        public Car()
        {
          //  Console.WriteLine("Car()");
        }

        public Car(string model)
            : this(model, 0)
        {
            Console.WriteLine("Car(string model)");
        }
        
        public Car(string model, int passengers)
            : this(model, passengers, "-")
        {
            Console.WriteLine("Car(string model, int passengers)");
           
        }

        public Car(string model, int passengers, string registrationNumber)
            : this(model, passengers, registrationNumber, 0)
        {
            Console.WriteLine("Car(string model, int passengers, string registrationNumber)");
 
        }

        public Car(string model, int passengers, string registrationNumber, int weight)
            : base(model, passengers, registrationNumber)
        {
            Console.WriteLine("Car(string model, int passengers, string registrationNumber, int weight)");
         
            Weight = weight;
        }




        public override string ToString()
        {
            return String.Join(", ", Model, Passengers, RegistrationNumber, Weight);
        }

        public int CompareTo(object obj)
        {
            if(obj == null)
            {
                return 1;
            }

            if(obj == this)
            {
                return 0;
            }

            Car other = obj as Car;
            if(other == null)
            {
                throw new ArgumentException("Object is not a Car");
            }

            return Weight.CompareTo(other.Weight);



        }
    }

  
}

