using System;
using System.Collections.Generic;
using System.Text;

namespace Bostwo
{
    class Ptak : Organizm
    {
        public Ptak(bool CzyZyje, byte plec, byte odnoza, string nazwa)
        {
            DanePodstawowe(CzyZyje, plec, odnoza, nazwa);
        }
        public override void OdzywiajSie()
        {
            base.OdzywiajSie();
            Console.WriteLine("Mój dziobek właśnie zjadł nasionko :)");
        }
        public override void PoruszSie(int liczbakrokow, string kierunek)
        {
            Console.WriteLine("Ja " + Nazwa + "lecę sobie w kierunku " + kierunek + " o " + liczbakrokow);
        }
    }
}
