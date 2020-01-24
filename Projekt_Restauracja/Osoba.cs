namespace Projekt_Restauracja
{
    abstract public class Osoba
    {

        public static string imie;
        public string rola;

        public Osoba(string _imie, string _rola)
        {
            imie = _imie;
            rola = _rola;

        }
    }
}
