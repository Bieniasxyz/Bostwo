using System;
using System.Collections.Generic;
using System.Text;

namespace Bostwo
{
    class Obsluga
    {
        private List<Organizm> organizmy;
        private List<Ssak> ssaki;
        private List<Ptak> ptaki;

        public Obsluga()
        {
            organizmy = new List<Organizm>();
        }
        public void DzialanieOgolne()
        {
            Console.WriteLine("Powiedz co chcesz zrobić: \n\r");
            Console.WriteLine("1 - Dodaj organizm \n\r");
            Console.WriteLine("2 - Dodaj ssaka \n\r");
            Console.WriteLine("3 - Dodaj ptaka \n\r");
            Console.WriteLine("4 - Wyświetl Organizmy\n\r");
            Console.WriteLine("5 - Wyświetl sskai\n\r");
            Console.WriteLine("6 - Wyświetl ptaki\n\r");

        }
        public void PodejmijDzialanie(int liczba)
        {
            switch (liczba)
            {
                case 1:
                    DodajOrganizm(new Organizm());
                    break;
                default:
                    
                    break;
            }
        }
        public void WyswietlWszystkieOrganizmy()
        {
            WyswietlOrganizmy();
        }

        public void WyswietlOrganizmy()
        {
            foreach (var item in organizmy)
            {
                Console.WriteLine("Czy organizm zyje:" + InfoOZyciu(item.Zycie));
                Console.WriteLine("Ile organizm ma odnozy: " + item.Odnoza);
                Console.WriteLine("Jaka plec ma organizm: " + InfoOPlci(item.PlecOsobnika));
                Console.WriteLine("Nazwa organizmu to: " + item.Nazwa);
                Console.WriteLine("------------------------");
            }
        }
        private string InfoOPlci(byte liczba)
        {
            if (liczba == 1)
            {
                return "Samiec";
            }
            else if (liczba == 2)
            {
                return "Samica";
            }
            else
            {
                return "Obojniak";
            }
        }
        private string InfoOZyciu(bool zycie)
        {
            if (zycie == true)
            {
                return "Ja zyje";
            }
            else
            {
                return "R.I.P";
            }
        }

       public void DodajOrganizm(Organizm typ)
        {
            organizmy.Add(typ);
        }

        public void DodajSsaka(Ssak ssak)
        {
            ssaki.Add(ssak);
        }

        public void DodajPtaka(Ptak ptak)
        {
            ptaki.Add(ptak);
        }

        public void WyswietlSsaki()
        {
            foreach (var item in organizmy)
            {
                Console.WriteLine(item.Zycie);
                Console.WriteLine(item.PlecOsobnika.ToString());
            }
        }

    }
}
