using System;
using System.Linq;
namespace lab4
{
    class Program
    {



        static void zad1()
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


        static void zad2()
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

        static void zad3()
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

        static void zad4()
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
                            Console.WriteLine("{0} jest liczbą pierwszą", element);
                            a = 2;
                            break;
                        }
                        if (element % a != 0)
                        {
                            if (element == a + 1)
                            {
                                Console.WriteLine("{0} to liczbą pierwszą", element);
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

        static void zad5()
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

        static void zad6()
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

        static void zad7()
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

        static void zad8()
        {
            string[,] dniTygodnia;
            dniTygodnia = new string[7, 3];


            dniTygodnia[0, 0] = "poniedzialek";
            dniTygodnia[0, 1] = "monday";
            dniTygodnia[0, 2] = "montag";
            dniTygodnia[1, 0] = "wtorek";
            dniTygodnia[1, 1] = "tuesday";
            dniTygodnia[1, 2] = "dienstag";

            dniTygodnia[2, 0] = "sroda";
            dniTygodnia[2, 1] = "wednesday";
            dniTygodnia[2, 2] = "Mittwoch";
            dniTygodnia[3, 0] = "czwartek";
            dniTygodnia[3, 1] = "Thursday";
            dniTygodnia[3, 2] = "Donnerstag";

            dniTygodnia[4, 0] = "piatek";
            dniTygodnia[4, 1] = "friday";
            dniTygodnia[4, 2] = "Freitag";
            dniTygodnia[5, 0] = "sobota";
            dniTygodnia[5, 1] = "Saturday";
            dniTygodnia[5, 2] = "Samstag";

            dniTygodnia[6, 0] = "niedziela";
            dniTygodnia[6, 1] = "Sunday";
            dniTygodnia[6, 2] = "Sonntag";

            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 3; y++)
                    Console.Write("{0,5} ", dniTygodnia[x, y]);
                Console.WriteLine();
            }

        }

        static void zad9()
        {
            string tekst;
            Console.WriteLine("Wprowadź tekst: ");
            tekst = Console.ReadLine();
            int wyrazy = 1;
            foreach (char i in tekst)
                if (i == ' ') wyrazy++;
            Console.WriteLine("zdanie sklada sie z {0} wyrazów", wyrazy);

        }

        static void zad10()
        {
            DateTime date1 = DateTime.Today;
            string x = date1.ToString("d");

            string[] rozdzial = x.Split('.');
            string miesiac = rozdzial[1];

            switch (miesiac)
            {

                case "01":
                    Console.WriteLine("styczen");
                    break;

                case "02":
                    Console.WriteLine("luty");
                    break;

                case "03":
                    Console.WriteLine("marzec");
                    break;

                case "04":
                    Console.WriteLine("kwiecien");
                    break;

                case "05":
                    Console.WriteLine("maj");
                    break;

                case "06":
                    Console.WriteLine("czerwiec");
                    break;

                case "07":
                    Console.WriteLine("lipiec");
                    break;

                case "08":
                    Console.WriteLine("sierpien");
                    break;

                case "09":
                    Console.WriteLine("wrzesien");
                    break;

                case "10":
                    Console.WriteLine("pazdziernik");
                    break;

                case "11":
                    Console.WriteLine("listopad");
                    break;

                case "12":
                    Console.WriteLine("grudzien");
                    break;

            }

        }

        static void zad11()
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

        static void zad12()
        {
            string tekst = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
                             "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
                             "To uczucie dziwnego przygnębienia miewał już nie raz i wiedział,\n" +
                             "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
                             "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalał.";
            Console.WriteLine(tekst);

            int ilosc = 1;
            int x = 0;
            while ((x = tekst.IndexOf('\n', x + 1)) >= 0)
            {
                ilosc++;
            }
            Console.WriteLine("\nLiczba wierszy w tekście: {0}", ilosc);
            Console.WriteLine();
            string[] przedial = tekst.Split('\n');


            for (int i = 0; i < przedial.Length; i++)
            {
                Console.WriteLine("Wiersz'{0}', ma {1} znaków.", przedial[i], przedial[i].Length);
            }
            Console.WriteLine("\nlaczna liczba znakow: {0}", tekst.Length);
        }

        static void zad13()
        {
            string text = "Kiedy idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, po co się idzie – odpowiedział Puchatek";
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

        static void zad15()
        {
            Console.WriteLine("Podaj tekst do zaszyfrowania: ");
            string text = Console.ReadLine();
            string szyfr = "GADERYPOLUKI";
            string wynik = String.Empty;
            text = text.ToUpper();
            for (int a = 0; a < text.Length; a++)
            {
                for (int b = 0; b < szyfr.Length; b++)
                {
                    if (text[a] == szyfr[b])
                    {
                        if (b % 2 == 0)
                        {
                            wynik += szyfr[b + 1];
                        }
                        else
                        {
                            wynik += szyfr[b - 1];
                        }
                    }
                }
                if (wynik.Length - a == 0)
                {
                    wynik += text[a];
                }
            }
            Console.WriteLine(wynik);
        }






        static void Main(string[] args)
        {
            Console.Write("Prosze podac numer zadania: ");
            int nr = int.Parse(Console.ReadLine());

            switch (nr)
            {
                case 1:
                    zad1();
                    break;

                case 2:
                    zad2();
                    break;

                case 3:
                    zad3();
                    break;

                case 4:
                    zad4();
                    break;

                case 5:
                    zad5();
                    break;

                case 6:
                    zad6();
                    break;

                case 7:
                    zad7();
                    break;

                case 8:
                    zad8();
                    break;

                case 9:
                    zad9();
                    break;

                case 10:
                    zad10();
                    break;

                case 11:
                    zad11();
                    break;

                case 12:
                    zad12();
                    break;

                case 13:
                    zad13();
                    break;

                case 15:
                    zad15();
                    break;



            }
        }
    }
}
