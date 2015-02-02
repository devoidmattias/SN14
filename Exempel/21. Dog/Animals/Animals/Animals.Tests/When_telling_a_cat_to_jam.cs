using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Animals;

namespace Animals.Tests
{
    public class When_telling_a_cat_to_jam
    {
        [Fact]
        public void The_cat_doesnt_jam_for_no_treats()
        {
            var cat = new Cat();
            var responses = cat.Jam(0);

            Assert.Equal(0, responses.Count);
        }

        [Fact]
        public void The_cat_jams_once_for_one_treat()
        {
            var cat = new Cat();
            var responses = cat.Jam(1);

            Assert.Equal(1, responses.Count);
        }

        [Fact]
        public void The_doesnt_jam_in_his_sleep()
        {
            var cat = new Cat();
            cat.Sleep(5);

            //Assert.Equal(1, responses.Count);
        }
    }
}
