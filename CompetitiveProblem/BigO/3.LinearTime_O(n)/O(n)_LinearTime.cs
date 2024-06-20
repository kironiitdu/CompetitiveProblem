using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProblem.BigO._3.LinearTime_O_n_
{
    public class O_n__LinearTime
    {
        public int FindMaxElementFromArray(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "The array cannot be null.");
            }
            
            //First short the array
            Array.Sort(array);

            //initialize the default max value

            int maxValue = int.MaxValue;

            //Loop over the array
            for (int i = 0; i < array.Length; i++)
            {
                //Will check the existing item in max value
                //If the current item in max variable is less than the current array element then assign new element into max variable
                //Continue loop
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }

            return maxValue;
        }
    }
}
