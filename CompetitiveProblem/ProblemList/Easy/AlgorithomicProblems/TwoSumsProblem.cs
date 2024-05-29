using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProblem.ProblemList.Easy.AlgorithomicProblems
{
    public class TwoSumsProblem
    {
        /*  The Problem: 
            ============
       
        Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        You may assume that each input would have exactly one solution, and you may not use the same element twice.

        You can return the answer in any order.


        Example 1:

        Input: nums = [2,7,11,15], target = 9
        Output: [0,1]
        Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].


        Example 2:

        Input: nums = [3,2,4], target = 6
        Output: [1,2]
         
         */


        /*   Algorithm
            ===========
             
            1. Need to define an Dictionary to create a list of elements to keep the number of sum
            2. Need to loop through the array of numbers
            3. Need to find the current number which would be needed for calculating complements
            4. Need to find the complement (target - currentNumber)
            5. Need to check the dictionary if the current complement already in the dictionary
                if the current number already in dictionary then need to return new int[] array
                if not wihtin dictioray already then need to add the number in dictionary 
         
         */


        /* implementation
         ===================
           
         */

        public int[] TwoSum(int[] nums, int target)
        {
            // 1. Initialize a dictionary to store the element and its index
            Dictionary<int, int> dict = new Dictionary<int, int>();

            // 2. Iterate over the array
            for (int i = 0; i < nums.Length; i++)
            {
                //3. Getting Current number
                int num = nums[i];
                //4. Calculate the complement
                int complement = target - num;

                // 5. Check if the complement is already in the dictionary
                if (dict.ContainsKey(complement))
                {
                    // Return the indices of the current number and the complement
                    return new int[] { dict[complement], i };
                }

                // Otherwise, add the current number and its index to the dictionary
                if (!dict.ContainsKey(num))
                {
                    dict.Add(num, i);
                }
            }

            // If no solution is found, throw an exception
            throw new ArgumentException("No two sum solution");
        }

    }
}
