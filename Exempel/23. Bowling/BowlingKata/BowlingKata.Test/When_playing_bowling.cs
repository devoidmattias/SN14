using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using BowlingKata;


namespace BowlingKata.Test
{
    public class When_playing_bowling
    {
        private BowlingGame _game;
        

        // Gemensam initiering av alla tester
        public When_playing_bowling()
        {
            // Arrange
            _game = new BowlingGame();
        }

        private void RollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                _game.Roll(pins);
            }
        }

        private void RollSpare()
        {
            _game.Roll(5);
            _game.Roll(5); // spare
        }


        [Fact]
        public void A_game_of_all_zeroes_return_zero_score()
        {
            // Act
            RollMany(20, 0);

            // Assert
            Assert.Equal(0, _game.Score());
        }

    

        [Fact]
        public void A_game_of_all_ones_returns_score_of_20()
        {
            // Act
            RollMany(20, 1);

            // Assert
            Assert.Equal(20, _game.Score());
        }

        [Fact]
        public void A_game_with_one_spare_returns_score_plus_bonus()
        {
            RollSpare();
            _game.Roll(3);

            RollMany(17, 0);

            Assert.Equal(16, _game.Score());

        }

        [Fact]
        public void A_game_with_one_strike_returns_score_plus_double_bonus()
        {
            _game.Roll(10);
            _game.Roll(0);
            _game.Roll(2);

            RollMany(16, 0);

            Assert.Equal(14, _game.Score());
        }

      
    }
}
