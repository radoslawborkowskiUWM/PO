using System;
using System.Linq;
namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            string tekst = "W par� godzin p�niej, gdy noc zbiera�a si� do odej�cia,\n" +
                            "Puchatek obudzi� si� nagle z uczuciem dziwnego przygn�bienia.\n" +
                            "To uczucie dziwnego przygn�bienia miewa� ju� nie raz i wiedzia�,\n" +
                            "co ono oznacza. By� g�odny. Wi�c poszed� do spi�arni,\n" +
                            "wgramoli� si� na krzese�ko, si�gn�� na g�rn� p�k�, ale nic nie znala�.";
            Console.WriteLine(tekst);

            int ilosc = 1;
            int x = 0;
            while ((x = tekst.IndexOf('\n', x + 1)) >= 0)
            {
                ilosc++;
            }
            Console.WriteLine("\nLiczba wierszy w tek�cie: {0}", ilosc);
            Console.WriteLine();
            string[] przedial = tekst.Split('\n');


            for (int i = 0; i < przedial.Length; i++)
            {
                Console.WriteLine("Wiersz'{0}', ma {1} znak�w.", przedial[i], przedial[i].Length);
            }
            Console.WriteLine("\nlaczna liczba znakow: {0}", tekst.Length);
        }
    }
}
