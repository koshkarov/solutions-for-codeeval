using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSize
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
            Console.WriteLine(file.Length.ToString());
        }
    }
}
