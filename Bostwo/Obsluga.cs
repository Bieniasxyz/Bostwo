using System;
using System.Collections.Generic;
using System.Text;

namespace Bostwo
{
    class Obsluga : Wspolne
    {
        private List<Organizm> organizmy;
        private List<Ssak> ssaki;
        private List<Ptak> ptaki;

        public Obsluga()
        {
            organizmy = new List<Organizm>();
            ssaki = new List<Ssak>();
            ptaki = new List<Ptak>();
        }
        public void DzialanieOgolne()
        {
            Console.WriteLine("Powiedz co chcesz zrobić: \n\r");
            Console.WriteLine("1 - Dodaj organizm \n\r");
            Console.WriteLine("2 - Dodaj ssaka \n\r");
            Console.WriteLine("3 - Dodaj ptaka \n\r");
            Console.WriteLine("4 - Wyświetl Organizmy\n\r");
            Console.WriteLine("5 - Wyświetl ssaki\n\r");
            Console.WriteLine("6 - Wyświetl ptaki\n\r");
            Console.WriteLine("7 - Wyświetl wszystko\n\r");
            Console.WriteLine("8 - Zabij wszystkie organizmy\n\r");
            Console.WriteLine("9 - Zabij wszystkie ssaki\n\r");
            Console.WriteLine("10 - Zabij wszystkie ptaki\n\r");
            Console.WriteLine("11 - Zabij wszystko\n\r");
            Console.WriteLine("0 - Wyjdź z programu\n\r");
        }
        public void PodejmijDzialanie(int liczba)
        {
            switch (liczba)
            {
                case 1:
                    string nazwa;
                    byte plec, odnoza;
                    DaneBytu(out nazwa, out plec, out odnoza);
                    DodajOrganizm(new Organizm(true, plec, odnoza, nazwa));
                    DzialanieOgolne();
                    break;
                case 2:

                    DaneBytu(out nazwa, out plec, out odnoza, 1);
                    DodajSsaka(new Ssak(true, plec, odnoza, nazwa));
                    DzialanieOgolne();
                    break;
                case 4:
                    WyswietlOrganizmy();
                    DzialanieOgolne();
                    break;
                case 5:
                    WyswietlSsaki();
                    DzialanieOgolne();
                    break;
                case 7:
                    WyswietlWszystkieOrganizmy();
                    DzialanieOgolne();
                    break;
                case 8:
                    Zabij(0);
                    DzialanieOgolne();
                    break;

                default:
                    
                    break;
            }
        }

        private static void DaneBytu(out string nazwa, out byte plec, out byte odnoza, int type = 0)
        {
            string rodzaj;
            switch (type)
            {
                case 1:
                    rodzaj = "Ssak";
                    break;
                case 2:
                    rodzaj = "Ptak";
                    break;
                default:
                    rodzaj = "Organizm";
                    break;
            }
            Console.WriteLine("Powiedz jak ma sie nazywac Twoj " + rodzaj);
            nazwa = Console.ReadLine();
            Console.WriteLine("Wybierz plec organizmu: 1- Samiec, 2 - Samica, 0 - Obojniak");
            plec = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Wybierz liczbe odnozy (maksimum 255): ");
            odnoza = Convert.ToByte(Console.ReadLine());
        }

        public void WyswietlWszystkieOrganizmy()
        {
            WyswietlOrganizmy();
            WyswietlSsaki();
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
            foreach (var item in ssaki)
            {
                Console.WriteLine("Czy organizm zyje:" + InfoOZyciu(item.Zycie));
                Console.WriteLine("Ile organizm ma odnozy: " + item.Odnoza);
                Console.WriteLine("Jaka plec ma organizm: " + InfoOPlci(item.PlecOsobnika));
                Console.WriteLine("Nazwa organizmu to: " + item.Nazwa);
                Console.WriteLine("------------------------");
            }
        }
        private void Zabij(int type)
        {
            Console.WriteLine("Właśnie zabiłeś: \n\r" );
            switch (type)
            {
                case 0: //Zabija organizmy
                    foreach (var item in organizmy)
                    {
                        Console.WriteLine("Organizm o nazwie: " + item.Nazwa);
                    }
                    organizmy.Clear();
                    break;
                
                default:
                    break;
            }
            
        }

    }
}
