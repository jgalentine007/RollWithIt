using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollWithIt
{
    public class Shaker
    {
        public ICollection<Die> dice { get; private set; }

        public Shaker()
        {
            dice = new List<Die>();
        }

        public void AddDie(Die die)
        {
            dice.Add(die);
        }

        public void Shake()
        {
            foreach (Die die in dice)
            {
                die.Roll();
            }
        }
    }
}
