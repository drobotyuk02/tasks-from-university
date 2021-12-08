using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium3
{
    class Czasopismo : Pozycja
    {
        private int numer;


        public Czasopismo() :
            base()
        { 
            numer = 0;
        }

        public Czasopismo(string tytul_, int id_, string wydawnictwo_, int rokWydania_, int numer_) :
            base(tytul_, id_, wydawnictwo_, rokWydania_)
        {
            numer = numer_;
        }


        public override void WypiszInfo()
        {
            base.WypiszInfo();

            Console.WriteLine($"\nNumer: {numer}");
        }
    }
}
