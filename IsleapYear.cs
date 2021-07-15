using System;

namespace IsLeapYear
{
    class IsLeapYear
    {
        static void Main(string[] args)
        {
            int isleap = 0;

            Console.WriteLine("Enter the year in YYYY ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4) != 0)
            {
            }

            else if ((year % 400) == 0)
            {

                isleap = 1;

            }

            else if ((year % 100) == 0)
            {


            }
            else
            {
                isleap = 1;
            }



            if (isleap == 1)
            {
                Console.WriteLine("Its a LeapYear");
            }
            else
            {
                Console.WriteLine("Not a Leapyear");
            }

            Console.ReadKey();

        }


        
    }
}
