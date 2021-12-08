using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium3
{
    class Autor : Osoba
    {
        private string narodowosc;


        public Autor() :
            base()
        {
            narodowosc = "Brak narodowosci";
        }

        public Autor(string imie_, string nazwisko_, string narodowosc_) :
            base(imie_, nazwisko_)
        {
            narodowosc = narodowosc_;
        }
    }
}
