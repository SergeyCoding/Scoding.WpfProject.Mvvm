using System;
using SiSoP.Common.ChainDispatcher;
using SiSoP.Common.SendMessage;

namespace Scoding.WpfProject.Handlers
{
    /// <summary>
    /// 
    /// </summary>
    class StopHandler : ChainHandlerBase
    {
        public StopHandler(IChainHandler handler) : base(handler)
        {
        }

        protected override bool Condition(SendMessageContext message)
        {
            return message.Msg == AppMsgConst.Start;
        }

        protected override void Accept(SendMessageContext message)
        {
            throw new NotImplementedException();
        }
    }
}
