using System;
using System.Collections.Generic;
using System.Text;

namespace Bostwo
{
    public class Ssak : Organizm
    {
        private byte OdnozaDolne = 2;
        private byte OdnozaGorne = 2;
        public Ssak(bool CzyZyje, byte plec, byte odnoza, string nazwa)
        {
            DanePodstawowe(CzyZyje, plec, odnoza, nazwa);
        }
        public override bool OdzywiajSie()
        {
            return false;
        }
    }
}
