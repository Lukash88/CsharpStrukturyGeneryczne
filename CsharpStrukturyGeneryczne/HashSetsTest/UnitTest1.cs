using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace LinkedListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DodawaniePoElemencie()
        {
            var lista = new LinkedList<string>();

            lista.AddFirst("Luca");
            lista.AddLast("Tom");
            lista.AddAfter(lista.First, "Ola");

            Assert.AreEqual("Ola", lista.First.Next.Value);
        }

        [TestMethod]
        public void DodawaniePrzedElementem()
        {
            var lista = new LinkedList<string>();

            lista.AddFirst("Lucjan");
            lista.AddLast("Romek");
            lista.AddBefore(lista.Last, "Betty");

            Assert.AreEqual("Betty", lista.Last.Previous.Value);
        }

        [TestMethod]
        public void UsuwanieElementuOstatniego()
        {
            var lista = new LinkedList<string>();

            lista.AddFirst("Lucjan");
            lista.AddLast("Romek");
            lista.RemoveLast();

            Assert.AreEqual(lista.First, lista.Last);
        }

        [TestMethod]
        public void UsuwanieElementu()
        {
            var lista = new LinkedList<string>();

            lista.AddFirst("Lucjan");
            lista.AddLast("Romek");
            lista.Remove("Romek");

            Assert.AreEqual("Lucjan", lista.Last.Value);
        }

        [TestMethod]
        public void CzyListaZawieraElement()
        {
            var lista = new LinkedList<string>();

            lista.AddFirst("Lucjan");
            lista.AddLast("Romek");

            Assert.IsTrue(lista.Contains("Lucjan"));
        }

        [TestMethod]
        public void CzyszczenieListy()
        {
            var lista = new LinkedList<string>();

            lista.AddFirst("Lucjan");
            lista.AddLast("Romek");
            lista.Clear();

            Assert.AreEqual(0, lista.Count);
        }
    }
}
