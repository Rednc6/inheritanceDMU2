using Microsoft.VisualStudio.TestTools.UnitTesting;
using inheritanceDMU2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceDMU2.Model.Tests
{
    [TestClass()]
    public class ElBilTests
    {
        [TestMethod()]
        public void HalvÅrligEjeafgiftTest()
        {
            // arrange
            ElBil obj1 = new ElBil("testobj", 2015, 250000, 50, 10);

            // act
            double afgift = obj1.HalvÅrligEjeafgift();

            // assert
            Assert.AreEqual(0, afgift);
        }

        [TestMethod()]
        public void RækkeViddeTest()
        {
            // arrange
            ElBil obj2 = new ElBil("testobj", 2015, 80500, 50, 10);

            // act
            double rækkeviddde = obj2.RækkeVidde();

            // assert
            Assert.AreEqual(500, rækkeviddde);
        }
    }
}