namespace Projekt_Restauracja
{
    class DanieDekorator : Danie
    {
        protected Danie _danie;

        public DanieDekorator(Danie danie)
        {
            _danie = danie;
        }
        public override string GetName()
        {
            return _danie.GetName();
        }

        public override double GetCena()
        {
            return _danie.GetCena();
        }


    }
}
