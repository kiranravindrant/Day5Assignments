﻿using System;

namespace Program
{
    class VowelorConsonant
    {
        static void Main(string[] args)
        {
            char ch;

                Console.WriteLine("Enter any character:A-z ");
                ch = Convert.ToChar(Console.ReadLine());

          
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                {

                    Console.WriteLine(ch + " is Vowel.");

                }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " is Consonant.");
            }
            else
            {
                Console.WriteLine("Invalid Input given");
            }
           
            Console.ReadKey();
            
        }   
    }
}
