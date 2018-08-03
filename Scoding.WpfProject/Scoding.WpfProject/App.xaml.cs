using System.Windows;

namespace Scoding.WpfProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            AppDispatcher.Init();
        }
    }
}
