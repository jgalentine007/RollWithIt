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
            var die = new Die();
            int result = die.Roll();

            Assert.True(result >= 1 && result <= 6);            
        }

        [Fact]
        public void RollTestMockRandom()
        {
            var generator = new MockRandom();
            var die = new Die(generator, 6);
            int result = die.Roll();

            Assert.True(result == 1);
        }

        [Fact]
        public void RollTestInvalidSides()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Die(0));
        }
    }
}