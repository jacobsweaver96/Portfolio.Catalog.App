using System.Windows;

namespace Portfolio.Catalog.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            ContainerKernel.Initialize(new ContainerConfiguration());

            base.OnStartup(e);
        }
    }
}
