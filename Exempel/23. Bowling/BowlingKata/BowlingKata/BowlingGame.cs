using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BowlingKata
{
    public class BowlingGame
    {

        private int _score;
        private int[] _rolls = new int[21];
        private int _currentRoll;

        public void Roll(int pins)
        {
            _rolls[_currentRoll] = pins;
            _currentRoll++;
        }






        public int Score()
        {
            int roll = 0;
            for (int frame = 0; frame < 10; frame++ )
            {

                if (IsStrike(roll))
                {
                    _score += StrikeBonus(roll);
                    roll++;
                    
                }
                else if (IsSpare(roll))
                {
                    // spare
                    _score += SpareBonus(roll);
                    roll += 2;
                }
                else
                {
                    _score += NormalScore(roll);
                    roll += 2;
                }
            }

            return _score;
        }







        private int NormalScore(int roll)
        {
            return _rolls[roll] + _rolls[roll + 1];
        }

        private int SpareBonus(int roll)
        {
            return 10 + _rolls[roll + 2];
        }

        private int StrikeBonus(int roll)
        {
            return 10 + _rolls[roll + 1] + _rolls[roll + 2];
        }

        private bool IsStrike(int roll)
        {
            return _rolls[roll] == 10;
        }

        private bool IsSpare(int roll)
        {
            return _rolls[roll] + _rolls[roll + 1] == 10;
        }
    }
}
