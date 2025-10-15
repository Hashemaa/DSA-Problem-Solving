/**
Vacuum Cleaner Route
This question is asked by Amazon. Given a string representing the sequence of moves a robot vacuum makes, 
return whether or not it will return to its original position. 
The string will only contain L, R, U, and D characters, representing left, right, up, and down respectively.

Ex: Given the following strings...
"LR", return true
"URURD", return false
"RUULLDRD", return true
 */

class Exercise
{
	//Create int origin = 0

	//Traverse string array and check if the character at each element is either L, R, U, or D

	//For character L and D decrement origin by 1 (-1)
	//For character R and U increment origin by 1 (1)

	//Return true if origin is zero, otherwise false
	public static bool VacuumReturnsToStart(string? moves)
	{
		int origin = 0;
		if (moves != null)
		{
			for (int i = 0; i < moves.Length; ++i)
			{
				switch (char.ToUpper(moves[i]))
				{
					case 'L':
						--origin;
						break;
					case 'R':
						++origin;
						break;
					case 'U':
						++origin;
						break;
					case 'D':
						--origin;
						break;
				}
			}
		}

		return origin == 0;
	}

	public static void Main(string[] args)
	{
		string? input = Console.ReadLine();
		Console.WriteLine(VacuumReturnsToStart(input));
	}
}
