using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;

namespace Bibloteka.BusinessLogicLayer
{
    public class NjoftimiService
    {
        private static readonly NameValueCollection Settings = ConfigurationManager.AppSettings;
        private readonly string _password = Settings["password"];
        public SmtpClient ConfigureClient()
        {
            var client = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential
                {
                    UserName = Email,
                    Password = _password
                }
            };
            return client;
        }

        public string Email { get; } = Settings["email"];
        public string From { get; } = Settings["from"];
    }
}
