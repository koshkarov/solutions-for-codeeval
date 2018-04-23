using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromicNumbers
{
    class Program
    {

        public static bool isPalindromeQ(int x)
        {
            string str = "" + x;
            char[] arr = str.ToArray();
            Array.Reverse(arr);

            if (str == String.Join("", arr))
            {
                return true;
            }

            return false;
        }

        public static bool isPrime(int x)
        {

            if (x % 2 == 0 || x < 2)
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
            IEnumerable<int> range = Enumerable.Range(1, 999);

            int lastPP = 0;

            foreach (int num in range)
            {
                // Console.WriteLine("Sending: " + num);
                if (isPrime(num) && isPalindromeQ(num))
                {
                    lastPP = num;
                }
            }

            Console.WriteLine("" + lastPP);
        }
    }
}
