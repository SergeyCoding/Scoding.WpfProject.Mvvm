using Scoding.WpfProject.DI;
using SiSoP.Common.Operations;
using SiSoP.Common.Service;

namespace Scoding.WpfProject
{
    internal class AppDispatcher : IInitializable
    {
        public static void Init()
        {
            new AppDispatcher().Initialize();
        }

        public void Initialize()
        {
            WpfProjectContainer.Resolve<ILogger>().Info("Start");

            WpfProjectContainer.Resolve<ILogger>().Info("Finish");
        }
    }
}