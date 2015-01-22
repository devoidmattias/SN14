using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class BadManager
    {
        private decimal _bonus;
        private string _name;
        private decimal _salary;

        // beräknad egenskap utan fält bakom...
        public decimal AnnualPay
        {
            get { return Salary + Bonus; }
        }

       // auto-implementerad egenskap
        public DateTime HireDate { get; set; }

        public decimal Bonus
        {
            get { return _bonus; }
            set
            {
                if (value < 0.0m)
                {
                    throw new ArgumentException();
                }
                _bonus = value;
            }
        }
 
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

        public BadManager()
        {

        }

        public BadManager(string name, decimal salary, DateTime hireDate, decimal bonus)
        {
            Name = name;
            Salary = salary;
            HireDate = hireDate;
            Bonus = bonus;
        }

        public void RaiseSalary(decimal percent)
        {
            Salary *= 1 + percent / 100m;
        }

    }
}
