using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Easy___MULTIPLES_OF_A_NUMBER
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("No arguments or more than 1 passed.");
            }

            string fullPath = Path.GetFullPath(args[0]);

            try
            {

                using (StreamReader reader = File.OpenText(fullPath))
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        var n = line.Split(',').Select(Int32.Parse).ToList();

                        Console.WriteLine(multiplesfOANumber(n[0], n[1], n[1]).ToString());
                    }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found: {0}", e);
            }

            Console.ReadKey();
        }

        static int multiplesfOANumber(int x, int n, int multiple)
        {
            return (multiple >= x ? multiple : multiplesfOANumber(x, n, multiple + n));
        }
    }
}
