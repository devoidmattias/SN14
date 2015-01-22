using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Manager : Employee
    {
        private decimal _bonus;

        // beräknad egenskap utan fält bakom...
        public decimal AnnualPay
        {
            get { return Salary + Bonus; }
        }

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

        public Manager(string name, decimal salary, DateTime hireDate, decimal bonus)
            : base(name, salary, hireDate)
        {
            Console.WriteLine("public Manager(string name, decimal salary, DateTime hireDate, decimal bonus)");
           
            Bonus = bonus;
        }
    }
}
