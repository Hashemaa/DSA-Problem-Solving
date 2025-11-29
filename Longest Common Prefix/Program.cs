/**
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

 

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
 

Constraints:

1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lowercase English letters if it is non-empty.
 */

class Solution
{
	public static string LongestCommonPrefix(string[] strs)
	{
		if (strs == null || strs.Length == 0)
			return "";

		string prefix = strs[0]; //"flower" for case1

		for (int i = 1; i < strs.Length; i++)
		{
			while (!strs[i].StartsWith(prefix))
			{
				prefix = prefix.Substring(0, prefix.Length - 1);
				if (prefix == "")
					return "";
			}
		}

		return prefix;
	}

	public static void Main(string[] args)
	{
		string[] case1 = ["flower", "flow", "flight"]; //output "fl"
		string[] case2 = ["dog", "racecar", "car"]; //output ""

		Console.WriteLine(LongestCommonPrefix(case1));
	}
}
