using System;

namespace PowerOfTwo
{
    class PowerofTwo
    {
        static void Main()
        {
            double result;
            Console.WriteLine("Enter the Value of N (N less than 31) :");
            int n = Convert.ToInt32(Console.ReadLine());
                   
       
                for (int i = 1; i < n; i++)
                {
                    result = Math.Pow(2, i);
                    Console.WriteLine(result);


                }
            

        }
    }
}
