using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium3
{
    class Bibliotekarz : Osoba
    {
        private string dataZatrudnienia;
        private double wynagrodzenie;


        public Bibliotekarz() :
            base()
        {
            dataZatrudnienia = "Brak daty zatrudnienia";
            wynagrodzenie = 0.0;
        }

        public Bibliotekarz(string imie_, string nazwisko_, string dataZatrudnienia_, double wynagrodzenie_) : 
            base(imie_, nazwisko_)
        {
            dataZatrudnienia = dataZatrudnienia_;
            wynagrodzenie = wynagrodzenie_;
        }

        public string DataZatrudnienia
        {
            get { return dataZatrudnienia; }
        }

        public double Wynagrodzenie
        {
            get { return wynagrodzenie; }
        }
    }
}
