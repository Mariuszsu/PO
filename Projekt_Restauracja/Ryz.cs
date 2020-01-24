namespace Projekt_Restauracja
{
    class Ryz : DanieDekorator
    {
        public Ryz(Danie danie) : base(danie)
        {

        }
        public override double GetCena()
        {
            return base.GetCena() + 2;
        }
        public override string GetName()
        {
            return base.GetName() + "Ryz ";
        }

    }
}
