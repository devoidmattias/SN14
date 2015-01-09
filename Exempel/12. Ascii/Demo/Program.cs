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
            string text;
            int index;

            text = ReadText();

            index = ReadCharacterIndex();
            while( index >= 0)
            {
                ViewCharacterInfo(text, index);
                index = ReadCharacterIndex();
            }
               
        }
        
        static string ReadText()
        {
            Console.Write("Mata in en sträng: ");
            return Console.ReadLine();
        }
        static int ReadCharacterIndex()
        {
            Console.Write("Ange ett index: ");
            return int.Parse(Console.ReadLine());
        }
        static void ViewCharacterInfo(string text, int characterIndex)
        {
            Console.WriteLine("\nTecknet på index {0} är ett {1} och har ASCII-värdet {2}",
                characterIndex, text[characterIndex], (int)text[characterIndex]);
        }
    }
}
