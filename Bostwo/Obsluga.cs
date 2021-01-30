using System;
using System.Collections.Generic;
using System.Text;

namespace Bostwo
{
    class Obsluga : Wspolne
    {
        private List<Organizm> Organizmy { get; set; }
        private List<Ssak> Ssaki { get; set; }
        private List<Ptak> Ptaki { get; set; }

        public Obsluga()
        {
            Organizmy = new List<Organizm>();
            Ssaki = new List<Ssak>();
            Ptaki = new List<Ptak>();
        }
        
        public void PodejmijDzialanie(int liczba)
        {
            int znak, obiektnumer;
            string nazwa;
            byte plec, odnoza;
            switch (liczba)
            {
                case 1:
                    DaneBytu(out nazwa, out plec, out odnoza);
                    DodajOrganizm(new Organizm(true, plec, odnoza, nazwa));
                    DzialanieOgolne();
                    break;
                case 2:

                    DaneBytu(out nazwa, out plec, out odnoza, 1);
                    DodajSsaka(new Ssak(true, plec, odnoza, nazwa));
                    DzialanieOgolne();
                    break;
                case 3:
                    DaneBytu(out nazwa, out plec, out odnoza, 2);
                    DodajPtaka(new Ptak(true, plec, odnoza, nazwa));
                    DzialanieOgolne();
                    break;

                case 4:
                    WyswietlOrganizmy();
                    DzialanieSzczegolne();
                    WstepDzialanSzczegolnych(out znak, out obiektnumer);
                    while (znak != 9)
                    {
                        switch (znak)
                        {
                            case 1:
                                znak = ZmienNazweOrganizmu(obiektnumer);
                                break;
                            case 2:
                                znak = ZmienPlecOrganizmu(obiektnumer);
                                break;
                            case 3:
                                znak = ZmienLiczbeOdnozyOrganizmu(obiektnumer);
                                break;
                            case 4:
                                OdzywiajSie();
                                znak = 0;
                                break;
                            case 5:
                                znak = PoruszamSie(obiektnumer);
                                break;
                            case 6:
                                znak = KlonujOrganizm(obiektnumer);
                                break;
                            case 7:
                                znak = ZabijOrganizm(obiektnumer);
                                break;
                            case 8:
                                znak = UnicestwijOrganizm(obiektnumer);
                                break;
                            default:
                                znak = 0;
                                break;

                        }
                        DzialanieOgolne();
                    }
                    break;
                case 5:
                    WyswietlSsaki();
                    DzialanieSzczegolne();
                    WstepDzialanSzczegolnych(out znak, out obiektnumer);
                    while (znak != 9)
                    {
                        switch (znak)
                        {
                            case 1:
                                znak = ZmienNazweOrganizmu(obiektnumer, 1);
                                break;
                            case 2:
                                znak = ZmienPlecOrganizmu(obiektnumer, 1);
                                break;
                            case 3:
                                znak = ZmienLiczbeOdnozyOrganizmu(obiektnumer, 1);
                                break;
                            case 4:
                                Ssaki[obiektnumer - 1].OdzywiajSie();
                                znak = 0;
                                break;
                            case 5:
                                znak = PoruszamSie(obiektnumer, 1);
                                break;
                            case 6:
                                znak = KlonujOrganizm(obiektnumer, 1);
                                break;
                            case 7:
                                znak = ZabijOrganizm(obiektnumer, 1);
                                break;
                            case 8:
                                znak = UnicestwijOrganizm(obiektnumer, 1);
                                break;
                            default:
                                znak = 0;
                                break;
                        }
                    }
                        DzialanieOgolne();
                        break;
                case 6:
                    wyswietlPtaki();
                    DzialanieSzczegolne();
                    WstepDzialanSzczegolnych(out znak, out obiektnumer);
                    while (znak != 9)
                    {
                        switch (znak)
                        {
                            case 1:
                                znak = ZmienNazweOrganizmu(obiektnumer, 2);
                                break;
                            case 2:
                                znak = ZmienPlecOrganizmu(obiektnumer, 2);
                                break;
                            case 3:
                                znak = ZmienLiczbeOdnozyOrganizmu(obiektnumer, 2);
                                break;
                            case 4:
                                Ptaki[obiektnumer - 1].OdzywiajSie();
                                znak = 0;
                                break;
                            case 5:
                                znak = PoruszamSie(obiektnumer, 2);
                                break;
                            case 6:
                                znak = KlonujOrganizm(obiektnumer, 2);
                                break;
                            case 7:
                                znak = ZabijOrganizm(obiektnumer, 2);
                                break;
                            case 8:
                                znak = UnicestwijOrganizm(obiektnumer, 2);
                                break;
                            default:
                                znak = 0;
                                break;
                        }
                    }
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
                case 9:
                    Zabij(1);
                    DzialanieOgolne();
                    break;
                case 10:
                    Zabij(2);
                    DzialanieOgolne();
                    break;
                case 11:

                    if (Organizmy.Count > 0)
                    {
                        Zabij(0);
                    }
                    if (Ssaki.Count > 0)
                    {
                        Zabij(1);
                    }
                    if (Ptaki.Count > 0)
                    {
                        Zabij(2);
                    }
                    DzialanieOgolne();
                    break;

                default:
                    throw new NotImplementedException();
 
            }
        }

        private int PoruszamSie(int obiektnumer, int typ = 0)
        {
            int znak;
            Console.WriteLine("Powiedz o ile mam się poruszyć");
            int kroki = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Powiedz ww jakim kierunku mam się poruszyć");
            string kierunek = Console.ReadLine();
            if (typ ==0)
            {
                Organizmy[obiektnumer].PoruszSie(kroki, kierunek);
            }
            else if(typ ==1)
            {
                Ssaki[obiektnumer].PoruszSie(kroki, kierunek);
            }
            else
            {
                Ptaki[obiektnumer].PoruszSie(kroki, kierunek);
            }
            znak = 0;
            return znak;
        }

        private int UnicestwijOrganizm(int obiektnumer, int typ = 0)
        {
            int znak;
            if (typ == 0)
            {
                Organizmy.Remove(Organizmy[obiektnumer - 1]);
                Console.WriteLine("Unicestwiono organizm");
            }
            else if(typ == 1)
            {
                Ssaki.Remove(Ssaki[obiektnumer - 1]);
                Console.WriteLine("Unicestwiono Ssaka");
            }
            else 
            {
                Ptaki.Remove(Ptaki[obiektnumer - 1]);
                Console.WriteLine("Unicestwiono Ptaka");
            }
            znak = 0;
            return znak;
        }

        private int ZabijOrganizm(int obiektnumer, int typ = 0)
        {
            int znak;
            if (typ == 0)
            {
                Organizmy[obiektnumer - 1].Zycie = false;
                Console.WriteLine("Zabito Organizm");
            }
            else if (typ ==1)
            {
                Ssaki[obiektnumer - 1].Zycie = false;
                Console.WriteLine("Zabito Ssaka");
            }
            else
            {
                Ptaki[obiektnumer - 1].Zycie = false;
                Console.WriteLine("Zabito Ptaka");
            }

            znak = 0;
            return znak;
        }

        private int KlonujOrganizm(int obiektnumer, int typ = 0)
        {
            int znak;
            if (typ == 0)
            {
                WykonajKlonowanieOrganizmu(obiektnumer);
            }
            else if (typ == 1)
            {
                WykonajKlonowanieSsaka(obiektnumer);
            }
            else
            {
                WykonajKlonowaniePtaka(obiektnumer);
            }

            Console.WriteLine("Sklonowano obiekt");
            znak = 0;
            return znak;
        }

        private void WykonajKlonowanieOrganizmu(int obiektnumer)
        {
            if (Organizmy.Count > 1)
            {
                var klon = new Organizm(Organizmy[obiektnumer - 1].Zycie, Organizmy[obiektnumer - 1].PlecOsobnika, Organizmy[obiektnumer - 1].Odnoza, Organizmy[obiektnumer - 1].Nazwa);
                Organizmy.Add(klon);
            }
            else
            {
                var klon = new Organizm(Organizmy[obiektnumer].Zycie, Organizmy[obiektnumer].PlecOsobnika, Organizmy[obiektnumer].Odnoza, Organizmy[obiektnumer].Nazwa);
                Organizmy.Add(klon);
            }
        }
        private void WykonajKlonowanieSsaka(int obiektnumer)
        {
            if (Organizmy.Count > 1)
            {
                var klon = new Ssak(Ssaki[obiektnumer - 1].Zycie, Ssaki[obiektnumer - 1].PlecOsobnika, Ssaki[obiektnumer - 1].Odnoza, Ssaki[obiektnumer - 1].Nazwa);
                Ssaki.Add(klon);
            }
            else
            {
                var klon = new Ssak(Ssaki[obiektnumer].Zycie, Ssaki[obiektnumer].PlecOsobnika, Ssaki[obiektnumer].Odnoza, Ssaki[obiektnumer].Nazwa);
                Ssaki.Add(klon);
            }
        }
        private void WykonajKlonowaniePtaka(int obiektnumer)
        {
            if (Organizmy.Count > 1)
            {
                var klon = new Ptak(Ptaki[obiektnumer - 1].Zycie, Ptaki[obiektnumer - 1].PlecOsobnika, Ptaki[obiektnumer - 1].Odnoza, Ptaki[obiektnumer - 1].Nazwa);
                Ptaki.Add(klon);
            }
            else
            {
                var klon = new Ptak(Ptaki[obiektnumer].Zycie, Ptaki[obiektnumer].PlecOsobnika, Ptaki[obiektnumer].Odnoza, Ptaki[obiektnumer].Nazwa);
                Ptaki.Add(klon);
            }
        }

        private int ZmienLiczbeOdnozyOrganizmu(int obiektnumer, int typ = 0)
        {
            int znak;
            Console.WriteLine("Podaj nową liczbę odnóży (max 255)");
            if (typ == 0 )
            {
                Organizmy[obiektnumer - 1].Odnoza = Convert.ToByte(Console.ReadLine());
            }
            else if (typ ==1)
            {
                Ssaki[obiektnumer - 1].Odnoza = Convert.ToByte(Console.ReadLine());
            }
            else
            {
                Ptaki[obiektnumer - 1].Odnoza = Convert.ToByte(Console.ReadLine());
            }
            znak = 0;
            return znak;
        }

        private int ZmienPlecOrganizmu(int obiektnumer, int typ = 0)
        {
            int znak;

            if (obiektnumer == 1)
            {
                obiektnumer = 2;
            }
            Console.WriteLine("Wybierz nową płeć: 1 - samiec, 2 - samica, 3 - obojniak");
            if (typ == 0)
            {
                Organizmy[obiektnumer - 1].PlecOsobnika = Convert.ToByte(Console.ReadLine());
            }
            else if(typ == 1)
            {
                Ssaki[obiektnumer - 1].PlecOsobnika = Convert.ToByte(Console.ReadLine());
            }
            else
            {
                Ptaki[obiektnumer - 1].PlecOsobnika = Convert.ToByte(Console.ReadLine());
            }
            znak = 0;
            return znak;
        }

        private int ZmienNazweOrganizmu(int obiektnumer, int typ = 0)
        {
            int znak;
            Console.WriteLine("Podaj nową nazwę obiektu");
            if (typ == 0)
            {
                Organizmy[obiektnumer - 1].Nazwa = Console.ReadLine();
                DzialanieSzczegolne();
            }
            else if (typ == 1)
            {
                Ssaki[obiektnumer - 1].Nazwa = Console.ReadLine();
                DzialanieSzczegolne();
            }
            else
            {
                Ptaki[obiektnumer - 1].Nazwa = Console.ReadLine();
                DzialanieSzczegolne();
            }
            znak = 0;
            return znak;
        }


        protected static void DaneBytu(out string nazwa, out byte plec, out byte odnoza, int type = 0)
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
            wyswietlPtaki();
        }

        public void WyswietlOrganizmy()
        {
            int i = 1;
            foreach (var item in Organizmy)
            {
                Console.WriteLine("Organizm numer: " + i);
                Console.WriteLine("Czy organizm zyje:" + InfoOZyciu(item.Zycie));
                Console.WriteLine("Ile organizm ma odnozy: " + item.Odnoza);
                Console.WriteLine("Jaka plec ma organizm: " + InfoOPlci(item.PlecOsobnika));
                Console.WriteLine("Nazwa organizmu to: " + item.Nazwa);
                Console.WriteLine("------------------------");
                i++;
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
            Organizmy.Add(typ);
        }

        public void DodajSsaka(Ssak ssak)
        {
            Ssaki.Add(ssak);
        }

        public void DodajPtaka(Ptak ptak)
        {
            Ptaki.Add(ptak);
        }

        public void WyswietlSsaki()
        {
            foreach (var item in Ssaki)
            {
                Console.WriteLine("Czy Ssak zyje:" + InfoOZyciu(item.Zycie));
                Console.WriteLine("Ile ssak ma nog: " + item.Odnoza);
                Console.WriteLine("Jaka plec ma ssak: " + InfoOPlci(item.PlecOsobnika));
                Console.WriteLine("Nazwa Ssaka to: " + item.Nazwa);
                Console.WriteLine("------------------------");
            }
        }
        public void wyswietlPtaki()
        {
            foreach (var item in Ptaki)
            {
                Console.WriteLine("Czy ptak zyje:" + InfoOZyciu(item.Zycie));
                Console.WriteLine("Ile ptak ma skrzydeł: " + item.Odnoza);
                Console.WriteLine("Jaka plec ma ptak: " + InfoOPlci(item.PlecOsobnika));
                Console.WriteLine("Nazwa ptaka to: " + item.Nazwa);
                Console.WriteLine("------------------------");
            }
        }
        private void Zabij(int type)
        {
            Console.WriteLine("Właśnie zabiłeś: \n\r" );
            switch (type)
            {
                case 0: //Zabija organizmy
                    foreach (var item in Organizmy)
                    {
                        Console.WriteLine(" Organizm o nazwie: " + item.Nazwa);
                    }
                    Organizmy.Clear();
                break;

                case 1: //Zabija ssaki
                    foreach (var item in Ssaki)
                    {
                        Console.WriteLine(" Ssaka o nazwie: " + item.Nazwa);
                    }
                    Ssaki.Clear();
                break;
                case 2: //Zabija ptaki
                    foreach (var item in Ptaki)
                    {
                        Console.WriteLine(" Ptaka o nazwie: " + item.Nazwa);
                    }
                    Ptaki.Clear();
                    break;
            }
            
        }

    }
}
