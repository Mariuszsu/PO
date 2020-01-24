namespace Projekt_Restauracja
{
    class Kotlet_schabowy : DanieDekorator
    {
        public static double x = 10;
        public Kotlet_schabowy(Danie danie) : base(danie)
        {

        }
        public override double GetCena()
        {
            return base.GetCena() + x;
        }
        public override string GetName()
        {
            return base.GetName() + "Kotlet Schabowy ";
        }

    }
}
