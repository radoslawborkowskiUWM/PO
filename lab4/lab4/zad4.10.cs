using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
