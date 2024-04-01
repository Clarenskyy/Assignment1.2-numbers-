using System;
//code by DELA CRUZ, CLARENCE KIETH M.
//BSCPE 1-1
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int num = 1; num <= 100; num++) 
            {
                if (num % 15 == 0)   
                {
                    Console.WriteLine("Hello, Goodbye!");
                }
                else 
                {
                    if (num % 3 == 0)
                    {
                        Console.WriteLine("Hello!");
                    }             
                    else
                    {
                        if (num % 5 == 0)
                        {
                            Console.WriteLine("Goodbye!");
                        }
                        else
                        {
                            Console.WriteLine(num);
                            
                        }
                    }
                }
                   
            }
        }
    }
}