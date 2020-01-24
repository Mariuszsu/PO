namespace Projekt_Restauracja
{
    class SurowkaZBurakow : DanieDekorator
    {
        public SurowkaZBurakow(Danie danie) : base(danie)
        {

        }
        public override double GetCena()
        {
            return base.GetCena() + 2.5;
        }
        public override string GetName()
        {
            return base.GetName() + "Surowka z Burakow ";
        }

    }
}
