namespace Projekt_Restauracja
{
    class SurowkaZKapusty : DanieDekorator
    {
        public SurowkaZKapusty(Danie danie) : base(danie)
        {

        }
        public override double GetCena()
        {
            return base.GetCena() + 2.5;
        }
        public override string GetName()
        {
            return base.GetName() + "Surowka z Marchewki ";
        }

    }
}
