using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SumOfIntegersFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check argument for existance
            // Accept only one argument
            if (args.Length != 1)
            {
                Console.WriteLine("Use text file as an argument:\nprogram.exe hello.txt");
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
            int sum = 0;

            foreach (string line in lines)
            {
                sum += Int32.Parse(line);
            }

            Console.WriteLine("" + sum);
        }
    }
}
