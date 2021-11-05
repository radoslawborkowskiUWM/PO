using System;
					
public class Program
{
	public static void Main()
	{
	    //Odpowiedz: 3
		
    int x, y = 4;
    x = (y -= 2);
    x = y++;
    x = y--;
    Console.WriteLine(x);
	}
}