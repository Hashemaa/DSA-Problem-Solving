/**
Given two strings s and t, return true if t is an anagram of s, and false otherwise.

 

Example 1:

Input: s = "anagram", t = "nagaram"

Output: true

Example 2:

Input: s = "rat", t = "car"

Output: false
 */

class Solution
{
	public static bool IsAnagram(string? s, string? t)
	{
		if (!string.IsNullOrEmpty(s) && !string.IsNullOrEmpty(t))
		{
			if (s.Length == t.Length)
			{
				foreach (char ch in t)
				{
					if (!s.Contains(ch))
					{
						return false;
					}
				}
				return true;
			}
		}
		return false;
	}

	public static void Main(string[] args)
	{
		string? s = Console.ReadLine();
		string? t = Console.ReadLine();
		Console.WriteLine(IsAnagram(s, t));
	}
}
