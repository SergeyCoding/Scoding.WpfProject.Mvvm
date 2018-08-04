using System.Windows;
using Scoding.WpfProject.DI;

namespace Scoding.WpfProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            WpfProjectContainer.Resolve<AppDispatcher>();
        }
    }
}
