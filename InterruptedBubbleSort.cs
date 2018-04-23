using System;
using System.Linq;
using System.IO;

namespace InterruptedBubbleSort
{
    class Program
    {
        public static int[] doBubbleSortNTimes(int[] intsArr, int n)
        {
            n = Math.Min(intsArr.Length - 1, n);

            while (n > 0)
            {
                n -= 1;
                for (int i = 0; i < intsArr.Length - 1; i++)
                {
                    if (intsArr[i] > intsArr[i + 1])
                    {
                        int temp = intsArr[i];
                        intsArr[i] = intsArr[i + 1];
                        intsArr[i + 1] = temp;
                    }
                }
            }
            return intsArr;
        }

        static void Main(string[] args)
        {
            int iterations = 0;

            using (StreamReader reader = File.OpenText(args[0]))

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (line == null)
                        continue;

                    var data = line.Split(new string[] { " | " }, StringSplitOptions.None).ToArray();

                    bool validNumber = Int32.TryParse(data[1], out iterations);

                    if (validNumber)
                    {
                        int[] ints = Array.ConvertAll(data[0].Split(' '), int.Parse);
                        Console.WriteLine(String.Join(" ", doBubbleSortNTimes(ints, iterations)));
                    }
                    else
                    {
                        Console.WriteLine(data[0]);
                        continue;
                    }

                    
                }
        }
    }
}
