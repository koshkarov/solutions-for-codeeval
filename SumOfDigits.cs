using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
                if (line.Trim().Length != 0)
                {
                    int sum = 0;
                    foreach (char c in line)
                    {
                        int temp;
                        if (Int32.TryParse(c.ToString(), out temp))
                        {
                            sum += temp;
                        }
                        else
                            continue;
                    }
                    Console.WriteLine(sum.ToString());
                }
            }
        }
    }
}
