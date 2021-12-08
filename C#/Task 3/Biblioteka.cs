using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium3
{
    class Biblioteka : IZarzadzaniePozycjami, IZarzadzanieBibliotekarzami
    {
        private string adres;
        private List<Katalog> katalogi = new List<Katalog>();
        private List<Bibliotekarz> bibliotekarzy = new List<Bibliotekarz>();

        public Biblioteka()
        {
            adres = "Brak adresu";
        }

        public Biblioteka(string adres_)
        {
            adres = adres_;
        }
        

        public void DodajBibliotekarza(Bibliotekarz bibl)
        {
            bibliotekarzy.Add(bibl);
        }

        public void WypiszBibliotekarzy()
        {
            if(bibliotekarzy.Count > 0)
            {
                foreach (Bibliotekarz element in bibliotekarzy)
                {
                    Console.WriteLine($"\nImie: {element.Imie}");
                    Console.WriteLine($"Nazwisko : {element.Nazwisko}");
                    Console.WriteLine($"Data zatrudnienia: {element.DataZatrudnienia}");
                    Console.WriteLine($"Wnagrodzenie: {element.Wynagrodzenie}");
                }
            }
        }

        public void DodajKatalog(Katalog kat)
        {
            katalogi.Add(kat);
        }

        public void DodajPozycje(Pozycja p, string dzialTematczny_)
        {
            foreach(Katalog element in katalogi)
            {
                if (element.DzialTematyczny == dzialTematczny_)
                {
                    element.DodajPozycje(p);
                }
            }
        }

        public void ZnajdzPozycjePoTytule(string tytulDoWyszukiwania)
        {
            foreach (Katalog element in katalogi)
            {
                element.ZnajdzPozycjePoTytule(tytulDoWyszukiwania);
            }
        }

        public void ZnajdzPozycjePoId(int idDoWyszukiwania)
        {
            foreach (Katalog element in katalogi)
            {
                element.ZnajdzPozycjePoId(idDoWyszukiwania);
            }
        }

        public void ZnajdzWszystkiePozycje()
        {
            foreach (Katalog element in katalogi)
            {
                element.ZnajdzWszystkiePozycje();
            }
        }
    }
}
