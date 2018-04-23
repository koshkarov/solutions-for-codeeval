using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PenultimateWord
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (line == null)
                        continue;

                    List<int> data = new List<int>();

                    data = line.Split(' ').ToList().ConvertAll(x => Int32.Parse(x));

                    // Go through each number and 
                    foreach (int i in Enumerable.Range(1, data[2]))
                    {
                        if (i % data[0] == 0 && i % data[1] == 0)
                        {
                            Console.Write("FB");
                        }
                        else if (i % data[0] == 0)
                        {
                            Console.Write("F");
                        }
                        else if (i % data[1] == 0)
                        {
                            Console.Write("B");
                        }
                        else
                        {
                            Console.Write(i.ToString());
                        }

                        // Ad dspace between items, except after a last element
                        if (i != data[2])
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.Write("\n");
                }
        }
    }
}
