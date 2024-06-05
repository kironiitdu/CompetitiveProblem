using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProblem.ProblemList.Easy.AlgorithomicProblems
{
    public class FindLargeNumberFromArray
    {
        public int FindLargeNumber(int[] array)
        {

            //Checking if the array is empty to avoid errors
            if (array.Length == 0)
            {
                throw new ArgumentException("Array cannot be empty");
            }
            //Set the first element as max 
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                //Checking if the max is less current index of array then current index is bigger 
                //If the current index is bigger then need to set current index as max 
                if (array[i] > max)
                {
                    max = array[i];
                }

            }
            return max;
        }
    }
}
