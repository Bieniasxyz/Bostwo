using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bostwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Obsluga host = new Obsluga();
            host.DzialanieOgolne();

            

            //host.DodajOrganizm(new Organizm(false, 1, 5, "tesd"));
            //host.WyswietlWszystkieOrganizmy();
            string znak = Console.ReadLine();

            while (znak != "0")
            {
                host.PodejmijDzialanie(Convert.ToInt32(znak));
                znak = Console.ReadLine();
            }
        }
    }
}
