using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium3
{
    class Ksiazka : Pozycja
    {
        private int liczbaStron;
        private List<Autor> autorzy = new List<Autor>();
        

        public Ksiazka() :
            base()
        {
            liczbaStron = 0;
        }

        public Ksiazka(string tytul_, int id_, string wydawnictwo_, int rokWydania_, int liczbaStron_) :
            base(tytul_, id_, wydawnictwo_, rokWydania_)
        {
            liczbaStron = liczbaStron_;
        }


        public void DodajAutora(Autor autor)
        {
            autorzy.Add(autor);
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();

            Console.WriteLine($"\nLiczba stron: {liczbaStron}");

            if(autorzy.Count > 0)
            {
                for(int i = 0; i < autorzy.Count; i++)
                {
                    Console.WriteLine($"Autor numer {i+1}: {autorzy[i].Imie} {autorzy[i].Nazwisko}");
                }
            }
            else
            {
                Console.WriteLine("\nBrak autorzy");
            }
        }
    }
}
