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
            int[] numbers = { 2, 7, 93, 3, 345, 9 };
            Array.Sort(numbers);

            foreach(int number in numbers)
            {
                Console.Write("{0, 4}", number);
            }

            Console.WriteLine();

            Car[] cars = new Car[4];
            cars[0] = new Car("Volvo V70", 5, "ABC123", 1900);
            cars[2] = new Car("Audi TT", 2, "JUP123", 1200);
            cars[3] = new Car("Landrover Defender", 7, "JHR748", 2500);

            Array.Sort(cars);

            foreach(Car car in cars)
            {
                Console.WriteLine(car != null ? car.ToString() : "<null>");
            }



        }
    }
}



//// skapa ett objekt

//Car myCar = new Car
//{
//    Passengers = 3,
//    Model = "Volvo V70",
//    Weight = 1900,
//    RegistrationNumber = "ABC123"
//};




//// skriv ut något...
//Console.WriteLine(myCar.ToString());