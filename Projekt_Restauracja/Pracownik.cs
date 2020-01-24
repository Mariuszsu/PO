using System;

namespace Projekt_Restauracja
{
    class Pracownik : Osoba
    {
        public Pracownik(string imie, string rola) : base(imie, rola)
        {

        }
        public void WydajReszte(double Pieniadze, double cena)
        {

            double reszta;
            reszta = Pieniadze - cena;
            if (reszta < 0)
            {
                Console.WriteLine("Niestety ma pan za mało pieniędzy nie możemy zrealizować pańskiego zamówienia");
            }
            else if (reszta > 0)
            {
                Console.WriteLine("Oto Pańskska reszta");
                Kasa.stan_kasy += cena;
                Console.WriteLine("{0} zł", reszta);
                Console.WriteLine("Dziękujemy i życzymy smacznego");
            }
            else
            {
                Kasa.stan_kasy += cena;
                Console.WriteLine("Dziękujemy i życzymy smacznego");
            }


        }
        public static void PrzedstawSie(string imie)
        {
            Console.WriteLine("Dzien dobry nazywam sie {0} i będę Państwa obsługiwał \nProsze o to nasze menu ", imie);
            Console.WriteLine();
            Menu.PokazMenu();
            Console.WriteLine();
            Console.WriteLine("Czy mogę przyjąc Państwa zamówienie");
        }
    }
}
