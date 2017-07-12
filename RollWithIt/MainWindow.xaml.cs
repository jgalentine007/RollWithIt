using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics.CodeAnalysis;
using Pacem.Media.Media3D;
using System.Windows.Media.Media3D;

namespace RollWithIt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [ExcludeFromCodeCoverage]
        public MainWindow()
        {
            InitializeComponent();
            Die1Shape.SelectedItem = DieShape.D6;
            Die2Shape.SelectedItem = DieShape.D6;
        }

        private Visual3D CreateDie(DieShape shape, Color color)
        {
            DiffuseMaterial material = new DiffuseMaterial(new SolidColorBrush(color));
            if (shape == DieShape.D4) return new Tetrahedron() { Material = material };
            else if (shape == DieShape.D6) return new Box(1, 1, 1) { Material = material };
            else if (shape == DieShape.D8) return new Octahedron() { Material = material };
            else if (shape == DieShape.D12) return new Dodecahedron() { Material = material };
            else if (shape == DieShape.D20) return new Icosahedron() { Material = material };
            else throw new ArgumentException();
        }

        private void Die1Shape_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var objs = Die1Display.Children.ToList();
            foreach (var obj in objs) Die1Display.Children.Remove(obj);

            var die = CreateDie((DieShape)Die1Shape.SelectedValue, Colors.Red);
            Die1Display.Children.Add(die);
        }

        private void Die2Shape_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var objs = Die2Display.Children.ToList();
            foreach (var obj in objs) Die2Display.Children.Remove(obj);

            var die = CreateDie((DieShape)Die2Shape.SelectedValue, Colors.Blue);
            Die2Display.Children.Add(die);
        }
    }
}
