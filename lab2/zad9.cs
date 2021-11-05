using System;
					
public class Program
{

	
	
	static void A()
	{
		// wynik=False; x=2;  y=4;  z=2;
        int x = 1, y = 4, z = 2;
        bool wynik =(x++ > 1 && y++ == 4 && z--> 0);
        Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);
	}
	
		static void B()
	{
		// wynik=False; x=2;  y=5;  z=2;
        int x = 1, y = 4, z = 2;
        bool wynik = (x++ > 1 & y++ == 4 && z--> 0);
        Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);
	}
	
		static void C()
	{
		// wynik=False; x=2;  y=5;  z=1;
        int x = 1, y = 4, z = 2;
        bool wynik = (x++ > 1 & y++ == 4 & z--> 0);
        Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);
	}
	
		static void D()
	{
		// wynik=True; x=1;  y=3;  z=4;
        int x = 1, y = 3, z = 4;
        bool wynik = (x == 1 || y++ > 2 || ++z > 0);
        Console.WriteLine("wynik={0} x={1}  y={2}  z={3}",wynik, x, y, z);
	}
	
	    static void E()
	{
	    // wynik=True; x=1;  y=4;  z=4;
        int x = 1, y = 3, z = 4;
        bool wynik = (x == 1 | y++ > 2 || ++z > 0);
        Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);
	}	
	    static void F()
	{
	    // wynik=True; x=1;  y=4;  z=5;
        int x = 1, y = 3, z = 4;
        bool wynik = (x == 1 | y++ > 2 | ++z > 0);
        Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);
	}


    
    
	public static void Main()
	{
		
		Console.WriteLine("ZADANIE 2.9");
	
		Console.WriteLine("Podpunkt a");
		A();
		
		Console.WriteLine("Podpunkt b");
		B();	
		
		Console.WriteLine("Podpunkt c");
		C();
		
		Console.WriteLine("Podpunkt d");
		D();
		
		Console.WriteLine("Podpunkt e");
		E();
		
		Console.WriteLine("Podpunkt f");
		F();
	}
	
	
}