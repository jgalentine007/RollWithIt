using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollWithIt
{
    /// <summary>
    /// System random number generator.
    /// </summary>
    public class SystemRandom : IRandomGenerator
    {
        Random rand = new Random();
        /// <summary>
        /// Return a random integer within a specified range using the System Random class.
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns>Random integer.</returns>
        public int Next(int minValue, int maxValue)
        {
            return rand.Next(minValue, maxValue);
        }
    }
}
