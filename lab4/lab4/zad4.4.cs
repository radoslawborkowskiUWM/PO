using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab1 = new int[100];
            Random los = new Random();
            int a = 2;

            for (int x = 0; x < tab1.Length; x++)
            {
                tab1[x] = los.Next(2, 1000);
                int element = tab1[x];

                for (int y = a; y <= element; y++)
                {
                    if (element % element == 0 && element % 1 == 0)
                    {
                        if (element == 2)
                        {
                            Console.WriteLine("{0} jest liczb¹ pierwsz¹", element);
                            a = 2;
                            break;
                        }
                        if (element % a != 0)
                        {
                            if (element == a + 1)
                            {
                                Console.WriteLine("{0} to liczb¹ pierwsz¹", element);
                                a = 2;
                                break;
                            }
                            else
                            {
                                a++;
                            }
                        }
                        else
                        {
                            a = 2;
                            break;
                        }
                    }
                }
            }
        }
    }
}
