using System;
using System.Collections.Generic;
using System.Text;

namespace Bostwo
{
    public class Organizm
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
            Nazwa = "Nie nawales mnie....";
        }

        public Organizm(bool CzyZyje, byte plec, byte odnoza, string nazwa)
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

    }
}
