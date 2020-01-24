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
                Console.WriteLine("Oto Pańska reszta");
                Kasa.stan_kasy += cena;
                Console.WriteLine("{0} zł", reszta);
                Console.WriteLine("Dziękujemy i zapraszamy ponownie");
            }
            else
            {
                Kasa.stan_kasy += cena;
                Console.WriteLine("Dziękujemy i zapraszamy ponownie");
            }


        }
        public static void PrzedstawSie(string imie)
        {
            Console.WriteLine("Dzien dobry nazywam sie {0} i będę Państwa obsługiwał \nProsze o to menu ", imie);
            Console.WriteLine();
            Menu.PokazMenu();
            Console.WriteLine();
            Console.WriteLine("Czy mogę przyjąc Państwa zamówienie");
        }
    }
}
