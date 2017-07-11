using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollWithIt
{
    public class SystemRandom : IRandomGenerator
    {
        /// <summary>
        /// Return a random integer within a specified range using the System Random class.
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns>Random integer.</returns>
        public int Next(int minValue, int maxValue)
        {
            var rand = new Random();
            return rand.Next(minValue, maxValue);
        }
    }
}
