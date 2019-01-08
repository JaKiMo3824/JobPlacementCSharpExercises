using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPlacementCSharpExercises
{
    class Methods
    {
        //1. Given an array of integers, write a method to total the odd numbers.
        public int totalOdds(int[] numArray)
        {
            int oddTotal = 0;
            foreach (int i in numArray)
                {
                if (i % 2 != 0 )
                {
                    oddTotal += i;
                    
                }
            }
            return oddTotal;
        }

        //2. Given an array of integers, write a method to sum the elements in the array, knowing that some of the elements may be very large numbers.

        public long totalLarge(long[] numArray2)
        {
            return numArray2.Sum();
        }
    }
}
