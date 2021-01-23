using System;
using System.Collections.Generic;
using System.Text;

namespace Bostwo
{
    class Organizm
    {
        protected bool Zycie = false;
        protected enum Plec
        {
            Samica,
            Samiec,
            Obojniak
        }
        protected byte PlecOsobnika = Convert.ToByte(Plec.Obojniak);
        protected byte Odnoza;

        protected Organizm()
        {
            Zycie = true;
        }
        protected Organizm(bool CzyZyje, string Plec)
        {
            Zycie = CzyZyje;

        }
        ~Organizm()
        {
            Zycie = false;
        }

    }
}
