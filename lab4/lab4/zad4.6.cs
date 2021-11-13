using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tab = new int[,] { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } };
            int suma = 0;
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                    Console.Write("{0,5} ", tab[x, y]);
                Console.WriteLine();
            }

            for (int i = 0; i < 5; i++)
            {
                suma = suma + tab[i, i];
            }
            Console.WriteLine("suma to: " + suma);
        }
    }
}
