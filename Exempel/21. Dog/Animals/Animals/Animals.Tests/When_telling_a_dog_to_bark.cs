using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace Animals.Tests
{
    public class When_telling_a_dog_to_bark
    {
        [Fact]
        public void The_dog_doesnt_bark_for_no_treats()
        {
            var dog = new Dog();
            var response = dog.Bark(0);

            Assert.Equal(0, response.Count);
        }

        [Fact]
        public void The_dog_barks_once_for_one_treat()
        {
            var dog = new Dog();
            var response = dog.Bark(1);

            Assert.Equal(1, response.Count);
        }

        [Fact]
        public void The_dog_barks_one_per_treat()
        {
            // Arrange
            var dog = new Dog();

            // Act
            var response = dog.Bark(5);

            // Assert
            Assert.Equal(5, response.Count);
        }
    }
}
//