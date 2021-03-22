using System;
using System.Collections.Generic;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Pracownik> pracownicy = new List<Pracownik>
            //{
            //    new Pracownik { Imie = "Janusz", Nazwisko = "Cebula"},
            //    new Pracownik { Imie = "Jonasz", Nazwisko = "Swiety"},
            //    new Pracownik { Imie = "Zolza", Nazwisko = "Bela"},
            //};

            //pracownicy.Add(new Pracownik { Imie = "Jula", Nazwisko = "Ciewyciula" });

            //foreach (var pracownik in pracownicy)
            //{
            //    Console.WriteLine(pracownik.Imie + " " + pracownik);
            //}

            //for (int i = 0; i < pracownicy.Count; i++)
            //{
            //    Console.WriteLine(pracownicy[i].Imie + " " + pracownicy[i].Nazwisko);
            //}

            //var liczby = new List<int>(10);
            //var pojemnosc = -1;

            //var stringi = new List<string>();
            //var pojemnoscString = -1;

            //while (true)
            //{
            //    if (liczby.Capacity != pojemnosc)
            //    {
            //        pojemnosc = liczby.Capacity;
            //        Console.WriteLine(pojemnosc);
            //    }
            //    liczby.Add(1);
            //}

            //while (true)
            //{
            //    if (stringi.Capacity != pojemnoscString)
            //    {
            //        pojemnoscString = stringi.Capacity;
            //        Console.WriteLine(pojemnoscString);
            //    }
            //    stringi.Add("Aa");
            //}
            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Lukas", Nazwisko = "Kakowicz" });
            kolejka.Enqueue(new Pracownik { Imie = "Adam", Nazwisko = "Klyszcz" });
            kolejka.Enqueue(new Pracownik { Imie = "Kris", Nazwisko = "Krisu" });
            kolejka.Enqueue(new Pracownik { Imie = "Sonya", Nazwisko = "Dumpling" });

            while(kolejka.Count > 0)
            {
                var pracownik = kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }
    }
}
 