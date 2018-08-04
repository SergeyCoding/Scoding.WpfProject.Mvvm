using System.Net.Mime;
using System.Windows;
using Scoding.WpfProject.Constants;
using Scoding.WpfProject.DI;
using SiSoP.Common.Operations;
using SiSoP.Common.Service;

namespace Scoding.WpfProject
{
    internal class AppDispatcher : IInitializable
    {
        private readonly ILogger _logger = WpfProjectContainer.Resolve<ILogger>();

        public void Initialize()
        {
            _logger.Info("Start");

            Application.Current.Exit += Current_Exit;
            Application.Current.DispatcherUnhandledException += Current_DispatcherUnhandledException;

            WpfProjectContainer.SendMessage(AppMsgConst.Start,AppMsgConst.AppDispather);
        }

        private void Current_Exit(object sender, ExitEventArgs e)
        {
            _logger.Info("Finish");
        }

        private void Current_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            e.Handled = true;
        }
    }
}