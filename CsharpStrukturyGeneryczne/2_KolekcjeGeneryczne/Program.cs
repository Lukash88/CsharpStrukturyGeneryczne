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

            //Kolejka();
            //Stos();

            StosInt();
            StosPracownik();

        }

        private static void StosPracownik()
        {
            HashSet<Pracownik> pracownicy = new HashSet<Pracownik>();
            pracownicy.Add(new Pracownik { Imie = "Adam", Nazwisko = "Klyszcz" });
            pracownicy.Add(new Pracownik { Imie = "Gocha", Nazwisko = "Kopocha" });
            pracownicy.Add(new Pracownik { Imie = "Adam", Nazwisko = "Klyszcz" });
            pracownicy.Add(new Pracownik { Imie = "Gocha", Nazwisko = "Kopocha" });

            var pracownik = new Pracownik { Imie = "Adam", Nazwisko = "Klyszcz" };

            pracownicy.Add(pracownik);
            pracownicy.Add(pracownik);

            Console.WriteLine("\nHashSet <Pracownik>:");
            foreach (var item in pracownicy)
            {
                Console.WriteLine(item.Imie + " " + item.Nazwisko);
            }
        }

        private static void StosInt()
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);
            set.Add(5);
            set.Add(6);
            set.Add(7);
            set.Add(8);
            set.Add(9);
            var test = set.Add(10);
            test = set.Add(10);

            Console.WriteLine("\nHashSet:");

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }

        private static void Stos()
        {            
            Stack<Pracownik> stos = new Stack<Pracownik>();
            stos.Push(new Pracownik { Imie = "Lukas", Nazwisko = "Kakowicz" });
            stos.Push(new Pracownik { Imie = "Adam", Nazwisko = "Klyszcz" });
            stos.Push(new Pracownik { Imie = "Kris", Nazwisko = "Krisu" });
            stos.Push(new Pracownik { Imie = "Sonya", Nazwisko = "Dumpling" });

            Console.WriteLine("\nStos / LIFO - Last In Last Out:");

            while (stos.Count > 0)
            {
                var pracownik = stos.Pop();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }

        private static void Kolejka()
        {
            
            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Lukas", Nazwisko = "Kakowicz" });
            kolejka.Enqueue(new Pracownik { Imie = "Adam", Nazwisko = "Klyszcz" });
            kolejka.Enqueue(new Pracownik { Imie = "Kris", Nazwisko = "Krisu" });
            kolejka.Enqueue(new Pracownik { Imie = "Sonya", Nazwisko = "Dumpling" });

            Console.WriteLine("Kolejka / FIFO - First In First Out:");

            while (kolejka.Count > 0)
            {
                var pracownik = kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }
    }
}
 