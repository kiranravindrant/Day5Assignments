using System;

namespace LargestAmongThree
{
    class Program
    {
        static void Main(string[] args)
        {
          
            

                int Num1;
                int Num2;
                int Num3;

                Console.WriteLine("Enter the Number 1 ");
                Num1 = int.Parse(Console.ReadLine());


                Console.WriteLine("Enter the Number 2 ");
                Num2 = int.Parse(Console.ReadLine());


                Console.WriteLine("Enter the Number 3");
                Num3 = int.Parse(Console.ReadLine());

                if (Num1 > Num2 && Num1 > Num3)
                {
                    Console.WriteLine(" Number 1  is greatest =" + Num1);

                }
                else if (Num2 > Num1 && Num2 > Num3)
                {
                    Console.WriteLine(" Number 2  is greatest= " + Num2);

                }
                else 
                {
                    Console.WriteLine("Entered Number 3  is greatest = " + Num3);
                }
                Console.ReadLine();
            }
    }
}
