using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            string firstName;
            string lastName;
            string fullName;

            #endregion // Variables

            firstName = GetUserInput("Ange förnamn: ");
            lastName = GetUserInput("Ange efternamn: ");
          
            fullName = GetFullName(firstName, lastName);

            DisplayGreeting(fullName);

        }

        #region Helper Methods

        static string GetUserInput(string prompt)
        {
            string input;

            Console.Write(prompt);
            input = Console.ReadLine();
            return input;
        }

        static string GetFullName(string fName, string lName)
        {
            return String.Format("{0} {1}", fName, lName);
        }

        static void DisplayGreeting(string fullName)
        {
            Console.WriteLine("Ditt fullständiga namn är: {0}", fullName);
        }

        #endregion
    }
}
