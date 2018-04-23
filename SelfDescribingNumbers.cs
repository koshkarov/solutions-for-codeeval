using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SelfDescribingNumbers
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
                // init var for resolution
                int selfDescr = 1;

                // Go through each digit in number
                for (int i = 0; i < line.Length; i++)
                {
                    // Convert index number to char
                    char k = i.ToString().ToCharArray()[0];

                    // Verify the digit in each position is equal 
                    // to the number of times that that digit appears 
                    // in the number is
                    if (line[i].ToString() != line.Count(x => x == k).ToString())
                    {
                        // if not equal - not self describing number
                        selfDescr = 0;
                    }
                }
                Console.WriteLine(selfDescr);
            }
        }
    }
}
