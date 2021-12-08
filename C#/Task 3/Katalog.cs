using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium3
{
    class Katalog : IZarzadzaniePozycjami
    {
        private string dzialTematyczny;
        private List<Pozycja> pozycje = new List<Pozycja>();
        

        public Katalog()
        {
            dzialTematyczny = "Brak działu tematycznego";
        }

        public Katalog(string dzialTematyczny_)
        {
            dzialTematyczny = dzialTematyczny_;
        }


        public string DzialTematyczny
        {
            get { return dzialTematyczny; }
        }


        public void DodajPozycje(Pozycja poz)
        {
            pozycje.Add(poz);
        }

        public void ZnajdzPozycjePoTytule(string tytulDoWyszukiwania)
        {
            foreach(Pozycja element in pozycje)
            {
                if(element.Tytul == tytulDoWyszukiwania)
                {
                    Console.WriteLine($"\nNazwa dzialu: {dzialTematyczny}");
                    element.WypiszInfo();
                }
            }
        }

        public void ZnajdzPozycjePoId(int idDoWyszukiwania)
        { 
            foreach (Pozycja element in pozycje)
            {
                if (element.Id == idDoWyszukiwania)
                {
                    Console.WriteLine($"\nNazwa dzialu: {dzialTematyczny}");
                    element.WypiszInfo();
                }
            }
        }

        public void ZnajdzWszystkiePozycje()
        {
            foreach (Pozycja element in pozycje)
            {
                Console.WriteLine($"\nNazwa dzialu: {dzialTematyczny}");
                element.WypiszInfo();
            }
        }
    }
}
