namespace Projekt_Restauracja
{
    class Klient : Osoba
    {
        public static double pieniadze;

        public Klient(string imie, string rola, double _pieniadze) : base(imie, rola)
        {
            pieniadze = _pieniadze;
        }

    }
}
