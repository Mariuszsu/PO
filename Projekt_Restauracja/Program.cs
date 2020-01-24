/*Scenariusz zakłada 2 klientów pierwszy złozy zamówienie następnie kelner wyda mu reszte natomiast drugi
 * złozy zamówienie lecz nie bedzie miał czym zapłacić więc zostanie wyproszony
 * Na koncu zostanie wyswietlony komunikat o dziennym przychodzie i stanie kasy 

*/
using System;

namespace Projekt_Restauracja
{
    class Program : Kasa
    {
        static void Main(string[] args)
        {
            double cena;
            double cena2;
            Klient Andrzej = new Klient("Andrzej", "Klient", 50);

            Pracownik Kamil = new Pracownik("Kamil", "Kelner");
            Pracownik.PrzedstawSie(Pracownik.imie);

            Console.WriteLine("Klient 1");
            Danie Zestaw1 = new Zestaw();
            Zestaw1 = new Kotlet_schabowy(Zestaw1);
            Zestaw1 = new Ziemniaki(Zestaw1);
            Zestaw1 = new SurówkaZMarchewki(Zestaw1);
            cena = Zestaw1.GetCena();
            Console.WriteLine("Poprosze " + Zestaw1.GetName());

            Danie Zestaw2 = new Zestaw();
            Zestaw2 = new Kotlet_Mielony(Zestaw2);
            Zestaw2 = new Ryz(Zestaw2);
            Zestaw2 = new SurówkaZMarchewki(Zestaw2);
            Zestaw2 = new SurowkaZBurakow(Zestaw2);
            cena2 = Zestaw2.GetCena();





            Kamil.WydajReszte(Klient.pieniadze, cena);
            Console.WriteLine("\n\nKlient 2");
            Klient Patryk = new Klient("Patryk", "Klient", 10);
            Kamil.WydajReszte(Klient.pieniadze, cena2);
            Przychód_dzienny(stan_kasy);
            Console.WriteLine("Koncowy stan kasy {0}", stan_kasy);
            Console.ReadKey();
        }
    }
}
