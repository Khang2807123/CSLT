using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

class Exercise_4
{
    static void Main(string[]args)
    {
        {
             //b1();
             //b2();
             //b3();
             //b4();
             //b5();
             //b6();
             //b7();
             //b8();
        }
        static void b1()
        {
            Console.Write("Enter the first side of the triangle: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the second side of the triangle: ");
            double side2 = double.Parse(Console.ReadLine());
            Console.Write("Enter the third side of the triangle: ");
            double side3 = double.Parse(Console.ReadLine());

            if(side1 == side2)
            {
                if(side1 == side3)
                {
                    Console.WriteLine("The triangle is equilateral.");
                }
                else
                {
                    Console.WriteLine("The triangle is isosceles.");
                }
            }
            else
            {
                if (side1 == side3)
                {
                    Console.WriteLine("The triangle is isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is scalene.");
                }
            }
        }
        static void b2()
        {
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double num3 = double.Parse(Console.ReadLine());
            Console.Write("Enter the fourth number: ");
            double num4 = double.Parse(Console.ReadLine());
            Console.Write("Enter the fifth number: ");
            double num5 = double.Parse(Console.ReadLine());
            Console.Write("Enter the sixth number: ");
            double num6 = double.Parse(Console.ReadLine());
            Console.Write("Enter the seventh number: ");
            double num7 = double.Parse(Console.ReadLine());
            Console.Write("Enter the eighth number: ");
            double num8 = double.Parse(Console.ReadLine());
            Console.Write("Enter the nineth number: ");
            double num9 = double.Parse(Console.ReadLine());
            Console.Write("Enter the tenth number: ");
            double num10 = double.Parse(Console.ReadLine());

            double sum_num = num1+num2+num3+num4+num5+num6+num7+num8+num9+num10;
            double avrg_num = sum_num/10;
            
            Console.WriteLine($"The sum is {sum_num}");
            Console.WriteLine($"The average is {avrg_num}");
        }
        static void b3()
        {
            for (int i = 1; i <= 10; i++)
            {
                int n = 4;
                Console.WriteLine($"{i} * {n} = {i*n}");
            }
        }

        static void b4()
        {
            int b = 4;
            for (int a = 1; a<=b; a++)
            {
                for (int c = 1; c<=a; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }
}