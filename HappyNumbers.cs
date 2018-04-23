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
        static int isHappy(int x, int count)
        {
            if (count == 20)
            {
                return 0;
            }
            else if (x == 1)
            {
                return 1;
            }
            else
            {
                return isHappy((x.ToString().Sum(c => (c - '0') * (c - '0'))), count += 1);
            }
        }
        
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
                
                if (isHappy(Int32.Parse(line), 0) == 1)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
