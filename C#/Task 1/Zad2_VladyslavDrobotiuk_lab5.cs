using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboratorium1
{
    public class Garaz
    {
        private string adres;
        private int pojemnosc;
        private int liczbaSamochodow = 0;
        private Samochod[] samochody;


        public Garaz()
        {
            adres = "nieznany";
            pojemnosc = 0;
            samochody = null;
        }

        public Garaz(string adres_, int pojemnosc_)
        {
            adres = adres_;
            pojemnosc = pojemnosc_;
            samochody = new Samochod[pojemnosc_];
        }


        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }

        public int Pojemnosc
        {
            get { return pojemnosc; }
            set
            {
                pojemnosc = value;
                samochody = new Samochod[pojemnosc];
            }
        }

        public int LiczbaSamochodow
        {
            get { return liczbaSamochodow; }
            set { liczbaSamochodow = value; }
        }


        public void WprowadzSamochod(Samochod sam)
        {
            if (liczbaSamochodow == pojemnosc)
                Console.WriteLine("Garaż jest zapełniony!");
            else
            {
                //samochody.Append(sam);
                //lub
                //samochody[liczbaSamochodow] = new Samochod(sam.Marka, sam.Model, sam.IloscDrzwi, sam.PojemnoscSilnika, sam.SrednieSpalanie);

                liczbaSamochodow++;
            }
        }

        public Garaz WyprowadzSamochod()  //u Pana w instrukcji jest błąd, że metoda WyprowadzSamochod() ma
        {                                 //wartość zwracalną typu Samochod
            if (liczbaSamochodow == 0)
                Console.WriteLine("Garaż jest pusty!");
            else
            {
                samochody[liczbaSamochodow - 1] = null;
                Console.WriteLine("Samochód " + liczbaSamochodow + " był usunięty!");
                liczbaSamochodow--;
            }
            return this;
        }

        public void WypiszInfo()
        {
            if (liczbaSamochodow == 0)
                Console.WriteLine("Garaż jest pusty, nic do wyswietłenia!");
            else
            {
                for (int i = 0; i < liczbaSamochodow; i++)
                {
                    Console.WriteLine("Informacja pro samochód " + (i+1) + "\n");

                    Console.WriteLine("Marka: " + samochody[i].Marka);
                    Console.WriteLine("Model: " + samochody[i].Model);
                    Console.WriteLine("Ilość drzwi: " + samochody[i].IloscDrzwi);
                    Console.WriteLine("Pojemność silnika: " + samochody[i].PojemnoscSilnika);
                    Console.WriteLine("Średnie spalanie: " + samochody[i].SrednieSpalanie + "\n");
                }
            }
        }
    }

    class Zadanie2
    {
        static void Main(string[] args)
        {
            Samochod s1 = new Samochod("Fiat", "126p", 2, 650, 6.0);
            Samochod s2 = new Samochod("Syrena", "105", 2, 8000, 7.6);

            Garaz g1 = new Garaz();
            g1.Adres = "ul. Garażowa 1";
            g1.Pojemnosc = 1;

            Garaz g2 = new Garaz("ul. Garażowa 2", 2);

            g1.WprowadzSamochod(s1);
            g1.WypiszInfo();
            g1.WprowadzSamochod(s2);

            g2.WprowadzSamochod(s2);
            g2.WprowadzSamochod(s1);
            g2.WypiszInfo();

            g2.WyprowadzSamochod();
            g2.WypiszInfo();

            g2.WyprowadzSamochod();
            g2.WyprowadzSamochod();

            Console.ReadKey();
        }
    }
}
