using System;
using System.Collections.Generic;
using System.IO;

namespace CapitalizeWords
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

                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.Write(char.ToUpper(list[i][0]) + list[i].Substring(1));

                        if (i != list.Count - 1)
                            Console.Write(" ");
                    }
                    Console.Write("\n");
                }
        }
    }
}
