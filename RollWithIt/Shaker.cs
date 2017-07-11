using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollWithIt
{
    /// <summary>
    /// A dice shaker, ala Boggle.
    /// </summary>
    public class Shaker
    {
        public ICollection<Die> Dice { get; private set; }

        /// <summary>
        /// Create an empty dice shaker.
        /// </summary>
        public Shaker()
        {
            Dice = new List<Die>();
        }

        /// <summary>
        /// Add a die to the shaker.
        /// </summary>
        /// <param name="die">Die.</param>
        public void AddDie(Die die)
        {
            Dice.Add(die);
        }

        /// <summary>
        /// Remove all dice from the shaker.
        /// </summary>
        public void Empty()
        {
            Dice.Clear();
        }

        /// <summary>
        /// Roll dice inside the shaker.
        /// </summary>
        public void Shake()
        {
            foreach (Die die in Dice)
            {
                die.Roll();
            }
        }
    }
}
