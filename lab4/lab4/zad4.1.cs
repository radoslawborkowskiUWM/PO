using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj ilosc elementow w tablicy");
            int n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("podaj element");
                int a = int.Parse(Console.ReadLine());
                tab[i] = a;
            }

            foreach (int j in tab)
            {
                System.Console.Write("{0} ", j);
            }


        }
    }
}
