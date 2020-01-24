namespace Projekt_Restauracja
{
    class SurówkaZMarchewki : DanieDekorator
    {
        public static double x = 2.5;
        public SurówkaZMarchewki(Danie danie) : base(danie)
        {

        }
        public override double GetCena()
        {
            return base.GetCena() + x;
        }
        public override string GetName()
        {
            return base.GetName() + "Surowkę z Marchewki ";
        }

    }
}
