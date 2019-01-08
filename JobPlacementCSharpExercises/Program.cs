using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPlacementCSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Given an array of integers, write a method to total the odd numbers.
            int[] numArray = new int[] { 46, 28, 27, 39, 41, 53, 2, 63, 79, 54, 157 };

            var method1 = new Methods();
            Console.WriteLine(method1.totalOdds(numArray));




            //2. Given an array of integers, write a method to sum the elements in the array, knowing that some of the elements may be very large numbers.
            long[] numArray2 = new long[] { 897546584547845, 89798453435181815, 49848454684874544, 432135765468446, 321687468765187654, 3213548796546484 };

            var method2 = new Methods();
            Console.WriteLine(method2.totalLarge(numArray2));





            //3. Given a string, reverse it.
            string exampleString = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(exampleString);

            char[] stringReversed = exampleString.ToCharArray();
            Array.Reverse(stringReversed);
            Console.WriteLine(stringReversed);



            //4. Given a string, remove any repeated letters.
            string exampleString2 = "The job requires extra pluck and zeal from every young wage earner.";
            Console.WriteLine(exampleString2);

            string removeRepeats = "";
            List<char> repeatsRemovedList = new List<char>();
            foreach (char c in exampleString2)
            {
                if (repeatsRemovedList.Contains(c)) continue;

                removeRepeats += c.ToString();
                repeatsRemovedList.Add(c);


            }
            Console.WriteLine(removeRepeats);

            




            //5. FizzBuzz
            //- - FizzBuzz is a programming task used in job interviews where you have to write a program that prints 
            //the numbers from 1 to 100.  For multiples of three print "Fizz" instead of the number and for the multiples of five 
            //print "Buzz". For numbers which are multiples of both three and five print "FizzBuzz".  Its used to determine whether 
            //the job candidate can actually write code.


            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

Console.Read();




        }

    }
}
