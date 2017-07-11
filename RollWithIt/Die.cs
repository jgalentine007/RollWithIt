using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollWithIt
{
    public class Die
    {
        private IRandomGenerator _generator;
        public int Sides { get; }
        
        /// <summary>
        /// Create a die with the number of specified sides. Specified sides must be great or equal to 1.
        /// </summary>
        /// <param name="generator">Random number generator.</param>
        /// <param name="sides">Number of sides</param>
        public Die(IRandomGenerator generator, int sides)
        {
            if (sides < 1)
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
        /// <param name="sides">Number of sides. Unspecified default value is '6'.</param>
        public Die(int sides = 6) : this(new SystemRandom(), sides)
        {

        }

        /// <summary>
        /// 'Roll' the die and return a random side value.
        /// </summary>
        /// <returns>Random side value.</returns>
        public int Roll()
        {
            int result = _generator.Next(1, Sides);
            return result;
        }
    }
}
