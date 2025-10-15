/**
Reverse String
Welcome to your first of many daily bytes! We are starting with a strings problem and we strongly recommend you find the time each day to solve these problems. It is important to not just solve them in your head but actually whip out your favorite editor/IDE and write a function and use the test cases supplied in the question to check your work. Getting yourself to actually write down the solutions will go a long way to ensuring you are thinking through all the edge cases as well as any space/time complexities.

This question is asked by Google. Given a string, reverse all of its characters and return the resulting string.

Ex: Given the following strings...

“Cat”, return “taC”
“The Daily Byte”, return "etyB yliaD ehT”
“civic”, return “civic”
 */

class Solution
{
	//Create function that accepts a string and returns a string
	public static string? ReverseString(string? s)
	{
		//Loop through string using for loop and add
		//last character using index lookup brackets [] to the reversed string
		if (string.IsNullOrEmpty(s)) { return null; }
		string reversedString = string.Empty;
		for (int i = s.Length - 1; i >= 0; i--)
		{
			reversedString += s[i];
		}

		//return the reversed string
		return reversedString;
	}

	public static void Main(string[] args)
	{
		string? input = Console.ReadLine();
		Console.WriteLine(ReverseString(input));
	}
}
