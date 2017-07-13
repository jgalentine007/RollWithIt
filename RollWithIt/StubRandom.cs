using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollWithIt
{    
    /// <summary>
    /// Deterministic mock random number generator.
    /// </summary>
    public class StubRandom : IRandomGenerator
    {
        public const int DEFAULT_VALUE = 1;

        /// <summary>
        /// The mock Next method will always return a deterministic value <see cref="DEFAULT_VALUE"/>.
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns>1</returns>
        public int Next(int minValue, int maxValue)
        {
            return DEFAULT_VALUE;
        }
    }
}
