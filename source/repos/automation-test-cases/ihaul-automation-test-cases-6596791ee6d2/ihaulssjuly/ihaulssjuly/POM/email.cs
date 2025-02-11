//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MailKit.Net.Imap;
//using MailKit.Security;
//using MimeKit;
//using System.Text.RegularExpressions;
//using MailKit.Search;

//public class EmailHelper:Program
//{
//    public static string GetOtpFromEmail(string emailAddress, string password, string subjectFilter)
//    {
//        using (var client = new ImapClient())
//        {
//            // Connect to the IMAP server
//            client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
//            client.Authenticate(emailAddress, password);

//            var inbox = client.Inbox;
//            inbox.Open(MailKit.FolderAccess.ReadOnly);

//            // Search for emails matching the subject filter
//            var query = SearchQuery.SubjectContains(subjectFilter);
//            var uids = inbox.Search(query);

//            if (uids.Count == 0) // Correct way to check if there are no emails
//                throw new Exception("No emails found with the specified subject filter.");

//            // Fetch the latest email
//            var message = inbox.GetMessage(uids[uids.Count - 1]);
//            var body = message.TextBody;

//            // Extract OTP (assuming it's a 6-digit number)
//            var otpMatch = Regex.Match(body, @"\b\d{6}\b");
//            if (otpMatch.Success)
//                return otpMatch.Value;

//            throw new Exception("OTP not found in the email body.");
//        }
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        // Email credentials and subject filter
//        string emailAddress = "swamy.kalluri@i-raysolutions.com";
//        string password = "731452626@iray";
//        string subjectFilter = "OTP to verify your email is"; // The subject or part of the subject to filter emails

//        try
//        {
//            // Retrieve OTP from email
//            string otp = EmailHelper.GetOtpFromEmail(emailAddress, password, subjectFilter);

//            // Output the OTP to the console or use it in your test
//            Console.WriteLine($"The OTP is: {otp}");
//        }
//        catch (Exception ex)
//        {
//            // Handle exceptions
//            Console.WriteLine($"An error occurred: {ex.Message}");
//        }
//    }
//}