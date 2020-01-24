namespace Projekt_Restauracja
{
    class Kotlet_Mielony : DanieDekorator
    {
        public Kotlet_Mielony(Danie danie) : base(danie)
        {

        }
        public override double GetCena()
        {
            return base.GetCena() + 10;
        }
        public override string GetName()
        {
            return base.GetName() + "Kotlet Mielony ";
        }

    }
}
