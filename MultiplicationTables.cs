using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTables
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    Console.Write("{0}", i*j);
                    if (j != 12)
                    {
                        if (i * j < 10 && (i)*(j+1) < 10)
                        {
                            Console.Write("   ");
                        }
                        else if (i * j < 100 && (i) * (j + 1) < 100)
                        {
                            Console.Write("  ");
                        }
                        else if (i * j < 1000 && (i) * (j + 1) < 1000)
                        {
                            Console.Write(" ");
                        }
                    }
                }

                Console.WriteLine("\n");
            }
        }
    }
}
