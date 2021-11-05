using System;
					
public class Program
{
	public static void Main()
	{
		
		float wzrost, waga, bmi;
		
		
		Console.WriteLine("Podaj wzrost w metrach: ");
		wzrost = float.Parse(Console.ReadLine());
		
	    Console.WriteLine("Podaj mase w kg: ");
		waga = float.Parse(Console.ReadLine());
		

        bmi = waga/(wzrost*wzrost);
        
        Console.WriteLine("twoje BMI to: "+bmi);


	
	}
}