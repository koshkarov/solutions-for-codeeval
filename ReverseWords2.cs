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

                    List<string> list = new List<string>(line.Split(' '));
                    list.Reverse();

                    Console.WriteLine(String.Join(" ", list));
                }
        }
    }
}
