﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromicNumbers
{
    class Program
    {
        public static bool isPrime(int x)
        {
            if (x != 2 && x % 2 == 0 || x < 2)
                return false;

            bool prime = true;

            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    prime = false;
                }
            }

            return prime;
        }
        static void Main(string[] args)
        {
            int LIMIT = 1000;
            int count = 0;
            int sum = 0;

            for (int number = 2; count < LIMIT; number++)
            {
                if (isPrime(number))
                {
                    count++;
                    sum += number;
                }
            }

            Console.WriteLine("" + sum);

        }
    }
}
