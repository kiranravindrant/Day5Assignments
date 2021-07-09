using System;

namespace EvenOrOdd
{
    class EvenOrOdd
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number :");
           int n= int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine(("Its an Even Number"));


            }
            else
            {
                Console.WriteLine("Its  an Odd Number");
            }
            Console.ReadKey();
            
        }   
    }
}
