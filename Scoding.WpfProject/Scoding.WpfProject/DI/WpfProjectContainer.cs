using Autofac;
using SiSoP.Common.SendMessage;
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

            // AppDispatcher
            builder.RegisterType<AppDispatcher>().OnActivating(AutofacHelper.AutofacInitializeAction);



            Container = builder.Build();
        }

        public static void SendMessage(string msg, string source)
        {
            Resolve<ISendMessageOperation>().Execute(new SendMessageContext { Msg = msg, Source = source });
        }
    }
}