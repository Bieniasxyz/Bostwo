using System;
using System.Collections.Generic;
using System.Text;

namespace Bostwo
{
    public class Ssak : Organizm, IFunkcjonowanie
    {
        public Ssak(bool CzyZyje, byte plec, byte odnoza, string nazwa)
        {
            DanePodstawowe(CzyZyje, plec, odnoza, nazwa);
        }
        public override void OdzywiajSie()
        {
            base.OdzywiajSie();
            Console.WriteLine("Nie dałeś mnie noża i widelca, więc zjem palcyma");
        }
        public override void PoruszSie(int liczbakrokow, string kierunek)
        {
            Console.WriteLine("Ja " + Nazwa + "idę sobie w kierunku " + kierunek + " o " + liczbakrokow);
        }

    }
}
