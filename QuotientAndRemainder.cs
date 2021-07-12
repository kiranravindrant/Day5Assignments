using System;

namespace QuotientAndRemainder
{
    class QuotientAndRemainder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int Num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Divider ");
            int  Div = Convert.ToInt32(Console.ReadLine());

            int Quotient = (Num / Div);
            Console.WriteLine("Quotient is = " + Quotient);

            int Remainder = (Num % Div);
            Console.WriteLine("Remainder is = " + Remainder);
        }
    }
}
