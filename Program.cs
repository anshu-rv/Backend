// See https://aka.ms/new-console-template for more information
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number:");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"the number:{number} is even.");

            }
            else
            {
                Console.WriteLine($"the number:{number} is odd.");
            }



        }

    }
}











