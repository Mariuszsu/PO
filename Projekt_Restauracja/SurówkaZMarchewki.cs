namespace Projekt_Restauracja
{
    class SurówkaZMarchewki : DanieDekorator
    {
        public SurówkaZMarchewki(Danie danie) : base(danie)
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
