using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using Newtonsoft.Json;
using WCFTestFramework.Extensions;

namespace WCFTestFramework
{
    internal class MessageInspector : IClientMessageInspector
    {
        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
            ConsoleEx.WriteLineWithColor("[Inbound message]", ConsoleColor.Yellow);

            ConsoleEx.WriteLineWithColor(reply.ToString(), ConsoleColor.Blue);
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            ConsoleEx.WriteLineWithColor("[Outbond message]", ConsoleColor.Yellow);

            ConsoleEx.WriteLineWithColor(request.ToString(), ConsoleColor.Blue);

            return null;
        }
    }
}
