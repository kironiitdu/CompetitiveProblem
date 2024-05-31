

using CompetitiveProblem.BigO._1.ConstantTime_O_1_;
using CompetitiveProblem.ProblemList.Easy.AlgorithomicProblems;

var twoSum = new TwoSumsProblem();
int[] nums = { 2, 7, 11, 15 };
int target = 9;
int[] result = twoSum.TwoSum(nums, target);
//Console.WriteLine("Result : [" + result[0] + ", " + result[1] + "]");

var testConstantBigO_N_1 = new O_1_ConstantTime();
//In order to check constant time complexity we can pass the index of array which we want to access
int newTarget = 1;

var output = testConstantBigO_N_1.AccessArrayElement(nums,newTarget);
Console.WriteLine("Expected Output should be 7 : {0}", output);
