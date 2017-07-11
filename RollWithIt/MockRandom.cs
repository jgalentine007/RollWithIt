using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollWithIt
{
    public class MockRandom : IRandomGenerator
    {
        /// <summary>
        /// The mock Next method will always return a deterministic value.
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns>1</returns>
        public int Next(int minValue, int maxValue)
        {
            return 1;
        }
    }
}
