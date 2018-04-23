using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FibonacciSeries
{
    class Program
    {
        public static int getFibonacci(int x)
        {
            if (x < 2)
                return x;
            else
                return getFibonacci(x - 1) + getFibonacci(x - 2);
        }

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

                int num = getFibonacci(Int32.Parse(line));

                Console.WriteLine(num.ToString());
            }
        }
    }
}
