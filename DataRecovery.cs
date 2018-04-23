using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EASY___DATA_RECOVERY
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("No arguments or more than 1 passed.");
            }

            string fullPath = Path.GetFullPath(args[0]);

            try
            {

                using (StreamReader reader = File.OpenText(fullPath))
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        int elementsCount = 0;

                        var data = line.Split(';').ToArray();

                        var words = data[0].Split(' ').ToArray();
                        var indices = data[1].Split(' ').Select(Int32.Parse).ToList();

                        Console.Write("DEBUG: {0}, {1}", words.Count, indices.Count);

                        // Check if the number of elements in both arrays is the same
                        if (words.Length == indices.Length)
                            elementsCount = words.Length;
                        else
                            Console.WriteLine("ERROR");

                        // Create sorted dictionary
                        SortedDictionary<int, string> map = new SortedDictionary<int, string>();

                        // Add elemets to the sorted dictionary
                        for (int i = 0; i < elementsCount; i++)
                            map.Add(indices[i], words[i]);

                        
                        foreach (var pair in map)
                            Console.Write(pair.Value.ToString() + " ");

                        Console.Write("\n");
                    }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found: {0}", e);
            }
        }
    }
}
