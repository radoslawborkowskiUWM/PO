using System;
namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst do zaszyfrowania: ");
            string text = Console.ReadLine();
            string szyfr = "GADERYPOLUKI";
            string wynik = String.Empty;
            text = text.ToUpper();
            for (int a = 0; a < text.Length; a++)
            {
                for (int b = 0; b < szyfr.Length; b++)
                {
                    if (text[a] == szyfr[b])
                    {
                        if (b % 2 == 0)
                        {
                            wynik += szyfr[b + 1];
                        }
                        else
                        {
                            wynik += szyfr[b - 1];
                        }
                    }
                }
                if (wynik.Length - a == 0)
                {
                    wynik += text[a];
                }
            }
            Console.WriteLine(wynik);
        }
    }
}
