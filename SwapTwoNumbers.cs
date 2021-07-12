using System;

namespace SwapTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("value of a and b before swap, a = " + a + " b = " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            
            Console.WriteLine("values of a and b after  swapping!! a = "+a+" b= "+b);
            Console.ReadLine();


        }
    }
}
