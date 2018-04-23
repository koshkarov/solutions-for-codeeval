using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleSort
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

                    List<double> list = new List<double>();
                    list = line.Split(' ').ToList().ConvertAll(item => double.Parse(item));

                    list.Sort();

                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.Write(String.Format("{0:0.000}", list[i]));

                        if (i != list.Count - 1)
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
        }
    }
}
