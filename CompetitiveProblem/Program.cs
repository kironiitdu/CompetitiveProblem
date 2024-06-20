

using CompetitiveProblem.BigO._1.ConstantTime_O_1_;
using CompetitiveProblem.BigO._2.Logarithmic_Time_O_logN_;
using CompetitiveProblem.BigO._3.LinearTime_O_n_;
using CompetitiveProblem.ProblemList.Easy.AlgorithomicProblems;
using CompetitiveProblem.ProblemList.Medium;

var twoSum = new TwoSumsProblem();
int[] nums = { 2, 7, 11, 15,5,61,7 };

var findLarge = new FindLargeNumberFromArray();
Console.WriteLine("The large number in the array is: {0}",findLarge.FindLargeNumber(nums));
int target = 11;
//int[] result = twoSum.TwoSum(nums, target);
//Console.WriteLine("Result : [" + result[0] + ", " + result[1] + "]");

var testConstantBigO_N_1 = new O_1_ConstantTime();
//In order to check constant time complexity we can pass the index of array which we want to access
int newTarget = 1;

//var output = testConstantBigO_N_1.AccessArrayElement(nums,newTarget);
//Console.WriteLine("Expected Output should be 7 : {0}", output);

//var testNLogN = new O_logN_Logarithmic_Time();
//var result = testNLogN.BinarySearch(nums,target);

//Console.WriteLine("Expected Output should be 15 : {0}", result);

string s1 = "llo";
string s2 = "hello world";

// Check if str1 is a substring of str2
//var testSubstring = new CheckSubsequentSubstringsBetweenTwoGivenInput();
//bool isSubstring1 = testSubstring.IsSubstring(s1, s2);
//Console.WriteLine($"{s1} is a substring of {s2}: {isSubstring1}");

var findMaxElement = new O_n__LinearTime();
Console.Write("Lagerst number is: {0}", findMaxElement.FindMaxElementFromArray(nums));

