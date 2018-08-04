using System;
using Scoding.WpfProject.Constants;
using Scoding.WpfProject.DI;
using SiSoP.Common.ChainDispatcher;
using SiSoP.Common.SendMessage;

namespace Scoding.WpfProject.Handlers
{
    /// <summary>
    /// 
    /// </summary>
    class StartHandler : ChainHandlerBase
    {
        public StartHandler(IChainHandler handler) : base(handler)
        {
        }

        protected override bool Condition(SendMessageContext message)
        {
            return message.Msg == AppMsgConst.Start;
        }

        protected override void Accept(SendMessageContext message)
        {
            
        }
    }
}
