using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ilosc elementow w tablicy: ");
            int dl = int.Parse(Console.ReadLine());
            int[] tablica = new int[dl];
            int min = 0;
            int max = 0;
            double srednia = 0;
            int dodatnie = 0;


            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine("Wpisz wartosc do elementu tablicy oraz nacisnij 'enter'");
                tablica[i] = int.Parse(Console.ReadLine());

                if (min > tablica[i])
                {
                    min = tablica[i];
                }
                if (max < tablica[i])
                {
                    max = tablica[i];
                }
                if (tablica[i] > 0)
                {
                    dodatnie++;
                }
                srednia += tablica[i];
            }
            int a = Array.IndexOf(tablica, min);
            int b = Array.IndexOf(tablica, max);
            srednia = srednia / tablica.Length;
            Console.WriteLine("\nNajmniejszy element: {0} index to: {1} \n" +
                "Najwiekszy element: {2} index to: {3} \n" +
                "Ilosc dodatnich elementow: {4} \n" +
                "Srednia to: {5}", min, a, max, b, dodatnie, srednia);
        }
    }
}
