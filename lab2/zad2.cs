using System;
					
public class Program
{
	public static void Main()
	{
		
		float a, b,c, delta;
		
		
		Console.WriteLine("Podaj a: ");
		a = float.Parse(Console.ReadLine());
		
	    		Console.WriteLine("Podaj b: ");
		b = float.Parse(Console.ReadLine());
		
        		Console.WriteLine("Podaj c: ");
		c = float.Parse(Console.ReadLine());
		

        delta = (b*b)-(4*a*c);
        
        Console.WriteLine("Delta to: "+delta);


	
	}
}