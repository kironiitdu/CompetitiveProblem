using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProblem.BigO._2.Logarithmic_Time_O_logN_
{
    public class O_logN_Logarithmic_Time
    {
        /* O(logN): Logarithmic Time Complexity
         * 
         * Logarithmic time complexity, denoted describes an O(logN) algorithm that reduces the problem size by a constant factor with each step. 
         * 
         * This type of complexity is common in algorithms that divide their input into smaller portions in each iteration
         
         * Example: bBnary search.
         
         
         */

        /*  Implementations
         *  
         *  Initial Setup:
            Start with a sorted array.
            Determine the middle element of the array.
            Compare the middle element with the target value.


         *  Reduce Problem Size:
         *  
         *  If the middle element is equal to the target, the search is complete.
            If the middle element is greater than the target, repeat the search on the left half.
            If the middle element is less than the target, repeat the search on the right half.


            Repeat until the target is found or the subarray size reduces to zero.
         
         */

        public int BinarySearch(int [] array, int target)
        {
            // Checking if the array is null
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "The array cannot be null.");
            }
            if (target == null)
            {
                throw new ArgumentNullException(nameof(array), "The target cannot be null.");
            }
            //First short the array
             Array.Sort(array);

            //Need to definefine left, right and middle
            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                //Find the middle
                int mid = (left + right) / 2;

                //Checking if the mid equal to target in that case we found the target in mid
                if (array[mid] == target) 
                {
                    return mid;
                }
               

                //If the target is getter than middle then it should be in right side of array and its for sorted array

                if (array[mid]<target)
                {
                    
                    left = mid + 1;
                   
                }
                //If the target is less than the middle then it should be left side of the array its for sorted array
                else
                {
                    right = mid - 1;
                    
                }


            }

            return -1;
        }

        public int LinearSearch(int[] array, int target)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "The array cannot be null.");
            }
            if (target == null)
            {
                throw new ArgumentNullException(nameof(array), "The target cannot be null.");
            }

            //Check each item and compare if the target is found
            for (int i = 0; i < array.Length; i++)
            {
                //if the item found in loop index
                if (array[i] == target) return i;
               
            }
            return -1;
        }
    }
}
