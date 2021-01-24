using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bostwo
{
    public class Wspolne 
    {
        public virtual bool PoruszSie(bool Przod, bool Bok, byte OdnozaDolne, byte OdnozaGorne) 
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
        public virtual bool OdzywiajSie()
        {
            return true;
        }
    }
}
