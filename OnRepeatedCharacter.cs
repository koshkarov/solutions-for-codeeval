using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace onRepeatedCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    char[] charArr = new char[line.Length];

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (!line.Substring(i + 1).Contains(line[i]) && !charArr.Contains(line[i]))
                        {
                            Console.WriteLine(line[i].ToString());
                            break;
                        }

                        charArr[i] = line[i];
                        continue;
                    }
                }
        }
    }
}