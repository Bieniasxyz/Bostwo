using System;
using System.Collections.Generic;
using System.Text;

namespace Bostwo
{
    public class Organizm : Wspolne, IFunkcjonowanie
    {
        public bool Zycie = false;
        public byte PlecOsobnika;
        public byte Odnoza;
        public string Nazwa;

        public Organizm()
        {
            Zycie = true;
            PlecOsobnika = 0;
            Random los = new Random();
            Odnoza = Convert.ToByte(los.Next(Byte.MinValue, Byte.MaxValue));
            Nazwa = "Nie nazwales mnie....";
        }

        public Organizm(bool CzyZyje, byte plec, byte odnoza, string nazwa)
        {
            DanePodstawowe(CzyZyje, plec, odnoza, nazwa);
        }

        protected virtual void DanePodstawowe(bool CzyZyje, byte plec, byte odnoza, string nazwa)
        {
            Zycie = CzyZyje;
            PlecOsobnika = plec;
            Odnoza = odnoza;
            Nazwa = nazwa;
        }

        ~Organizm()
        {
            Zycie = false;
        }
        public override void OdzywiajSie()
        {
            base.OdzywiajSie();
            Console.WriteLine("Mniam mniam");
        }

        public virtual void PoruszSie(int liczbakrokow, string kierunek)
        {
            Console.WriteLine("Ja " + Nazwa + "poruszam się w kierunku " + kierunek + " o " + liczbakrokow);
        }
    }
}
