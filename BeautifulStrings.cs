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
                Dictionary<char, int> dict = new Dictionary<char, int>();

                foreach (char c in line.ToLower())
                {
                    if (c > 96 && c < 123)
                    {
                        if (!dict.ContainsKey(c))
                        {
                            dict.Add(c, line.ToLower().Count(n => n == c));
                        }
                    }
                }

                var sortedDict = from entry in dict orderby entry.Value descending select entry;

                int startValue = 26;
                int stringBeauty = 0;

                foreach (KeyValuePair<char, int> pair in sortedDict)
                {
                    stringBeauty += pair.Value * startValue;
                    startValue--;

                }
                Console.WriteLine("" + stringBeauty);

            }
        }
    }
}
