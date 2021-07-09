using System;

namespace PrimeFactorsOfN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the Number to find Prime factors.");
            n=int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                while(n % i  == 0)
                {
                    Console.Write(i + " ");
                    n /= i;

                }
            }
                Console.ReadLine();

            }
    }
}
