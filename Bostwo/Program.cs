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

            int znak = Convert.ToInt32(Console.ReadLine());

            while (znak != 0)
            {
                host.PodejmijDzialanie(Convert.ToInt32(znak));
                znak = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
