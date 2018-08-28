using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace ConsoleAppTwilio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find your Account Sid and Token at twilio.com/console
            const string accountSid = "ACa8574533b3e522f0137793cf2460c87d";//"AC4874be86630d88b0295e40be2864bbda";
            const string authToken = "8889f8f273a32a0b2656b4068572c975";//"6bf8073bd0c85f54ce6427c65e97b893";

            TwilioClient.Init(accountSid, authToken);

            //var message = MessageResource.Create(
            //    body: "Join Earth's mightest heroes. Like Kevin Bacon.",
            //    from: new Twilio.Types.PhoneNumber("+15005550006"),
            //    to: new Twilio.Types.PhoneNumber("+919600688497")
            //);

            //Console.WriteLine(message.Sid);
            //Console.ReadLine();

            var messageOptions = new CreateMessageOptions(
                                 new PhoneNumber("+919600688497"));
            messageOptions.From = new PhoneNumber("+17345266121");
            messageOptions.Body = "Hi Anna Working for the Mobile token request Sample annaaa";

            var message = MessageResource.Create(messageOptions);
            Console.WriteLine(message.Body);
            Console.ReadLine();

        }
    }
}
