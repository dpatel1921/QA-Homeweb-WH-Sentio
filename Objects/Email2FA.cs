/*using System;
using System.Linq;
using System.Text.RegularExpressions;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit.Security;

using MimeKit;
using MimeKit.Text;

namespace Helpers
{
    public static class Email2FA
    {
    
        public static string GetVerificationCodeFromEmail(string email, string appPassword, string subjectKeyword)
        {
            using (var client = new ImapClient())
            {
               
                client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
                client.Authenticate(email, appPassword);

                
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadWrite);

            
                var cutoff = DateTime.UtcNow.AddSeconds(-20);
                var query = SearchQuery.NotSeen
                                        .And(SearchQuery.SubjectContains(subjectKeyword))
                                        .And(SearchQuery.DeliveredAfter(cutoff));
                var uids = inbox.Search(query);

       
                foreach (var uid in uids.Reverse())
                {
            
                    var message = inbox.GetMessage(uid);

               
                    Console.WriteLine("Subject: {message.Subject}");
                    var body = message.TextBody ?? message.HtmlBody;
                    if (string.IsNullOrWhiteSpace(body))
                    {
                        var textPart = message.BodyParts
                      .OfType<TextPart>()
                      .FirstOrDefault();
                        body = textPart?.Text;
                    }
                    Console.WriteLine("Body:\n" + body);

             
                    var match = Regex.Match(
                                           body ?? "",
                                           @"Verification\s*code[:\s]*([0-9]{6})",
                                           RegexOptions.IgnoreCase
                                              );

                 
                    var rawOtp = match.Success ? match.Groups[1].Value : "<no-match>";
                    Console.WriteLine("Matched OTP: '{rawOtp}'");

                    if (match.Success)
                    {
                        var otp = match.Groups[1].Value.Trim();
                        inbox.AddFlags(uid, MessageFlags.Seen, true);
                        client.Disconnect(true);
                        return otp;
                    }
                }

                client.Disconnect(true);
            }

            return null;
        }
    }
}*/
