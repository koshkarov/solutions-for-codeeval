using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassTriangle
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int[]> arrayList = new List<int[]>();
            int[] numbers = arrayList.ToArray(new int[arrayList.Count]());

            // Read the 
            using (StreamReader reader = File.OpenText(args[0]))

                while (reader.ReadLine() != null)
                {
                    int[] sequence = reader.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
                    arrayList.Add(sequence);

                    // Print the result
                    Console.WriteLine(result);

                }
        }
    }
}
