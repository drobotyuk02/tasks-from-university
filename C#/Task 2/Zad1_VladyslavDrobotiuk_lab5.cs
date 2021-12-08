using System;

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
            Console.WriteLine("\nImie: " + imie);
            Console.WriteLine("Nazwisko: " + nazwisko);
            Console.WriteLine("Data urodzenia: " + dataUrodzenia);
        }
    }


    class Student : Osoba
    {
        private int rok;
        private int grupa;
        private int nrIndeksu;

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

        public void StrzelGola()
        {
            liczbaGoli++;
            Console.WriteLine("\nGooool! " + imie + " strzelił swojego " + liczbaGoli + " gola!");
        }
    }


    class Zadanie1
    {
        static void Main(string[] args)
        {
            Osoba o = new Osoba("Adam", "Miś", "20.03.1980");
            Osoba o2 = new Student("Michał", "Kot", "13.04.1990", 2, 1, 12345);
            Osoba o3 = new Pilkarz("Mateusz", "Żbik", "10.08.1986", "obońca", "FC Czestochowa");

            o.WypiszInfo();
            o2.WypiszInfo();
            o3.WypiszInfo();

            Student s = new Student("Krzystof", "Jeż", "22.12.1990", 3, 5, 54321);
            Pilkarz p = new Pilkarz("Piotr", "Kos", "10.09.1984", "napastnik", "FC Politechnika");

            s.WypiszInfo();
            p.WypiszInfo();

            ((Pilkarz)o3).StrzelGola();
            p.StrzelGola();
            p.StrzelGola();

            o3.WypiszInfo();
            p.WypiszInfo();

            Console.ReadKey();

        }
    }
}
