using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tab1 = new int[,] { { 1, 2, 3, }, { 1, 2, 3 } };
            int[,] tab2 = new int[,] { { 1, 2, 3, }, { 1, 2, 3 } };
            int[,] tab3 = new int[2, 3];
            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 3; y++)
                    tab3[x, y] = tab1[x, y] + tab2[x, y];
            }

            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 3; y++)
                    Console.Write("{0,5} ", tab3[x, y]);
                Console.WriteLine();
            }
        }
    }
}
