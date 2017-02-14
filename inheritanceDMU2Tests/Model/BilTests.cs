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
    public class BilTests
    {
        [TestMethod()]
        public void RegistreringAfgiftTest()
        {
            // arrange
            DieselBil obj1 = new DieselBil("testobj", 2015, 50, 80500, 10);
            DieselBil obj2 = new DieselBil("testobj", 2015, 50, 80499, 10);


            // act
            double RegAfgift = obj1.RegistreringAfgift();
            double RegAfgift2 = obj2.RegistreringAfgift();


            // assert
            Assert.AreEqual(84525, RegAfgift);
            Assert.AreEqual(84523.95, RegAfgift2);

        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void RegistreringAfgiftTestwithException()
        {
            // arrange
            DieselBil obj1 = new DieselBil("testobj", 2015, 50, -50, 10);


            // act
            double RegAfgift = obj1.RegistreringAfgift();

            // assert

        }
    }
}