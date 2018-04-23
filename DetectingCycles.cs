/* 
 * DETECTING CYCLES
 * CHALLENGE DESCRIPTION:
 * Given a sequence, write a program to detect cycles within it.
 * 
 * INPUT SAMPLE:
 * 
 * Your program should accept as its first argument a path to a filename containing a sequence of numbers (space delimited). The file can have multiple such lines. E.g
 * 2 0 6 3 1 6 3 1 6 3 1
 * 3 4 8 0 11 9 7 2 5 6 10 1 49 49 49 49
 * 1 2 3 1 2 3 1 2 3
 * 
 * OUTPUT SAMPLE:
 * 
 * Print to stdout the first cycle you find in each sequence. Ensure that there are no trailing empty spaces on each line you print. E.g.
 * 6 3 1
 * 49
 * 1 2 3
 * Constrains:
 * The elements of the sequence are integers in range [0, 99] 
 * The length of the sequence is in range [0, 50]
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DetectingCycles
{
    class Program
    {

        static int isValidCycle(int[] sequence, int position, int length)
        {
            if (length >= sequence.Length)
            {
                return -1;
            }
            else
            {
                // 
                int[] lastA = sequence.Skip(position).Take(length).ToArray();
                int[] prevA = sequence.Skip(position - length).Take(length).ToArray();

                return (lastA.SequenceEqual(prevA) ? position : isValidCycle(sequence, position - 1, length + 1));
            }
        }
        static void Main(string[] args)
        {

            using (StreamReader reader = File.OpenText(args[0]))

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    int[] sequence = line.Split(' ').Select(Int32.Parse).ToArray();

                    // Get the position of cycle starting element
                    int cycleStartPositionFromEnd = isValidCycle(sequence, sequence.Length - 1, 1);

                    // Get the cycle sequence to the array
                    int[] resultArr = sequence.Skip(cycleStartPositionFromEnd).Take(sequence.Length-1).ToArray();

                    // Concatenate all elements to the string
                    string result = string.Join(" ", resultArr);

                    // Print the result
                    Console.WriteLine(result);

                }
        }
    }
}
