using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium3
{
    interface IZarzadzaniePozycjami
    {
        public void ZnajdzPozycjePoTytule(string tytulDoWyszukiwania);
        public void ZnajdzPozycjePoId(int idDoWyszukiwania);
        public void ZnajdzWszystkiePozycje();
    }
}
