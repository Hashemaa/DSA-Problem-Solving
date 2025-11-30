/**
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.

 

Example 1:

Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.
Example 2:

Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome.
Example 3:

Input: s = " "
Output: true
Explanation: s is an empty string "" after removing non-alphanumeric characters.
Since an empty string reads the same forward and backward, it is a palindrome.
 */

class Solution
{
	public static bool IsPalindrome(string s)
	{

		string filtered = new string(s.ToLower().Where(char.IsLetterOrDigit).ToArray());
		Console.WriteLine($"Filtered string: {filtered}");
		string reversed = new string(filtered.Reverse().ToArray());
		Console.WriteLine($"Reversed string: {reversed}");

		if(filtered.Equals(reversed)) return true;

		return false;
	}

public static void Main(string[] args)
	{
		string case1 = "A man, a plan, a canal: Panama"; //output true
		string case2 = "race a car"; //output false
		string case3 = " "; //output true

		Console.WriteLine(IsPalindrome(case1));
	}
}
