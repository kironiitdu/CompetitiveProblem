using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProblem.ProblemList.Medium
{
    public class CheckSubsequentSubstringsBetweenTwoGivenInput
    {
        public bool IsSubstring(string s1, string s2)
        {
            //Check the lengtg of s1 if length of s1 is zero then it can be a substring of any subsequent string
            if (s1.Length == 0)
            {
                return true;
            }
            //If s1 is bigger than s2 then it cannot be a substring
            if (s1.Length > s2.Length)
            {
                return false;
            }
            //Finding the length of outer loop for for s2
            int outerBound = s2.Length - s1.Length;
            for (int i = 0; i <= outerBound; i++)
            {
                //Inner loop for s1
                int j;
                for (j = 0; j < s1.Length; j++)
                {
                    // if the index of s1 is not the same of s2 index then its not a substrings
                    if (s1[j] != s2[i+j])
                    {
                        break;
                    }
                }
                //if the index of s1 and index of s2 is same then its a substring
                if (j == s1.Length)
                {
                    return true;
                }

               
            }

            return false;
        }
    }
}
