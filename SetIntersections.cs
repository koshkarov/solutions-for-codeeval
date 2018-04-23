using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SetIntersections
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Use text file as an argument:\nprogram.exe hello.txt");
            }

            FileInfo file = new FileInfo(args[0]);

            if (!file.Exists)
            {
                Console.WriteLine("File '{0}' doesn't exist.", args[0]);
            }

            string[] lines = File.ReadAllLines(file.FullName);

            foreach (string line in lines)
            {
                List<string> list = line.Split(';').ToList();

                //Create list of intersected elements
                var newData = list[0].Split(',').ToList().Intersect(list[1].Split(',').ToList());

                Console.WriteLine("{0}", String.Join(",", newData));
            }

        }
    }
}
