using System;
using System.Collections.Generic;
using System.Text;

namespace Bostwo
{
    class Ssak : Organizm, IFunkcjonowanie
    {
        private byte OdnozaDolne = 2;
        private byte OdnozaGorne = 2;
        private Ssak()
        {
            Zycie = true;
            Odnoza = 4;
        }
        public bool PoruszSie(bool Przod, bool Bok, byte OdnozaDolne, byte OdnozaGorne)
        {
            if (Przod == true || Bok == true)
            {
                if (OdnozaDolne != 0 || OdnozaGorne != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }

        }
    }
}
