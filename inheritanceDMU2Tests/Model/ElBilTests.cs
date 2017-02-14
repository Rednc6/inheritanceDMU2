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
    }
}