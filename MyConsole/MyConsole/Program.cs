using System;
using System.Linq;

namespace MyConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            
            Console.WriteLine("Enter your Age");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine($"{name} is Eligible to Vote ");
                Console.WriteLine($"hello{name.ToUpper()},your are {age} years old");
            }
            else
            {
                Console.WriteLine($"{name} is not Eligible to Vote");
                Console.WriteLine($"hello{name.ToUpper()},you are{age} year old"); 
            }
            //Math Functions
            Console.WriteLine("Enter the num:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"sum is {a + b}The max number is {Math.Max(a, b)}");
            //Loop
            Console.WriteLine("Enter the num");
            for(int i=0;i<=10;i++)
            {
                if (i%2==0)
                    {
                    Console.WriteLine(i+"number is even");
                    }
                else
                {
                    Console.WriteLine(i+"number is odd");
                }
            
           
            }
            //Array
            int[] num = { 10, 20, 30, 50 };
            Console.WriteLine("Array elements:");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            //two dimensional array
            int[,] arr = { { 2, 4, 6, 8 }, { 1, 3, 5, 7 } };
            Console.WriteLine(arr[1, 2]);
            Console.WriteLine(arr[0,3]);
            //Sort Array
            int[] mynum = { 5, 6, 8, 3, 54, 8 };
            Console.WriteLine(mynum.Max());
            Console.WriteLine(mynum.Min());
            Console.WriteLine("Sum of Array:"+ mynum.Sum());
            //Break and Continue
            for (int i = 0; i <= 10; i++) 
            {
                if(i==5)
                {
                    break;
                }
                Console.WriteLine(i);

            }
        }
        
        

        
    }
}
