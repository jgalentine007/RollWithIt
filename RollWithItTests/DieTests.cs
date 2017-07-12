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
    public class DieTests
    {
        [Fact]
        public void RollTestSystemRandom()
        {
            var generator = new SystemRandom();
            var die = new Die(generator);
            die.Roll();

            Assert.True(die.FaceValue >= 1 && die.FaceValue <= 2);            
        }

        [Fact]
        public void RollTestMockRandom()
        {
            var generator = new MockRandom();
            var die = new Die(generator, 6);
            die.Roll();

            Assert.True(die.FaceValue == MockRandom.DEFAULT_VALUE);
        }

        [Fact]
        public void RollTestInvalidSides()
        {
            var generator = new MockRandom();
            Assert.Throws<ArgumentOutOfRangeException>(() => new Die(generator, 0));
        }
    }
}