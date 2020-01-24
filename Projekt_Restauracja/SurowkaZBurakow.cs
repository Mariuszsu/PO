namespace Projekt_Restauracja
{
    class SurowkaZBurakow : DanieDekorator
    {
        public static double x = 2.5;
        public SurowkaZBurakow(Danie danie) : base(danie)
        {

        }
        public override double GetCena()
        {
            return base.GetCena() + x;
        }
        public override string GetName()
        {
            return base.GetName() + "Surowkę z Burakow ";
        }

    }
}
