using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HexToDecimal
{
    class Program
    {

        const int MATRIX_ROWS = 256;
        const int MATRIX_COLS = 256;

        static public int[,] matrix = new int[MATRIX_ROWS, MATRIX_COLS];

        static void generateMatrix()
        {

            for (int x = 0; x < MATRIX_ROWS; x++)
            {
                for (int y = 0; y < MATRIX_COLS; y++)
                {
                    matrix[x,y] = 0;
                }
            }
        }

        static void SetCol(int col, int value)
        {
            // Set value for col elements

            for (int row = 0; row < MATRIX_ROWS; row++)
            {
                matrix[row, col] = value;
            }
        }

        static void SetRow(int row, int value)
        {
            // Set value for row elements

            for (int col = 0; col < MATRIX_COLS; col++)
            {
                matrix[row, col] = value;
            }

        }

        static int QueryCol(int col)
        {
            int sum = 0;

            for (int row = 0; row < MATRIX_ROWS; row++)
            {
                sum += matrix[row, col];
            }
            return sum;
        }

        static int QueryRow(int row)
        {
            int sum = 0;
            for (int col = 0; col < MATRIX_COLS; col++)
            {
                sum += matrix[row, col];
            }
            return sum;
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

            // Generate matrix woth zero's
            generateMatrix();

            // Read instructions
            foreach (string line in lines)
            {
                var data = line.Split(' ');

                switch (data[0])
                {
                    case "SetRow":
                        SetRow(Int32.Parse(data[1]), Int32.Parse(data[2]));
                        break;
                    case "SetCol":
                        SetCol(Int32.Parse(data[1]), Int32.Parse(data[2]));
                        break;
                    case "QueryRow":
                        Console.WriteLine(QueryRow(Int32.Parse(data[1])).ToString());
                        break;
                    case "QueryCol":
                        Console.WriteLine(QueryCol(Int32.Parse(data[1])).ToString());
                        break;
                    default:
                        Console.WriteLine("\nWrong instruction {0}\n", data[0]);
                        break;

                }
            }
        }
    }
}
