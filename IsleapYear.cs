using System;

namespace IsLeapYear
{
    class IsLeapYear
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the year in YYYY ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 100 == 0) && (year % 400 == 0) && (year % 4 == 0))
            {
                Console.WriteLine("Entered year is a LEAP YEAR");
            }
            else
            {
                Console.WriteLine("Entered year is not a LEAP YEAR");
            }

            Console.ReadLine();
        }
    }
}
