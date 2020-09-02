using System;
using System.Collections.Generic;

namespace Syntax_Sugar_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Typing using the var keyword

            //var x = 1;

            //var positiveMessage = "This is a positive message";
            //var negativeMessage = "This is a negative message";

            ////if - else statement

            //if (x > 0)
            //{
            //    Console.WriteLine(positiveMessage);
            //}
            //else
            //{
            //    Console.WriteLine(negativeMessage);
            //}

            ////Inline If - Ternary Operator

            //var message = x > 0 ? positiveMessage : negativeMessage;
            //Console.WriteLine(message);

            //Console.WriteLine(IsEven(x));
            ////-------------------------------------------------------------------------------
            ////----------------------------String Interpolation example-----------------------

            //string firstName = "John";
            //string petName = "Baxter";
            //string favoriteSnack = "Chips";

            //// old-fashioned way of concatenating strings
            //Console.WriteLine("Hello," + " " + firstName + " " + "!" + " Your pet's first name is " + petName + ", and your favorite snack is " + favoriteSnack + ".");



            //// (composite formatting) slightly newer old-fashioned way of concatenating strings 
            //Console.WriteLine("Hello, {0}! Your pet's name is {1}, and your favorite snack is {2}.", firstName, petName, favoriteSnack);



            //// STRING INTERPOLATION  
            //Console.WriteLine($"Hello, {firstName}! Your pet's name is {petName}, and your favorite snack is {favoriteSnack}");










            //-----------------------------------------------------------------------------
            //Exercise -> change the code to implement inferred typing, string interpolation, and the ternary operator

            int answer = 4;
            string response;

            if (answer < 9)
            {
                response = answer + "is less than nine";
            }
            else
            {
                response = answer + "greater than or equal to nine";
            }

            //var response = answer < 9 ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";

        }
        










        public static string IsEven(int x)
        {
            //inline if - Ternary Operator
            return x % 2 == 0 ? "Is even" : "Is odd";
        }




        public static bool IsOdd(int x)
        {
            //If I have ONLY a conditional statement then the only thing that can be returned is 
            //either TRUE or FALSE. Therefore you can just leave out the ternary operator and just 
            //return (conditional)
            return x % 2 != 0;
        }





        public static bool IsPositive(int x)
        {
            return x > 0 ? true : false;

            //return x > 0; This is an even more simplified version of the code above
        }


    }
}
