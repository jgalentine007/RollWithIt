using Xunit;
using RollWithIt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace RollWithIt.Tests
{
    [ExcludeFromCodeCoverage]
    public class ShakerTests
    {
        [Fact]
        public void AddDieTest()
        {
            var generator = new MockRandom();
            var die = new Die(generator);
            var shaker = new Shaker();
            shaker.AddDie(die);
            Assert.True(shaker.dice.Count == 1);
        }

        [Fact]
        public void ShakeTest()
        {
            var generator = new MockRandom();
            var die = new Die(generator);
            var shaker = new Shaker();
            shaker.AddDie(die);
            shaker.Shake();
            Assert.True(shaker.dice.First().FaceValue == MockRandom.DEFAULT_VALUE);
        }
    }
}