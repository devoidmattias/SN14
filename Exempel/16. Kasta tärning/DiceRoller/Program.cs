using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Program
    {

        static void Main(string[] args)
        {
            Die die = new Die();
            Die otherDie = new Die();

           
                       
            for (int i = 0; i < 10; i++)
            {
                die.Throw();
                otherDie.Throw();

                Console.WriteLine("{0}\t{1}", die.FaceValue, otherDie.FaceValue);

            }

        }
    }
}
