using System;
					
public class Program
{
	public static void Main()
	{
		
		int c;
		double f;
		Console.WriteLine("Podaj temperture w stopniach ");
		c = int.Parse(Console.ReadLine());
		
		f=32+((1.8)*c);
		
		Console.WriteLine(f);
	}
}
