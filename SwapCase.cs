using System;
using System.IO;
using System.Linq;

namespace Easy___Swap_Case
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

                        string reversedCase = new string(
                            line.Select(c => char.IsLetter(c) ? (
                                char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)) : c
                                ).ToArray());

                        Console.WriteLine(reversedCase);
                    }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found: {0}", e);
            }

            Console.ReadKey();
        }
    }
}
