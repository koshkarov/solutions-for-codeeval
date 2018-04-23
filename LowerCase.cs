using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check argument for existance
            // Accept only one argument
            if (args.Length != 1)
            {
                Console.WriteLine("Use text file as an argument:\nFizzBuzz.exe hello.txt");
            }

            // Get file info (full path)
            FileInfo file = new FileInfo(args[0]);

            // Check if file exists
            if (!File.Exists(file.FullName))
            {
                Console.WriteLine("File '{0}' doesn't exist.", args[0]);
            }

            // Read from file to an array
            string[] lines = File.ReadAllLines(file.FullName);

            foreach (string line in lines)
            {
                Console.WriteLine(line.ToLower());
            }
        }
    }
}
