using System;
using System.Linq;
class exercise_3
{
    static void Main(string[] args)
    {
        {
         //ptb2();
         //bai1();
         //bai2();
         //bai3();
         //bai4();
        } 

        static void ptb2()
        {
            Console.WriteLine("Phương trình bậc 2 có dạng: ax^2 + bx + c");
            Console.Write("Enter a of function: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b of function: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c of function: ");
            double c = double.Parse(Console.ReadLine());
            double delta = Math.Pow(2,b) - 4 * a * c;
            if (delta > 0)
            {
                Console.WriteLine("Phương trình có 2 nghiệm phân biệt.");
                double nghiem_1 = (-b + Math.Sqrt(delta))/ 2*a;
                double nghiem_2 = (-b - Math.Sqrt(delta))/ 2*a;
                Console.WriteLine($"Nghiệm thứ nhất của phương trình là: {nghiem_1}");
                Console.WriteLine($"Nghiệm thứ hai của phương trình là: {nghiem_2}");
            }
            else if (delta == 0)
            {
                Console.WriteLine("Phương trình có 1 nghiệm kép.");
                double nghiem_kep = -b / (2*a);
                Console.WriteLine($"Nghiệm kép của phương trình là: {nghiem_kep}");
            }
            else
            {
                Console.WriteLine("Phương trình vô nghiệm.");
            }
        }

        static void bai1()
        {
            Console.Write("Enter a number: ");
            double num = double.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"The number {num} is even.");
            }
            else
            {
                Console.WriteLine($"The number {num} is odd.");
            }
        }

        static void bai2()
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int num3 = int.Parse(Console.ReadLine());

            if(num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"The largest number is {num1}.");
                }
                else
                {
                    Console.WriteLine($"The largest number is {num3}.");
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine($"The largest number is {num2}.");
                }
                else 
                {
                    Console.WriteLine($"The largest number is {num3}.");
                }
            }
        }

        static void bai3()
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

        static void bai4()
        {
            Console.Write("Enter the value for X coordinate: ");
            double xvalue = double.Parse(Console.ReadLine());
            Console.Write("Enter the value for Y coordinate: ");
            double yvalue = double.Parse(Console.ReadLine());

            if (xvalue > 0)
            {
                if (yvalue > 0)
                {
                    Console.WriteLine($"The coordinate point ({xvalue},{yvalue}) lies in the First quadrant.");
                }
                else
                {
                    Console.WriteLine($"The coordinate point ({xvalue},{yvalue}) lies in the Fourth quadrant.");
                }
            }
            else
            {
                if (yvalue > 0)
                {
                    Console.WriteLine($"The coordinate point ({xvalue},{yvalue}) lies in the Second quadrant.");
                }
                else
                {
                    Console.WriteLine($"The coordinate point ({xvalue},{yvalue}) lies in the Third quadrant.");
                }
            }
        }

    }
}
      