using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace EASY___CLEAN_UP_THE_WORDS
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

                        // Initialize a list that wil lcontain matches
                        List<string> matchesList = new List<string>();

                        // Set the regular expression (Addde preprocessing to string to fit the output example)
                        MatchCollection matches = Regex.Matches(line.ToLower(), @"([A-Za-z])+");

                        // Get all matches from the line
                        matchesList = matches.Cast<Match>().Select(match => match.Value).ToList();

                        // Print results
                        Console.WriteLine(String.Join(" ", matchesList));

                    }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found: {0}", e);
            }
        }
    }
}
