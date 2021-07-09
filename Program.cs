using System;

namespace Day5Assignments
{
    class Flipcoin
    {
        static void Main(string[] args)
        {
     
            double coinflip;
            int headcount=0;
            int tailcount=0;
           
            Console.WriteLine("No of Times to Flip coin");
           int n=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Random random = new Random();
                coinflip = random.NextDouble(); //To generate double random numbers b/w 0 and 1
                Console.WriteLine(coinflip);

                if (coinflip < 0.5)
                {

                    Console.WriteLine("Tails");
                    tailcount++;
                }

                else
                {
                    Console.WriteLine("Head");
                    headcount++;
                }

            }
                double PercentageofHeads = (headcount * 100 / n);
                double PercentageofTails = (tailcount * 100 / n);
                Console.WriteLine("Percentage of head is = " + PercentageofHeads);
                Console.WriteLine("Percentage of Tail is = " + PercentageofTails);

            
        }
    }
}
