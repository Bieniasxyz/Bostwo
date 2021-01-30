using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bostwo
{
    public class Wspolne 
    {
        public virtual void OdzywiajSie()
        {
            
        }
        protected void DzialanieSzczegolne()
        {
            Console.WriteLine("Powiedz co chcesz zrobić: \n\r");
            Console.WriteLine("1 - Zmien nazwe: \n\r");
            Console.WriteLine("2 - Zmień płeć: \n\r");
            Console.WriteLine("3 - Zmień liczbę odnóży: \n\r");
            Console.WriteLine("4 - Porusz się: \n\r");
            Console.WriteLine("5 - Zjedz: \n\r");
            Console.WriteLine("6 - Klonuj: \n\r");
            Console.WriteLine("7 - Zabij: \n\r");
            Console.WriteLine("8 - Unicestwij: \n\r");
            Console.WriteLine("9 - Wroć do menu ogólnego: \n\r");
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
            Console.WriteLine("8 - Unicestwij wszystkie organizmy\n\r");
            Console.WriteLine("9 - Unicestwij wszystkie ssaki\n\r");
            Console.WriteLine("10 - Unicestwij wszystkie ptaki\n\r"); //nie zrobione
            Console.WriteLine("11 - Unicestwij wszystko\n\r");
            Console.WriteLine("0 - Wyjdź z programu\n\r");
        }
        protected void WstepDzialanSzczegolnych(out int znak, out int obiektnumer)
        {
            obiektnumer = 0;
            znak = Convert.ToInt32(Console.ReadLine());
            if (znak != 0)
            {
                Console.WriteLine("Wybierz obiekt swoich działań (podaj numer obiektu): ");
                obiektnumer = Convert.ToInt32(Console.ReadLine());
            }
            
        }
    }
}
