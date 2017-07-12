using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Autofac;
using System.Diagnostics.CodeAnalysis;

namespace RollWithIt
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static IContainer Container { get; set; }

        /// <summary>
        /// Override OnStartup to use Autofac IoC
        /// </summary>
        /// <param name="e"></param>
        [ExcludeFromCodeCoverage]
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var builder = new ContainerBuilder();
            builder.RegisterType<Game>();
            builder.RegisterType<SystemRandom>().As<IRandomGenerator>();
            Container = builder.Build();

            var gameViewModel = Container.Resolve<Game>();
            var window = new MainWindow { DataContext = gameViewModel };
            window.Show();
        }
    }
}
