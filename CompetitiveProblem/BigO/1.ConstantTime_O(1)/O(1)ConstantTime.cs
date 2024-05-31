using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProblem.BigO._1.ConstantTime_O_1_
{
    public class O_1_ConstantTime
    {
        /* 0(1): Constant Time Complexity
         * 
         * The runtime does not change with the size of the input
         * Example: Accessing an element in an array by index
         
         
         */

        /*  Implementations
         *  Appending an element to the end of a list (assuming the list has enough capacity) is an O(1) operation because it directly adds the element at the next available position.
         
         *  Example: List<int> list = new List<int> { 1, 2, 3, 4 };
         *  list.Add(5); // O(1) operation
         *  list[4] // Output: 5
         *  
         *  Checking the Length of a String 
         *  string str = "Hello, World!";
         *  int length = str.Length;
         *  
         *  Checking if a Key Exists in a Dictionary
         *  
            Dictionary<string, int> dictionary = new Dictionary<string, int>
            {
                { "a", 1 },
                { "b", 2 },
                { "c", 3 }
            };
         
            bool containsKey = dictionary.ContainsKey("b"); 
         */

        public int AccessArrayElement(int[] array, int target)
        {
            // Checking if the array is null
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "The array cannot be null.");
            }

            // Need to check if the target index is within the valid range
            if (target < 0 || target >= array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(target), "The target index is out of range.");
            }

            // Returning the array element at the specified index
            return array[target];
        }
    }
}
