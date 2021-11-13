using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
