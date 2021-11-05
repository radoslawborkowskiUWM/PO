using System;
					
public class Program
{
	public static void Main()
	{
	    //Odpowiedz: A
		
    bool x;
    int y = 1, z = 1;
    x = (y == 1 && z++ == 1);
    Console.WriteLine(x); 
    Console.WriteLine(y); 
    Console.WriteLine(z); 
	}
}