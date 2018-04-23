using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check argument for existance
            // Accept only one argument
            if (args.Length != 1)
            {
                Console.WriteLine("Use text file as an argument:\nFizzBuzz.exe hello.txt");
            }

            // Get file info (full path)
            FileInfo file = new FileInfo(args[0]);

            // Check if file exists
            if (!File.Exists(file.FullName))
            {
                Console.WriteLine("File '{0}' doesn't exist.", args[0]);
            }

            // Read from file to an array
            string[] lines = File.ReadAllLines(file.FullName);
            
            foreach (string line in lines)
            {
                string output = "";
                string[] data = line.Split(' ');

                // Create list and generete range
                var list = new List<int>();

                list.AddRange(Enumerable.Range(1, Int32.Parse(data[2])));

                // Go thriugh each number and 
                foreach (int item in list)
                {
                    if (item % Int32.Parse(data[0]) == 0 && item % Int32.Parse(data[1]) == 0)
                    {
                        output += "FB";
                    }
                    else if (item % Int32.Parse(data[0]) == 0)
                    {
                        output += "F";
                    }
                    else if (item % Int32.Parse(data[1]) == 0)
                    {
                        output += "B";
                    }
                    else
                    {
                        output += item;
                    }

                    // Ad dspace between items, except after a last element
                    if (item != Int32.Parse(data[2]))
                    {
                        output += " ";
                    }
                }

                Console.WriteLine(output);
            }

        }
    }
}
