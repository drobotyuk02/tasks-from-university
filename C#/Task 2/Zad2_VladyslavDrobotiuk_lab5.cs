using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium2
{
    class Ocena
    {
        private string nazwaPrzedmiotu;
        private string data;
        private double wartosc;

        public Ocena(string nazwaPrzedmiotu_, string data_, double wartosc_)
        {
            nazwaPrzedmiotu = nazwaPrzedmiotu_;
            data = data_;
            wartosc = wartosc_;
        }


        public string NazwaPrzedmiotu
        {
            get { return nazwaPrzedmiotu; }
            set { nazwaPrzedmiotu = value; }
        }

        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        public double Wartosc
        {
            get { return wartosc; }
            set { wartosc = value; }
        }


        public void WypiszInfo()
        {
            Console.WriteLine($"\nNazwa przedmiotu: {NazwaPrzedmiotu}");
            Console.WriteLine($"Data wystawienia: {Data}");
            Console.WriteLine($"Ocena: {Wartosc}");
        }
    }

    class Zadanie2
    { 
    }
}
