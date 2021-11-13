using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab1 = new int[] { 1, -2, 3, -3, 5, 0, -99, 7, 9, -32 };
            int[] tab2 = new int[10];
            int n = 0;
            int dl = tab1.Length;

            for (int i = 0; i < dl; i++)
            {
                int x = tab1[i];
                if (x > 0)
                {
                    tab2[n] = x;
                    n++;
                }
            }

            foreach (int j in tab2)
            {
                System.Console.Write("{0} ", j);
            }
        }
    }
}
