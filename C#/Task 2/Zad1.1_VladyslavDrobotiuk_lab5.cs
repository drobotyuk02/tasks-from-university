using System;
using System.Collections.Generic;

namespace Laboratorium2
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected string dataUrodzenia;

        public Osoba(string imie_, string nazwisko_, string dataUrodzenia_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
            dataUrodzenia = dataUrodzenia_;
        }


        public virtual void WypiszInfo()
        {
            Console.WriteLine($"\nImie: {imie}");
            Console.WriteLine("Nazwisko: " + nazwisko);
            Console.WriteLine("Data urodzenia: " + dataUrodzenia);
        }
    }


    class Student : Osoba
    {
        private int rok;
        private int grupa;
        private int nrIndeksu;

        private List<Ocena> oceny = new List<Ocena>();

        public Student(string imie_, string nazwisko_, string dataUrodzenia_, int rok_, int grupa_, int nrIndeksu_) :
            base(imie_, nazwisko_, dataUrodzenia_)
        {
            rok = rok_;
            grupa = grupa_;
            nrIndeksu = nrIndeksu_;
        }


        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Rok: " + rok);
            Console.WriteLine("Grupa: " + grupa);
            Console.WriteLine("Numer indeksu: " + nrIndeksu);

            if(oceny.Count == 0) { Console.WriteLine($"\nStudent {imie} {nazwisko} nie posiada ocen!"); }

            for(int i = 0; i < oceny.Count; i++)
            {
                oceny[i].WypiszInfo();
            }
        }

        public void DodajOcene(string nazwaPrzedmiotu, string data, double wartosc)
        {
            oceny.Add(new Ocena(nazwaPrzedmiotu, data, wartosc));
            Console.WriteLine($"\nStudent {imie} {nazwisko}, dodano ocene {nazwaPrzedmiotu} datowana {data} o wartosci {wartosc}");
        }

        public void WypiszOceny()
        {
            if (oceny.Count == 0)
            {
                Console.WriteLine($"\nStudent {imie} {nazwisko} nie posiada ocen!");
                return;
            }
            else
            {
                foreach (Ocena element in oceny)
                {
                    element.WypiszInfo();
                }
            }
        }

        public void WypiszOceny(string nazwaPrzedmiotu)
        {
            foreach (Ocena element in oceny)
            {
                if (element.NazwaPrzedmiotu == nazwaPrzedmiotu)
                {
                    element.WypiszInfo();
                }
            }
        }

        public void UsunOceny()
        {
            oceny.Clear();
            Console.WriteLine($"\nStudent {imie} {nazwisko}, usunięto wszystkie oceny!");
        }

        public void UsunOceny(string nazwaPrzedmiotu)
        {
            oceny.RemoveAll(oceny => oceny.NazwaPrzedmiotu == nazwaPrzedmiotu);
            Console.WriteLine($"\nStudent {imie} {nazwisko}, usunieto oceny o nazwie {nazwaPrzedmiotu}");
        }

        public void UsunOcene(string nazwaPrzedmiotu, string data, double wartosc)
        {
            for(int i = 0; i < oceny.Count;)
            {
                Ocena o = oceny[i];
                if(o.NazwaPrzedmiotu == nazwaPrzedmiotu && o.Data == data && o.Wartosc == wartosc)
                {
                    oceny.RemoveAt(i);
                    Console.WriteLine($"\nStudent {imie} {nazwisko}, usunięto ocenę {nazwaPrzedmiotu} datowaną {data} o wartości {wartosc}");
                }
                else
                {
                    ++i;
                }
            }
        }


    }


    class Pilkarz : Osoba
    {
        private string pozycja;
        private string klub;
        private int liczbaGoli = 0;

        public Pilkarz(string imie_, string nazwisko_, string dataUrodzenia_, string pozycja_, string klub_) :
            base(imie_, nazwisko_, dataUrodzenia_)
        {
            pozycja = pozycja_;
            klub = klub_;
        }


        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Pozycja: " + pozycja);
            Console.WriteLine("Klub: " + klub);
            Console.WriteLine("Liczba goli: " + liczbaGoli);
        }

        public virtual void StrzelGola()
        {
            liczbaGoli++;
            Console.WriteLine("\nGooool! " + imie + " strzelił swojego " + liczbaGoli + " gola!");
        }
    }


    class Zadanie1
    {
        //static void Main(string[] args)
        //{
        //    //Osoba o = new Osoba("Adam", "Miś", "20.03.1980");
        //    Osoba o2 = new Student("Michał", "Kot", "13.04.1990", 2, 1, 12345);
        //    //Osoba o3 = new Pilkarz("Mateusz", "Żbik", "10.08.1986", "obońca", "FC Czestochowa");

        //    //o.WypiszInfo();
        //    o2.WypiszInfo();
        //    //o3.WypiszInfo();

        //    Student s = new Student("Krzystof", "Jeż", "22.12.1990", 3, 5, 54321);
        //    //Pilkarz p = new Pilkarz("Piotr", "Kos", "10.09.1984", "napastnik", "FC Politechnika");

        //    s.WypiszInfo();
        //    //p.WypiszInfo();

        //    ((Student)o2).DodajOcene("PO", "20.02.2011", 5.0);
        //    ((Student)o2).DodajOcene("Bazy danych", "13.02.2011", 4.0);

        //    o2.WypiszInfo();

        //    s.DodajOcene("Bazy danych", "01.05.2011", 5.0);
        //    s.DodajOcene("AWW", "11.05.2011", 5.0);
        //    s.DodajOcene("AWW", "02.04.2011", 4.5);

        //    s.WypiszInfo();

        //    s.UsunOcene("AWW", "02.04.2011", 4.5);

        //    s.WypiszInfo();

        //    s.DodajOcene("AWW", "02.04.2011", 4.5);
        //    s.UsunOceny("AWW");

        //    s.WypiszInfo();

        //    s.DodajOcene("AWW", "02.04.2011", 4.5);
        //    s.UsunOceny();

        //    s.WypiszInfo();

        //    Console.ReadKey();

        //}
    }
}
