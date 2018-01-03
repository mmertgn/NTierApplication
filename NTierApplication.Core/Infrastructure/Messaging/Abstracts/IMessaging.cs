using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApplication.Core.Infrastructure.Messaging.Abstracts
{
    public class MessageTemplate
    {
        public string From { get; set; }
        public List<string> To { get; set; }
        public string MessageBody { get; set; }
        public string MessageSubject { get; set; }


    }

    public interface IMessaging
    {
        bool IsSucceed { get; }
        void SendMessage(MessageTemplate msj);
    }
}
