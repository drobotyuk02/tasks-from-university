using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboratorium1
{
    public class Osoba
    {
        private string imie;
        private string nazwisko;
        private string adresZamieszkania;
        private int iloscSamochodow = 0;
        private Samochod[] samochody;


        public Osoba()
        {
            imie = "nieznane";
            nazwisko = "nieznane";
            adresZamieszkania = "neznany";
        }

        public Osoba(string imie_, string nazwisko_, string adresZamieszkania_, int iloscSamochodow_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
            adresZamieszkania = adresZamieszkania_;
            iloscSamochodow = iloscSamochodow_;
            samochody = new Samochod[iloscSamochodow_];
        }


        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }

        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        public string AdresZamieszkania
        {
            get { return adresZamieszkania; }
            set { adresZamieszkania = value; }
        }

        public int IloscSamochodow
        {
            get { return iloscSamochodow; }
            set
            {
                iloscSamochodow = value;
                samochody = new Samochod[iloscSamochodow];
            }
        }


        public void DodajSamochod(string nrRejestracyjny)
        {
            if (iloscSamochodow < 3)
            {
                Console.WriteLine("Dodanie numeru rejestracyjnego dla samochodu nr" + (iloscSamochodow+1) + '\n');
                samochody[iloscSamochodow].NumerRejestracyjny = nrRejestracyjny;

                iloscSamochodow++;
            }
            else
            {
                Console.WriteLine("Liczba samochodów już jest równa 3 \n");
            }
        }

        public void UsunSamochod(string nrRejestracyjny)
        {
            if (iloscSamochodow == 0)
            {
                Console.WriteLine("Osoba nie posiada samochodów");
            }
            else
            {
                Console.WriteLine("Usunięcie numeru rejesracyjnego: " + nrRejestracyjny);
                for (int i = 0; i < iloscSamochodow; i++)
                {
                    if (samochody[i].NumerRejestracyjny == nrRejestracyjny)
                        samochody[i] = null;
                }

                iloscSamochodow--;
            }
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Imie: " + imie);
            Console.WriteLine("Nazwisko: " + nazwisko);
            Console.WriteLine("Adres zamieszkania: " + adresZamieszkania);

            if (iloscSamochodow > 0)
            {
                Console.WriteLine("Osoba posiada " + iloscSamochodow + "samochód/y");
                for (int i = 0; i < iloscSamochodow; i++)
                {
                    Console.WriteLine("Numer rejestracyjny samochodu nr" + (i + 1) + " to " +
                        samochody[iloscSamochodow - 1].NumerRejestracyjny);
                }
            }
            else
                Console.WriteLine("Osoba nie posiada samochodu");
        }
    }

    class Zadanie3
    {
    }
}
