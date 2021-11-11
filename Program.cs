using System;

namespace lab3
{
    class Program
    {



        static void zad1()
        {
            int rok;
            Console.WriteLine("Podaj rok");
            rok = int.Parse(Console.ReadLine());

            if (rok % 4 == 0 && rok % 100 != 0)
            {
                Console.WriteLine("rok przestępny");
            }
            else if (rok % 400 == 0)
            {
                Console.WriteLine("rok przestepny");

            }
            else
            {
                Console.WriteLine("rok nieprzestepny");
            }
        }
        

        static void zad2()
        {
            int a, b;
            Console.WriteLine("Podaj liczbe a");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbe b");
            b = int.Parse(Console.ReadLine());

            if (a % b == 0)
            {
                Console.WriteLine("liczba a jest dzielnikiem liczby b");
            }
            else
            {
                Console.WriteLine("liczba a nie jest dzielnikiem liczby b");
            }
        }
        
        static void zad3()
        {
            int max, a;

            Console.WriteLine("Podaj liczbe");
            max = int.Parse(Console.ReadLine());

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Podaj liczbe");
                a = int.Parse(Console.ReadLine());

                if (a > max)
                {
                    max = a;
                }
            }

            Console.WriteLine("Największa liczba to: " + max);
        }
               
        static void zad4()
        {
            string sign;
            Console.WriteLine("podaj symbol");
            sign = Console.ReadLine();
            double result, a, b;
            Console.WriteLine("podaj liczbe a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("podaj liczbe b");
            b = double.Parse(Console.ReadLine());


            switch (sign)
            {
                case "+":
                    result = a + b;
                    Console.WriteLine(result);
                    break;

                case "-":
                    result = a - b;
                    Console.WriteLine(result);
                    break;

                case "*":
                    result = a * b;
                    Console.WriteLine(result);
                    break;

                case "/":
                    result = a / b;
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("Podano zły symbol");
                    break;
            }
        }
               
        static void zad5()
        {
            int a, b, c, delta;
            Console.WriteLine("podaj a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj c");
            c = int.Parse(Console.ReadLine());

            delta = (b * b) - 4 * a * c;

            if (delta > 0)
            {
                Console.WriteLine("rownanie ma 2 rozwiazania");
            }

            else if (delta == 0)
            {
                Console.WriteLine("rownanie ma 1 rozwiazanie");
            }

            else
            {
                Console.WriteLine("rownanie nie ma rozwiazan");
            }
        }
               
        static void zad6()
        {
            float wzrost, waga, bmi;


            Console.WriteLine("Podaj wzrost w metrach: ");
            wzrost = float.Parse(Console.ReadLine());

            Console.WriteLine("Podaj mase w kg: ");
            waga = float.Parse(Console.ReadLine());


            bmi = waga / (wzrost * wzrost);

            if (bmi < 16)
            {
                Console.WriteLine("wygłodzenie - " + bmi);
            }


            else if (bmi >= 16 && bmi < 17)
            {
                Console.WriteLine("wychudzenie - " + bmi);
            }


            else if (bmi >= 17 && bmi < 18.5)
            {
                Console.WriteLine("niedowaga - " + bmi);
            }


            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine("waga prawidlowa - " + bmi);
            }


            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("nadwaga - " + bmi);
            }


            else if (bmi >= 30 && bmi < 35)
            {
                Console.WriteLine("otyłość I stopnia - " + bmi);
            }


            else if (bmi >= 35 && bmi < 40)
            {
                Console.WriteLine("otyłość II stopnia (duża) - " + bmi);
            }

            else
            {
                Console.WriteLine("otyłość III stopnia (chorobliwa)  - " + bmi);
            }
        }
               
        static void zad7()
        {
            Console.WriteLine("Wpisz nr dnia tygodnia");
            string numer = Console.ReadLine();

            switch (numer)
            {
                case "1":
                    Console.WriteLine("Poniedziałek");
                    break;

                case "2":
                    Console.WriteLine("Wtorek");
                    break;

                case "3":
                    Console.WriteLine("Środa");
                    break;

                case "4":
                    Console.WriteLine("Czwartek");
                    break;

                case "5":
                    Console.WriteLine("Piątek");
                    break;

                case "6":
                    Console.WriteLine("Sobota");
                    break;

                case "7":
                    Console.WriteLine("Niedziela");
                    break;


                default:
                    Console.WriteLine("Nie ma takiego dnia tygodnia");
                    break;
            }
        }
               
        static void zad8()
        {
            float srednia, ilosc, ocena;
            srednia = 0;
            Console.WriteLine("Podaj ilosc ocen: ");
            ilosc = int.Parse(Console.ReadLine());

            for (int i = 0; i < ilosc; i++)
            {
                Console.WriteLine("Podaj ocenę: ");
                ocena = float.Parse(Console.ReadLine());
                srednia = srednia + ocena;
            }
            srednia = srednia / ilosc;

            if (srednia >= 2 && srednia < 4)
            {
                Console.WriteLine("Twoja srednia to: " + srednia + ". Twoje stypendium wynosi : 0zł");
            }

            else if (srednia >= 4 && srednia < 4.8)
            {
                Console.WriteLine("Twoja srednia to: " + srednia + ". Twoje stypendium wynosi : 350zł");
            }

            else if (srednia >= 4.8 && srednia <= 5)
            {
                Console.WriteLine("Twoja srednia to: " + srednia + ". Twoje stypendium wynosi : 550zł");
            }

            else
            {
                Console.WriteLine("Twoja srednia to: " + srednia);
            }
        }
               
        static void zad9()
        {
            Console.WriteLine("Wybierz podpunkt: ");
            string wybor = Console.ReadLine();

            Console.WriteLine("podaj liczbe wierszy: ");
            int dl = int.Parse(Console.ReadLine());

            if (wybor == "a")
            {
                for (int i = 1; i <= dl; i++)
                {

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }


            else if (wybor == "b")
            {
                for (int i = 1; i <= dl; i++)
                {
                    for (int j = dl; j >= i; j--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }


            else if (wybor == "c")
            {

                for (int i = 1; i <= dl; i++)
                {
                    for (int j = dl; j > i; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }


                    Console.WriteLine();
                }
            }


            else if (wybor == "d")
            {
                Console.WriteLine("****");

                for (int i = 1; i <= dl - 2; i++)
                {
                    Console.WriteLine("*  *");
                }
                Console.WriteLine("****");
            }

            else
            {
                Console.WriteLine("Wybrano nieprawidlowy podpunkt");
            }

        }

        static void zad10()
        {
            Console.WriteLine("Podaj silnie: ");
            int silnia = int.Parse(Console.ReadLine());
            int wynik = 1;


            for (int i = 1; i <= silnia; i++)
            {

                wynik *= i;

            }
            Console.WriteLine(wynik);

        }

        static void zad11()
        {
            int ilosc = 0, sum = 0, liczba = 1;
            while (sum < 100)
            {
                ilosc++;
                sum += liczba;
                liczba++;
            }
            Console.Write("Ilosc liczb to: " + ilosc);
        }
               
        static void zad12()
        {
            int wynik = 0;

        Strart:
            Console.WriteLine("Podaj liczbe: ");
            int liczba = int.Parse(Console.ReadLine());

            if (liczba == 0)
            {
                Console.WriteLine("Suma to: " + wynik);
            }
            else
            {
                wynik = wynik + liczba;
                goto Strart;
            }
        }
               
        static void zad13()
        {
            int n, suma = 0;
            Console.WriteLine("Podaj liczbę");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    suma -= i;
                else
                    suma += i;
            }
            Console.WriteLine(suma);
        }
               
        static void zad14()
        {
            Console.WriteLine("podaj liczbe zamykajaca przedzial szukania: ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int suma = 0;
                for (int j = 1; j < i; j++)

                    if (i % j == 0)
                        suma = suma + j;

                if (suma == i)
                    Console.WriteLine("Liczba doskonała: " + i);
            }
        }






        static void Main(string[] args)
        {
            Console.Write("Prosze podac numer zadania: ");
            int nr = int.Parse(Console.ReadLine());

            switch (nr) {
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
                                    
                case 14:
                    zad14();
                    break;



             }
        }
    }
}
