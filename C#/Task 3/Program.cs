using System;

namespace Laboratorium3
{
    class Program
    {
        static void Main(string[] args)
        {
            Katalog kat = new Katalog("Początkowy");

            Ksiazka ks1 = new Ksiazka("Oliver Twist", 185812519, "PolWyd2", 1838, 331);
            Czasopismo cz1 = new Czasopismo("Nasze Czasopismo", 330021, "PolWyd", 2015, 19);

            Autor a1 = new Autor("Charles", "Dickens", "Brytyjczyk");
            ks1.DodajAutora(a1);

            kat.DodajPozycje(ks1);
            kat.DodajPozycje(cz1);

            Bibliotekarz bibl1 = new Bibliotekarz("Anna", "Nowak", "21.03.2021", 300.5);
            Bibliotekarz bibl2 = new Bibliotekarz("Adam", "Kowal", "21.03.2021", 300.5);

            Biblioteka biblioteka = new Biblioteka("ul.Przykładowa 1");

            biblioteka.DodajBibliotekarza(bibl1);
            biblioteka.DodajBibliotekarza(bibl2);
            biblioteka.DodajKatalog(kat);

            biblioteka.WypiszBibliotekarzy();

            biblioteka.ZnajdzPozycjePoId(185812519);
        }
    }
}
