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
    public class GameTests
    {
        [Fact]
        public void ShakeTest()
        {
            var generator = new StubRandom();
            Game game = new Game(generator);

            game.Shake();

            Assert.True(game.Die1.FaceValue != null);
            Assert.True(game.Die2.FaceValue != null);
        }
    }
}