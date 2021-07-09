using System;

namespace HarmonicSeries
{
    class Program
    {
       public static void Main(string[] args)
        {
            try      //just put exception, incase if user entered something else
            {


                Console.Write("Enter Value of N : ");
                int n = Convert.ToInt32(Console.ReadLine());
                //Formula : hn=h*(n-1) + (1/n)
                double hn = 0;
                for (double i = 1; i < n; i++)
                {

                    hn += 1 / i;

                }

               Console.WriteLine("The harmonic Sum is" + hn);
            } 

            catch(Exception e)                      //for throwing error, instead of exiting from program
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();








        }
    }
}
