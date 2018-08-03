using Autofac;
using SiSoP.Common.Service;
using SiSoP.Common.Service.NLog;

namespace Scoding.WpfProject.DI
{
    class LoggerServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<NLogWrapper>().As<ILogger>();
        }
    }
}
