using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace RollWithIt
{
    public enum DieShape
    {
        D4 = 4,
        D6 = 6,
        D8 = 8,
        D12 = 12,
        D20 = 20
    }

    /// <summary>
    /// A multi sided playing dice.
    /// </summary>
    public class Die : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private IRandomGenerator _generator;
        public DieShape Shape { get; set; }
        public int? FaceValue { get; private set; }
                
        /// <summary>
        /// Create a die with the number of specified sides. Specified sides must be great or equal to <see cref="_MINIMUM_SIDES"/>.
        /// </summary>
        /// <param name="generator">Random number generator.</param>
        /// <param name="sides">Number of sides. Unspecified default value is <see cref="_MINIMUM_SIDES"/>.</param>
        public Die(IRandomGenerator generator, DieShape shape = DieShape.D6)
        {
            if (System.Enum.IsDefined(typeof(DieShape), shape))
            {
                _generator = generator;
                Shape = shape;
            }
            else
                throw new ArgumentException();
        }

        /// <summary>
        /// 'Roll' the die and return a random side value (1-based).
        /// </summary>
        /// <returns>Random side value.</returns>
        public void Roll()
        {
            FaceValue = _generator.Next(1, (int)Shape + 1);
        }
    }
}
