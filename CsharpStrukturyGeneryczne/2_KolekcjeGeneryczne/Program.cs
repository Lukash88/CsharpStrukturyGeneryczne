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
            //StosInt();
            //StosPracownik();
            //HashSet();
            // LinkedList();
            //LinkedList2();

            //var pracownicy = new Dictionary<string, Pracownik>();

            //pracownicy.Add("Nowak", new Pracownik { Nazwisko = "Nowak" });
            //pracownicy.Add("Bochenek", new Pracownik { Nazwisko = "Bochenek" });
            //pracownicy.Add("Kowalski", new Pracownik { Nazwisko = "Kowalski" });

            //var kowal = pracownicy["Nowak"];

            //foreach (var pracownik in pracownicy)
            //{
            //    Console.WriteLine("{0}:{1}",pracownik.Key, pracownik.Value.Nazwisko);
            //}

            var pracownicy = new Dictionary<string, List<Pracownik>>();
            pracownicy.Add("Ksiegowosc", new List<Pracownik>() { new Pracownik { Nazwisko = "Nowak" },
                                                                 new Pracownik { Nazwisko = "Kowal" },
                                                                 new Pracownik { Nazwisko = "Ziomalski"} });

            //...

            pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Nowak" });

            pracownicy.Add("Informatyka", new List<Pracownik> { new Pracownik { Nazwisko = "Sokalski" },
                                                                new Pracownik { Nazwisko = "Zaremba" },
                                                                new Pracownik { Nazwisko = "Zaskalski" } });
            
            foreach (var item in pracownicy)
            {
                Console.WriteLine("Dzial : "+ item.Key);

                foreach (var pracownik in item.Value)
                {
                    Console.WriteLine(pracownik.Nazwisko);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Pracownicy z dzialu ksiegowosci:");

            foreach (var item in pracownicy["Ksiegowosc"])
            {
                Console.WriteLine(item.Nazwisko);
            }

        }

        private static void LinkedList2()
        {
            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(5);
            lista.AddFirst(6);
            lista.AddFirst(7);

            var elementPierwszy = lista.First;
            var elementOstatni = lista.Last;


            lista.AddAfter(elementPierwszy, 10);
            lista.AddBefore(elementPierwszy, 20);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n");

            var wezel = lista.First;

            while (wezel != null)
            {
                Console.WriteLine(wezel.Value);
                wezel = wezel.Next;
            }
        }

        private static void LinkedList()
        {
            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(5);
            lista.AddFirst(6);
            lista.AddFirst(7);
            lista.AddLast(1);
            lista.AddLast(2);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        private static void HashSet()
        {
            HashSet<Pracownik> set = new HashSet<Pracownik>();

            var pracownik = new Pracownik { Imie = "Jurek" };

            set.Add(pracownik);
            set.Add(pracownik);

            foreach (var item in set)
            {
                Console.WriteLine(item.Imie);
            }
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
 