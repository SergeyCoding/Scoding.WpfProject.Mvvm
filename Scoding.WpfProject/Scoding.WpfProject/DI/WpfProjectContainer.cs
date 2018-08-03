using Autofac;
using SiSoP.Common.Service.Autofac;

namespace Scoding.WpfProject.DI
{
    /// <summary>
    /// 
    /// </summary>
    public class WpfProjectContainer
    {

        public static WpfProjectContainer Instance { get; } = new WpfProjectContainer();

        public IContainer Container { get; }

        public static T Resolve<T>()
        {
            return Instance.Container.Resolve<T>();
        }

        public WpfProjectContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<LoggerServiceModule>();
            builder.RegisterModule(ChainHandlersModule.Create());
            builder.RegisterModule<SendMessageModule>();
            


            Container = builder.Build();
        }
    }
}