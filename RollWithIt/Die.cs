using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollWithIt
{
    /// <summary>
    /// A multi sided playing dice.
    /// </summary>
    public class Die
    {
        private IRandomGenerator _generator;
        public int Sides { get; }
        public const int MINIMUM_SIDES = 2;

        /// <summary>
        /// Create a die with the number of specified sides. Specified sides must be great or equal to 2.
        /// </summary>
        /// <param name="generator">Random number generator.</param>
        /// <param name="sides">Number of sides. Unspecified default value is '2'.</param>
        public Die(IRandomGenerator generator, int sides = MINIMUM_SIDES)
        {
            if (sides < MINIMUM_SIDES)
                throw new ArgumentOutOfRangeException();
            else
            {
                _generator = generator;
                Sides = sides;
            }
        }

        /// <summary>
        /// Create a die with the number of specified sides. Specified sides must be great or equal to 1.
        /// </summary>
        /// <param name="sides">Number of sides. Unspecified default value is '2'.</param>
        public Die(int sides = MINIMUM_SIDES) : this(new SystemRandom(), sides)
        {

        }

        /// <summary>
        /// 'Roll' the die and return a random side value (1-based).
        /// </summary>
        /// <returns>Random side value.</returns>
        public int Roll()
        {
            int result = _generator.Next(1, Sides);
            return result;
        }
    }
}
