using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab1 = { 0, 14, -2, 86, -76, 100 };
            int dl = tab1.Length;
            int[] tab2 = new int[dl];

            Array.Copy(tab1, 0, tab2, 1, 5);
            Array.Copy(tab1, 5, tab2, 0, 1);

            Console.Write("tab1: ");
            foreach (int i in tab1)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            Console.Write("tab2: ");
            foreach (int j in tab2)
                Console.Write("{0} ", j);
        }
    }
}
