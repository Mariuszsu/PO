namespace Projekt_Restauracja
{
    class Kotlet_Mielony : DanieDekorator
    {
        public static double x = 10;
        
        public Kotlet_Mielony(Danie danie) : base(danie)
        {
       
        }
        public override double GetCena()
        {
            return base.GetCena() + x;
        }
        public override string GetName()
        {
            return base.GetName() + "Kotlet Mielony ";
        }

    }
}
