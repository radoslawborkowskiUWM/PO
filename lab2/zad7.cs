using System;
					
public class Program
{
	public static void Main()
	{
	    //Odpowiedz: 7
		
    int x, y = 5;
    x = ++y * 2;
    x = y++;
    x = y--;
    Console.WriteLine(++y); 
	}
}