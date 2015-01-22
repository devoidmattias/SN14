using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public enum EngineObjectType
    {
        Undefined,
        Car,
        Fighter,
        Generator
    }

    public class Application
    {
        
        public void Run()
        {
            do
            {

                IEngine engine = null;

                switch (GetMenuChoice())
                {
                    case 0:
                        return;

                    case 1:
                        engine = CreateEngineObject(EngineObjectType.Car);
                        break;

                    case 2:
                        engine = CreateEngineObject(EngineObjectType.Fighter);
                        break;

                    case 3:
                        engine = CreateEngineObject(EngineObjectType.Generator);
                        break;

                    case 4:
                        Test test = new Test();
                        test.Run();

                        Console.ReadKey();
                        continue;
                       
                }

                engine.StartEngine();
                engine.StopEngine();

                Console.ReadKey();
            } while (true);

        }

        private IEngine CreateEngineObject(EngineObjectType type)
        {
            switch(type)
            {
                case EngineObjectType.Car:
                    return new Car();

                case EngineObjectType.Fighter:
                    return new Fighter();

                case EngineObjectType.Generator:
                    return new Generator();

                default:
                    throw new NotImplementedException();

            }
        }


        private int GetMenuChoice()
        {
            int index;
            do
            {
                Console.Clear();

                Console.WriteLine("0. Avsluta");
                Console.WriteLine("1. Skapa en bil");
                Console.WriteLine("2. Skapa en fighter");
                Console.WriteLine("3. Skapa en generator");
                Console.WriteLine("4. Kör tester");

                Console.WriteLine();

                Console.Write("Ange menyval: ");

                if(int.TryParse(Console.ReadLine(), out index) && index >= 0 && index <= 4)
                {
                    return index;
                }

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\nFEL, ange ett värde mellan 0 och 4");
                Console.ResetColor();
                Console.CursorVisible = false;
                Console.ReadKey(true);
                Console.CursorVisible = true;

            } while (true);
        }
    }
}
