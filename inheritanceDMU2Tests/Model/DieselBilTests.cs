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
    public class DieselBilTests
    {
        [TestMethod()]
        public void HalvÅrligEjeafgiftTest()
        {

            // arrange
            DieselBil obj1 = new DieselBil("testobj", 2015, 18, 80500, 50);
            DieselBil obj2 = new DieselBil("testobj", 2015, 10, 80500, 50);
            DieselBil obj3 = new DieselBil("testobj", 2015, 18, 80500, 50, false);
            DieselBil obj4 = new DieselBil("testobj", 2015, 10, 80500, 50, false);


            // act
            double afgifttest1 = obj1.HalvÅrligEjeafgift();
            double afgifttest2 = obj2.HalvÅrligEjeafgift();
            double afgifttest3 = obj3.HalvÅrligEjeafgift();
            double afgifttest4 = obj4.HalvÅrligEjeafgift();


            // assert

            Assert.AreEqual(2500, afgifttest4);
            Assert.AreEqual(1000, afgifttest1);
            Assert.AreEqual(2000, afgifttest2);
            Assert.AreEqual(1500, afgifttest3);




        }
    }
}