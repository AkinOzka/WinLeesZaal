using LesZaalLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesZaalLibraryTests
{
    public class HatTest
    {
        [Test]
        [TestCase(0, "Pet")]
        [TestCase(1, "Bolhoed")]
        [TestCase(2, "Pruik")]
        [TestCase(3, "Niets")]
        public void Hat_Hats_Return(int index, string hat)
        {
            Assert.AreEqual(Hat.Hats(index), hat);
        }
    }
}
