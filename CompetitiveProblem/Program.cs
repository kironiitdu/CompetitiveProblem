

using CompetitiveProblem.ProblemList.Easy.AlgorithomicProblems;

var twoSum = new TwoSumsProblem();
int[] nums = { 2, 7, 11, 15 };
int target = 9;
int[] result = twoSum.TwoSum(nums, target);
Console.WriteLine("Result : [" + result[0] + ", " + result[1] + "]");

