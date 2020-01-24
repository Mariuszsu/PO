namespace Projekt_Restauracja
{
    class Ryz : DanieDekorator
    {
        public static double x = 2;
        public Ryz(Danie danie) : base(danie)
        {

        }
        public override double GetCena()
        {
            
            return base.GetCena() + x;
        }
        public override string GetName()
        {
            return base.GetName() + "Ryz ";
        }

    }
}
