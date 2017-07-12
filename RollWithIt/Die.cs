using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace RollWithIt
{
    /// <summary>
    /// A multi sided playing dice.
    /// </summary>
    public class Die : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private IRandomGenerator _generator;
        public int Sides { get; set; }
        public int? FaceValue { get; private set; }
        private const int _MINIMUM_SIDES = 2;
        public int MINIMUM_SIDES { get { return _MINIMUM_SIDES; } }
        private const int _MAXIMUM_SIDES = 20;
        public int MAXIMUM_SIDES { get { return _MAXIMUM_SIDES; } }

        /// <summary>
        /// Create a die with the number of specified sides. Specified sides must be great or equal to <see cref="_MINIMUM_SIDES"/>.
        /// </summary>
        /// <param name="generator">Random number generator.</param>
        /// <param name="sides">Number of sides. Unspecified default value is <see cref="_MINIMUM_SIDES"/>.</param>
        public Die(IRandomGenerator generator, int sides = _MINIMUM_SIDES)
        {
            if (sides < _MINIMUM_SIDES)
                throw new ArgumentOutOfRangeException();
            else
            {
                _generator = generator;
                Sides = sides;                
            }
        }

        /// <summary>
        /// 'Roll' the die and return a random side value (1-based).
        /// </summary>
        /// <returns>Random side value.</returns>
        public void Roll()
        {
            FaceValue = _generator.Next(1, Sides);
        }
    }
}
