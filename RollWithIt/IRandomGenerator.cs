using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollWithIt
{
    /// <summary>
    /// Random number generator interface.
    /// </summary>
    public interface IRandomGenerator
    {
        int Next(int minValue, int maxValue);
    }
}
