using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    public class Vehicle 
    {
        public string Model { get; set; }
        public int Passengers { get; set; }
        public string RegistrationNumber { get; set; }

        public Vehicle()
        {
            //Console.WriteLine("Vehicle()");
        }

        public Vehicle(string model, int passengers, string registrationNumber)
        {
            Console.WriteLine("Vehicle(string model, int passengers, string registrationNumber)");
            Model = model;
            Passengers = passengers;
            RegistrationNumber = registrationNumber;
        }

    }
}
