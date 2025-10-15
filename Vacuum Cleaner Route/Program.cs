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
	//Create a int x for L and R
	//Create a int y for U and D

	//Origin is (0,0) representing x,y

	//Traverse string array and check if the character at each element is either L, R, U, or D, and reflect upon x and y, otherwise do nothing.

	//For character L and D decrement by 1 (-1)
	//For character R and U increment by 1 (1)

	//Return true if origin is zero, otherwise false
	public static bool VacuumReturnsToStart(string? moves)
	{
		int x = 0;
		int y = 0;
		if (moves != null)
		{
			for (int i = 0; i < moves.Length; ++i)
			{
				switch (char.ToUpper(moves[i]))
				{
					case 'L':
						--x;
						break;
					case 'R':
						++x;
						break;
					case 'U':
						++y;
						break;
					case 'D':
						--y;
						break;
				}
			}
		}

		return x == 0 && y == 0;
	}

	public static void Main(string[] args)
	{
		string? input = Console.ReadLine();
		Console.WriteLine(VacuumReturnsToStart(input));
	}
}
