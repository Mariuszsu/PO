namespace Projekt_Restauracja
{
    class Kotlet_schabowy : DanieDekorator
    {
        public Kotlet_schabowy(Danie danie) : base(danie)
        {

        }
        public override double GetCena()
        {
            return base.GetCena() + 10;
        }
        public override string GetName()
        {
            return base.GetName() + "Kotlet Schabowy ";
        }

    }
}
