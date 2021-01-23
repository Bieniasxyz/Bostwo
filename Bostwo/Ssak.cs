using System;
using System.Collections.Generic;
using System.Text;

namespace Bostwo
{
    class Ssak : Organizm
    {
        private byte OdnozaDolne = 2;
        private byte OdnozaGorne = 2;
        private Ssak()
        {
            Zycie = true;
            Odnoza = 4;
        }
        public virtual bool PoruszenieSie(bool Przod = false, bool Bok = false, byte OdnozaDolne = 0, byte OdnozaGorne = 0)
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
