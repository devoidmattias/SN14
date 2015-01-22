using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class Die
    {
        public const int MaxValue = 8;
        public const int MinValue = 1;


        private static Random _randomSeed;

        private int _faceValue;
        private Random _random;

       
        public int FaceValue
        {
            get { return _faceValue; }
            private set 
            {
                if (value < MinValue || value > MaxValue)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _faceValue = value; 
            }
        }

        static Die()
        {
            _randomSeed = new Random();
        }

        public Die()
        {
            _random = new Random(_randomSeed.Next());
            Throw();  
        }

        public int Throw()
        {
            FaceValue = _random.Next(MinValue, MaxValue + 1);
            return FaceValue;
        }
    }
}
