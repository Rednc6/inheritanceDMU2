using Microsoft.VisualStudio.TestTools.UnitTesting;
using inheritanceDMU2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inheritanceDMU2.Commen;

namespace inheritanceDMU2.Model.Tests
{
    [TestClass()]
    public class BenzinBilTests
    {

        [ExpectedException(typeof(HalvÅrligEjerAfgiftException))]
        [TestMethod()]
        public void HalvÅrligEjeafgiftTest()
        {

            
            // Arrange
            BenzinBil obj = new BenzinBil("testobj", 2015, 1, 80500, 50);

            // act
            double testkmprl = obj.HalvÅrligEjeafgift();

            // assert

        }
    }
}