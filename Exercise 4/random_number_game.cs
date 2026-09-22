using System;
using System.Collections;
using System.Globalization;
class RNG
{
    static void Main()
    {
        Random rnd = new Random();
        int ran_num = rnd.Next(11);
        Console.WriteLine(ran_num);
        int max_try = 3;
        int guessing_count = 0;
        int tien = 200;
        
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Hint: It is a number from 0-10.");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"Your money is: {tien}");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("Enter your guessing number: ");
        int guessing_num = int.Parse(Console.ReadLine());
        
        while(guessing_count < max_try)
        {
            if (guessing_num == ran_num)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Your answer is correct, congratulation!!!");
                tien += 200;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Your money is: {tien}");
                break;
            }
            else
            {
                if (guessing_num > ran_num)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong!!! Your guess is more than the answer.");
                    tien -= 50;
                }
                else if (guessing_num < ran_num)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong!!! Your guess is less than the answer.");
                    tien -= 50;
                }

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"The remaining money is: {tien}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Please try again: ");
                guessing_num = int.Parse(Console.ReadLine());
                guessing_count += 1;

                if (guessing_count == max_try)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"You are out of attemps, the correct number is {ran_num}.");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("The remaining money is: 0");
                    break;
                }
            }
        }
    }
}