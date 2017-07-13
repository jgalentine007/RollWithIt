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
            var die = new Die(generator, DieShape.D6);
            die.Roll();

            Assert.True(die.FaceValue >= 1 && die.FaceValue <= (int)DieShape.D6);            
        }

        [Fact]
        public void RollTestMockRandom()
        {
            var generator = new StubRandom();
            var die = new Die(generator, DieShape.D6);
            die.Roll();

            Assert.True(die.FaceValue == StubRandom.DEFAULT_VALUE);
        }

        [Fact]
        public void RollTestInvalidSides()
        {
            var generator = new StubRandom();
            Assert.Throws<ArgumentException>(() => new Die(generator, 0));
        }
    }
}