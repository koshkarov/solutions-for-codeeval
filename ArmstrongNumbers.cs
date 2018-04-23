using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HexToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Use text file as an argument:\nprogram.exe hello.txt");
            }

            FileInfo file = new FileInfo(args[0]);

            if (!file.Exists)
            {
                Console.WriteLine("File '{0}' doesn't exist.", args[0]);
            }

            string[] lines = File.ReadAllLines(file.FullName);

            foreach (string line in lines)
            {

                if (Int32.Parse(line) == line.Sum(c => Math.Pow(Int32.Parse(c.ToString()), line.Length)))
                {
                    Console.WriteLine("True");
                }
                else
                    Console.WriteLine("False");
            }
        }
    }
}
