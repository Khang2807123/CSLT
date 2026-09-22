using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

class Exercise_4
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{j} *{i,2} = {i*j}      |      ");
            }
            Console.WriteLine();
        }
    }
}