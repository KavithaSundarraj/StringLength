using System;
/*
Exercises C# Working with Strings Problem 2. string length
TODO program that reads from the console a string of maximum 20 characters.
   * If the length of the string is less than 20, 
   * the rest of the characters should be filled with *.
   * Print the resulting string on the console. 
Date: 27/10/2020
*/
namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            String input = Console.ReadLine();
            Console.WriteLine("Output string:");
            //to truncate string of maximum of 20 characters
            if (input.Length > 20 )
                Console.WriteLine(input.Substring(0, 20));
            //to append * if the length of the string is less than 20
            if (input.Length < 20)
            {
                for (int i = input.Length; i < 20; i++)
                {
                    input += "*";
                }

                Console.WriteLine(input);
            }
        }
    }
}
