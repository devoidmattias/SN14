using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Employee 
    {
        private string _name;
        private decimal _salary;

        // auto-implementerad egenskap
        public DateTime HireDate { get; set; }

        public string PhoneNumber { get; set; }

        public string Name
        { 
            get { return _name; }
            set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }
                _name = value;
            }
        }

        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if(value < 0.0m)
                {
                    throw new ArgumentException();
                }
                _salary = value;
            }
        }

        public Employee()
            : this("NN", 0m, DateTime.Today)
        {
            Console.WriteLine("public Employee()");
        }

        public Employee(string name, decimal salary, DateTime hireDate)
        {
            Console.WriteLine("public Employee(string name, decimal salary, DateTime hireDate)");
            Name = name;
            Salary = salary;
            HireDate = hireDate;
        }

        public void RaiseSalary(decimal percent)
        {
            Salary *= 1 + percent / 100m;
        }

    }
}
