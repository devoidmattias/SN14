using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Test
    {

        public void Run()
        {
            Car myCar = new Car();
            Fighter myFighter = new Fighter();
            AmphibiousCar myAmphibiousCar = new AmphibiousCar();
            Generator myGenerator = new Generator();


            DoAction(myCar);
            DoAction(myFighter);
            DoAction(myAmphibiousCar);
            DoAction(myGenerator);

        }

        private void DoAction(IEngine engine)
        {
            engine.StartEngine();
            //engine.Drive();
            engine.StopEngine();

        }


    }
}
