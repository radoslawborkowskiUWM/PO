using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst;
            Console.WriteLine("WprowadŸ tekst: ");
            tekst = Console.ReadLine();
            int wyrazy = 1;
            foreach (char i in tekst)
                if (i == ' ') wyrazy++;
            Console.WriteLine("zdanie sklada sie z {0} wyrazów", wyrazy);

        }
    }
}
