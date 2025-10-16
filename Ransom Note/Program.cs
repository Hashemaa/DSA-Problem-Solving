/**
Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

Each letter in magazine can only be used once in ransomNote.

 

Example 1:

Input: ransomNote = "a", magazine = "b"
Output: false
Example 2:

Input: ransomNote = "aa", magazine = "ab"
Output: false
Example 3:

Input: ransomNote = "aa", magazine = "aab"
Output: true
 

Constraints:

1 <= ransomNote.length, magazine.length <= 105
ransomNote and magazine consist of lowercase English letters.
 */

class Solution
{
	public static bool CanConstruct(string? ransomNote, string? magazine)
	{
		int count = 0;
		if (!string.IsNullOrEmpty(ransomNote) && !string.IsNullOrEmpty(magazine))
		{
			foreach (char ch in magazine)
			{
				if (ransomNote.Length == count) break;
				if (ransomNote.Contains(ch))
				{
					++count;
				}
			}
		}
		return count == ransomNote?.Length;
	}

	public static void Main(string[] args)
	{
		string? ransomNote = Console.ReadLine();
		string? magazine = Console.ReadLine();
		Console.WriteLine(CanConstruct(ransomNote, magazine));
	}
}
