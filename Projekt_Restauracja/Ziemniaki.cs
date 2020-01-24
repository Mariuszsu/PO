namespace Projekt_Restauracja
{
    class Ziemniaki : DanieDekorator
    {
        public static double x = 2;
        public Ziemniaki(Danie danie) : base(danie)
        {

        }
        public override double GetCena()
        {
            return base.GetCena() + x;
        }
        public override string GetName()
        {
            return base.GetName() + "Ziemniaki ";
        }

    }
}
