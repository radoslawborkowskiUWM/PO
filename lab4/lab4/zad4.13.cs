using System;
using System.Linq;
namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Kiedy idzie siê po miód z balonikiem, to trzeba siê staraæ, ¿eby pszczo³y nie wiedzia³y, po co siê idzie – odpowiedzia³ Puchatek";
            string[] slowa = text.Split();
            int ilosc = 1;
            for (int x = 0; x < slowa.Length; x++)
            {
                for (int y = 0; y < slowa.Length; y++)
                {
                    if (slowa[x].Equals(slowa[y]) == true && y != x)
                    {
                        slowa[y] = "null";
                        if (slowa[x] == "null")
                        {
                            ilosc -= 2;
                        }
                        ilosc++;
                    }
                }
                if (ilosc > 0)
                {
                    slowa[x] = slowa[x] + " - " + ilosc + " razy\n";
                }
                ilosc = 1;
            }
            foreach (var x in slowa.Distinct())
            {
                if (x != "null")
                {
                    Console.Write(x);
                }
                ilosc++;
            }
        }
    }
}
