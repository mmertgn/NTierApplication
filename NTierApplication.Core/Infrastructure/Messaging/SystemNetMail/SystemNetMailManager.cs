using NTierApplication.Core.Infrastructure.Messaging.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NTierApplication.Core.Infrastructure.Messaging.SystemNetMail
{
    public class SystemNetMailManager : IMessaging
    {
        private bool _isSucceed = false;

        public bool IsSucceed
        {
            get
            {
                return _isSucceed;
            }
        }

        public void SendMessage(MessageTemplate msj)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress(msj.From);
           
            foreach (var item in msj.To)
            {
                message.To.Add(item);
            }

            message.Body = msj.MessageBody;
            message.Subject = msj.MessageSubject;

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;

            client.Credentials = new NetworkCredential("yazilim16.net@gmail.com", "WissenYazilim16");

            client.EnableSsl = true;

            try
            {
                client.Send(message);
                _isSucceed = true;
               
            }
            catch (Exception)
            {
                _isSucceed = false;
            }
        }
    }
}
