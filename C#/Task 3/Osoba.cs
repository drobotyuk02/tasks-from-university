using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium3
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;

        public Osoba()
        {
            imie = "Brak imiona";
            nazwisko = "Brak nazwiska";
        }

        public Osoba(string imie_, string nazwisko_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
        }


        public string Imie
        {
            get { return imie; }
        }

        public string Nazwisko
        {
            get { return nazwisko; }
        }
    }
}
