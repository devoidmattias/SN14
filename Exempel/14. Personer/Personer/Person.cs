using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personer
{
    public class Person
    {  
        private string _name;
        private int _shoeSize;

        // auto-implementerad egenskap
        public Color EyeColor { get; set;}
       
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

        public int ShoeSize
        {
            get { return _shoeSize; }
            set
            {
                if(value < 10 || value > 50)
                {
                    throw new ArgumentException();
                }
                _shoeSize = value;
            }
        }

        public Person()
        {
            //tom
        }

        public Person(string name, int shoeSize, Color eyeColor)
        {
            Name = name;
            ShoeSize = shoeSize;
            EyeColor = eyeColor;
        }

        public void ViewData()
        {
            string color = null;

            // Översätt parametern eyeColor till en sträng.
            if (EyeColor == Color.Blue)
            {
                color = "blåa";
            }
            else if (EyeColor == Color.Brown)
            {
                color = "bruna";
            }
            else if (EyeColor == Color.Green)
            {
                color = "gröna";
            }
            else
            {
                color = "okänd färg på sina";
            }

            // Skriv ut beskrivning av personen.
            Console.WriteLine("{0} har {1} ögon och {2} i skostorlek.\n",
                Name, color, ShoeSize);
        }
    }
}
