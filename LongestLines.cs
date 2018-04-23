using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LongestLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> lng = new Dictionary<int, int>();
            List<string> lines = new List<string>();
            int linesCounter = 0;
            int counter = 0;

            using (StreamReader reader = File.OpenText(args[0]))

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (line == null)
                        continue;
                    lines.Add(line);

                    lng.Add(linesCounter, line.Length);
                    linesCounter++;
                }

            foreach (KeyValuePair<int, int> x in lng.OrderByDescending(x => x.Value))
            {
                if (counter < Int32.Parse(lines[0]))
                {
                    Console.WriteLine(lines[x.Key]);
                    counter++;
                }
                else
                    break;
            }
        }
    }
}
