using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

namespace CalculateDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "([-]*[0-9]+)";

            using (StreamReader reader = File.OpenText(args[0]))

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (line == null)
                        continue;

                    List<int> coord = new List<int>();

                    foreach (Match m in Regex.Matches(line, pattern))
                    {
                        coord.Add(Int32.Parse(m.Value));
                    }

                    double ans = Math.Sqrt(Math.Pow((coord[2] - coord[0]), 2) + Math.Pow((coord[3] - coord[1]), 2));
                    Console.WriteLine(ans.ToString());
                }
        }
    }
}
