using SiSoP.Common.Operations;
using SiSoP.Common.Operations.Generic;

namespace Scoding.WpfProject.Core.Commands
{
    class ModelCommand : IOperation<ModelContext>
    {
        public void Execute(ModelContext context)
        {
            context.Value.C = context.A + context.B;
        }

        public static void RunExecute(ModelContext context)
        {
            OperationFactory.Execute<ModelCommand, ModelContext>(context);
        }
    }
}
