using System;

namespace Projekt_Restauracja
{
    public class Kasa
    {
        public static double stan_kasy = 100;

        public static void Przychód_dzienny(double stan_kasy)
        {
            double Przychód = stan_kasy - 100;
            Console.WriteLine("Dzienny przychod wynosi {0} zł", Przychód);
        }
        public static void Stan_kasy(double stan_kasy)
        {

            Console.WriteLine("Stan kasy na chwile obecna {0}", stan_kasy);
        }
    }
}
