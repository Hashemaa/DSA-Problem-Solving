/**
Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

 

Example 1:

Input: nums = [1,2,3,1]

Output: true

Explanation:

The element 1 occurs at the indices 0 and 3.

Example 2:

Input: nums = [1,2,3,4]

Output: false

Explanation:

All elements are distinct.

Example 3:

Input: nums = [1,1,1,3,3,4,3,2,4,2]

Output: true
 */

class Solution
{
	public static bool ContainsDuplicate(int[] nums)
	{
		int lengthOfArray = nums.Length;
		for (int i = 0; i < lengthOfArray; ++i)
		{
			for (int j = 0; j < lengthOfArray; ++j)
			{
				if (nums[i] == nums[j] && i != j)
				{
					return true; //Contains duplicate!
				}
			}
		}
		return false;
	}

	public static void Main(string[] args)
	{
		int[] case1 = [1, 2, 3, 1];
		Console.WriteLine(ContainsDuplicate(case1));
		int[] case2 = [1, 2, 3, 4];
		Console.WriteLine(ContainsDuplicate(case2));
		int[] case3 = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2];
		Console.WriteLine(ContainsDuplicate(case3));
	}
}
