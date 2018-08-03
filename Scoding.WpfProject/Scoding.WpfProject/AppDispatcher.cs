using SiSoP.Common.Operations;

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

        }
    }
}