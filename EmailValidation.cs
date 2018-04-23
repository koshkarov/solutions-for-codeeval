using System;
using System.IO;
using System.Net.Mail;


namespace EmailValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine().ToLower();

                    if (line == null || line == "")
                        continue;

                    // Instead of using a regular expression to validate an email address, 
                    // we can use the System.Net.Mail.MailAddress class. 
                    // To determine whether an email address is valid, 
                    // pass the email address to the MailAddress.MailAddress(String) class constructor.

                    try
                    {
                        MailAddress m = new MailAddress(line);

                        Console.WriteLine("true");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("false");
                    }
                }
        }
    }
}