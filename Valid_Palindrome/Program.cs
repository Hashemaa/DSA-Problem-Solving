/**
Valid Palindrome
This question is asked by Facebook. Given a string, return whether or not it forms a palindrome ignoring case and non-alphabetical characters.
Note: a palindrome is a sequence of characters that reads the same forwards and backwards.

Ex: Given the following strings...

"level", return true
"algorithm", return false
"A man, a plan, a canal: Panama.", return true

 **/

bool IsPalindrome(string? s)
{
	if (s != null || s != "")
	{
		int i = 0;
		int j = (s.Length - 1);
		while(i < j)
		{
			while (i < j && !char.IsLetterOrDigit(s[i]))
			{
				++i;
			}
			while (i < j && !char.IsLetterOrDigit(s[j]))
			{
				--j;
			}
			if (char.ToLower(s[i++]) != char.ToLower(s[j++])){
				return false;
			}
		}
	}

	return true;
}

// Read input and call func
Console.WriteLine(IsPalindrome(Console.ReadLine()));