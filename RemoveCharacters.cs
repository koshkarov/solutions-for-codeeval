using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RemoveCharacters
{
    class Program
    {
        static void Main(string[] args)
        { 
            using (StreamReader reader = File.OpenText(args[0]))

                while (!reader.EndOfStream)
                {                    
                    // Split line on 2 strings
                    string[] line = reader.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToArray();

                    
                    foreach(char i in line[0].Trim())
                    {
                        if (line[1].Contains(i))
                        {
                            continue;
                        }

                        Console.Write(i.ToString());
                    }
                    Console.Write('\n');
                }
        }
    }
}
