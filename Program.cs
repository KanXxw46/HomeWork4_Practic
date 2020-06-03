using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


class Program
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Token at twilio.com/console
        // DANGER! This is insecure. See http://twil.io/secure
        const string accountSid = "ACca2cc32cced0ea08593360fb95883890";
        const string authToken = "42172c9a2bcd9181d71b1c32c621815e";

        TwilioClient.Init(accountSid, authToken);

        var message = MessageResource.Create(
            body: "Join Earth's mightiest heroes. Like Kevin Bacon.",
            from: new Twilio.Types.PhoneNumber("+14698047075"),
            to: new Twilio.Types.PhoneNumber("+77785361367")
        );

        Console.WriteLine(message.Sid);
    }
}
