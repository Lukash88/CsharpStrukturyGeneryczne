using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HashSetTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IntersectWithSetsTest()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.IntersectWith(set2);

            //Assert.AreEqual(set1, new[] { 2, 2 }); //moja nieudana proba testu

            Assert.IsTrue(set1.SetEquals(new[] { 2, 3 }));
        }

        [TestMethod]
        public void UniontWithSetsTest()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.UnionWith(set2);

            Assert.IsTrue(set1.SetEquals(new[] { 1, 2, 3, 4 }));
        }

        [TestMethod]
        public void SymmetricExceptWithSetsTest()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.SymmetricExceptWith(set2);

            Assert.IsTrue(set1.SetEquals(new[] { 1, 4 }));
        }

        [TestMethod]
        public void RemoveTest()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.Remove(1);

            Assert.AreEqual(2, set1.Count);
        }

        [TestMethod]
        public void RemoveWhereTest()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.RemoveWhere(x => x > 1);

            Assert.AreEqual(1, set1.Count);
        }

        [TestMethod]
        public void ContainsTest()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };

            Assert.IsTrue(set1.Contains(3));
        }
    }
}
