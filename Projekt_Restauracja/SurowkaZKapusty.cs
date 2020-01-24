namespace Projekt_Restauracja
{
    class SurowkaZKapusty : DanieDekorator
    {
        public static double x = 2.5;
        public SurowkaZKapusty(Danie danie) : base(danie)
        {

        }
        public override double GetCena()
        {
            return base.GetCena() + x;
        }
        public override string GetName()
        {
            return base.GetName() + "Surowkę z Kapusty ";
        }

    }
}
