using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorium2
{
    class PilkarzReczny : Pilkarz
    {
        public PilkarzReczny(string imie_, string nazwisko_, string dataUrodzenia_, string pozycja_, string klub_) :
            base(imie_, nazwisko_, dataUrodzenia_, pozycja_, klub_)
        {
        }

        public override void StrzelGola()
        {
            base.StrzelGola();
            Console.WriteLine("Reczny strzelil!\n");
        }
    }


    class PilkarzNozny : Pilkarz
    {
        public PilkarzNozny(string imie_, string nazwisko_, string dataUrodzenia_, string pozycja_, string klub_) :
            base(imie_, nazwisko_, dataUrodzenia_, pozycja_, klub_)
        {
        }

        public override void StrzelGola()
        {
            base.StrzelGola();
            Console.WriteLine("Nozny strzelil!\n");
        }
    }

    class Zadanie3
    {
        static void Main(string[] args)
        {
            PilkarzReczny p1 = new PilkarzReczny("Piotr", "Kos", "10.09.1984", "napastnik", "FC Politechnika");
            PilkarzNozny p2 = new PilkarzNozny("Mateusz", "Żbik", "10.08.1986", "obrońca", "FC Czestochowa");

            p1.StrzelGola();
            p1.StrzelGola();

            p2.StrzelGola();

            p1.WypiszInfo();
            p2.WypiszInfo();

            Console.ReadKey();
        }
    }
}
