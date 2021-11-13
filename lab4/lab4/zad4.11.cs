using System;
using System.Linq;
namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("wpisz tekst: ");
            string tekst = Console.ReadLine();
            var litery = tekst.ToCharArray().Distinct().ToArray();

            for (int x = 0; x < litery.Length; x++)
            {
                int suma = tekst.ToCharArray().Count(b => b == litery[x]);
                Console.WriteLine("'{0}' - {1}", litery[x], suma);
            }

        }
    }
}