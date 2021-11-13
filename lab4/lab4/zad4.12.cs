using System;
using System.Linq;
namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            string tekst = "W parê godzin póŸniej, gdy noc zbiera³a siê do odejœcia,\n" +
                            "Puchatek obudzi³ siê nagle z uczuciem dziwnego przygnêbienia.\n" +
                            "To uczucie dziwnego przygnêbienia miewa³ ju¿ nie raz i wiedzia³,\n" +
                            "co ono oznacza. By³ g³odny. Wiêc poszed³ do spi¿arni,\n" +
                            "wgramoli³ siê na krzese³ko, siêgn¹³ na górn¹ pó³kê, ale nic nie znala³.";
            Console.WriteLine(tekst);

            int ilosc = 1;
            int x = 0;
            while ((x = tekst.IndexOf('\n', x + 1)) >= 0)
            {
                ilosc++;
            }
            Console.WriteLine("\nLiczba wierszy w tekœcie: {0}", ilosc);
            Console.WriteLine();
            string[] przedial = tekst.Split('\n');


            for (int i = 0; i < przedial.Length; i++)
            {
                Console.WriteLine("Wiersz'{0}', ma {1} znaków.", przedial[i], przedial[i].Length);
            }
            Console.WriteLine("\nlaczna liczba znakow: {0}", tekst.Length);
        }
    }
}
