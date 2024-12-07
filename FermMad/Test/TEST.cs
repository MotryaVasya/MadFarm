using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermMad.Test
{
    [TestClass]
    internal class TEST
    {
        [TestMethod]
        public void TestCreateFerm()
        {   
            var ferm = new ChickenFerm(12, new List<Chicken>());
            Assert.AreEqual(ferm.Animals, null);
        }

        [TestMethod]
        public void TestCreateAnimal()
        {

        }
    }
}
