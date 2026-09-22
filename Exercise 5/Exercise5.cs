using System;
using System.Text;
using System.Globalization;

namespace CSLT
{
    internal class Exercise_5
    {
        static int Max(int a, int b, int c)
        {
            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            return max;
        }

        static long Factorial(int n)
        {
            long ans = 1;
            for (int i = 1; i <= n; i++)
            {
                ans *= i;
            }
            return ans;
        }

        static bool Prime(int p)
        {
            for (int I=2; I<p; I++)
            {
                if (p%I == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void PrimeNumsLessThanANum(int num)
        {
            for (int i2 = 2; i2 < num; i2++)
            {
                if (Prime(i2))
                {
                    Console.Write(i2+ " ");
                    Console.WriteLine();
                }
                
            }
        }
        static void Main5_1 (string [] args)
        {
            PrimeNumsLessThanANum(79);
        }
    }
}