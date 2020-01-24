namespace Projekt_Restauracja
{
    class Ziemniaki : DanieDekorator
    {
        public Ziemniaki(Danie danie) : base(danie)
        {

        }
        public override double GetCena()
        {
            return base.GetCena() + 2;
        }
        public override string GetName()
        {
            return base.GetName() + "Ziemniaki ";
        }

    }
}
