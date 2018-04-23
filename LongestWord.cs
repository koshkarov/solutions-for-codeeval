using System;
using System.Linq;
using System.Text;
using System.IO;

namespace LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    // Split on words
                    string[] words = line.Split(' ').ToArray();

                    // Find maximum length of the longest word
                    int maxLength = words.Max(x => x.Length);

                    // Print first word from array with maximum length 
                    Console.WriteLine(words.Where(x => x.Length == maxLength).ToArray()[0]);

                }
        }
    }
}
