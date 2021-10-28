using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlockingBackend;
using System;

namespace FlockingUnitTests
{
    [TestClass]
    public class WorldUnitTest
    {
        [TestMethod]
        public void TestStaticFieldsOfWorld()
        {
          
            // Test Number Of Sparrows
            int initialCountExpected = 150;
            int initialCountResult = World.initialiCounts;
            Assert.AreEqual(initialCountExpected, initialCountResult);

            // Test canvas Width
            int widthExpected = 1000;
            int widthResult = World.width;
            Assert.AreEqual(widthExpected, widthResult);

            // Test canvas Height
            int heightExpected = 500;
            int heightResult = World.height;
            Assert.AreEqual(heightExpected, heightResult);

            // Test Bird maxSpeed
            int speedExpected = 4;
            int speedResult = World.maxSpeed;
            Assert.AreEqual(speedExpected, speedResult);

            // Test Radius neighbour
            int nRadiusExpected = 100;
            int nRadiusResult = World.neighbourRadius;
            Assert.AreEqual(nRadiusExpected, nRadiusResult);

            // Test Radius avoidance
            int aRadiusExpected = 50;
            int aRadiusResult = World.neighbourRadius;
            Assert.AreEqual(aRadiusExpected, aRadiusResult);
           
        
        }
    }
}