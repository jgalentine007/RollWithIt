using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Media;

namespace RollWithIt
{
    /// <summary>
    /// Game view model.
    /// </summary>
    public class Game : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // commands
        private DelegateCommand _shakeCommand;
        public ICommand ShakeCommand { get { return _shakeCommand; }}

        private IRandomGenerator _generator;
        public Die Die1 { get; set; }
        public Die Die2 { get; set; }
        public Shaker Shaker { get; set; }

        public Game(IRandomGenerator generator)
        {
            // commands
            _shakeCommand = new DelegateCommand(Shake);
            _generator = generator;

            Die1 = new Die(_generator);
            Die2 = new Die(_generator);
            Shaker = new Shaker();
        }

        /// <summary>
        /// Shake the shaker.
        /// </summary>
        public void Shake()
        {
            Shaker.Empty();
            Shaker.AddDie(Die1);
            Shaker.AddDie(Die2);
            Shaker.Shake();
            SoundPlayer simpleSound = new SoundPlayer("shake-bake.wav");
            simpleSound.Play();
        }
    }
}
