using System;
using System.Collections.Generic;

namespace Projekt_Restauracja
{
    abstract class Menu
    {
        public static void PokazMenu()
        {
            List<string> Karta_Dan = new List<string>();
            Karta_Dan.Add("Kotlet Schabowy    ");
            Karta_Dan.Add("Kotlet Mielony     ");
            Karta_Dan.Add("Ziemniaki          ");
            Karta_Dan.Add("Ryz                ");
            Karta_Dan.Add("Surowka z Buraków  ");
            Karta_Dan.Add("Surowka z Kapusty  ");
            Karta_Dan.Add("Surowka z Marchewki");

            List<double> Cennik = new List<double>();
            Cennik.Add(Kotlet_schabowy.x);
            Cennik.Add(Kotlet_Mielony.x);
            Cennik.Add(Ziemniaki.x);
            Cennik.Add(Ryz.x);
            Cennik.Add(SurowkaZBurakow.x);
            Cennik.Add(SurowkaZKapusty.x);
            Cennik.Add(SurówkaZMarchewki.x);
            Console.WriteLine("Dania                Cena(zł)");
            for (int i = 0; i < Karta_Dan.Count; i++)
            {
                string value = Karta_Dan[i];
                double value2 = Cennik[i];
                Console.WriteLine("{0}   {1}", value, value2);
            }
        }

    }

}
