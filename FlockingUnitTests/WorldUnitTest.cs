using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlockingBackend;
using System.Collections.Generic;
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
            int initialCountResult = World.InitialiCounts;
            Assert.AreEqual(initialCountExpected, initialCountResult);

            // Test canvas Width
            int widthExpected = 1000;
            int widthResult = World.Width;
            Assert.AreEqual(widthExpected, widthResult);

            // Test canvas Height
            int heightExpected = 500;
            int heightResult = World.Height;
            Assert.AreEqual(heightExpected, heightResult);

            // Test Bird maxSpeed
            int speedExpected = 4;
            int speedResult = World.MaxSpeed;
            Assert.AreEqual(speedExpected, speedResult);

            // Test Radius neighbour
            int nRadiusExpected = 100;
            int nRadiusResult = World.NeighbourRadius;
            Assert.AreEqual(nRadiusExpected, nRadiusResult);

            // Test Radius avoidance
            int aRadiusExpected = 50;
            int aRadiusResult = World.AvoidanceRadius;
            Assert.AreEqual(aRadiusExpected, aRadiusResult);
           
        
        }
         [TestMethod]
        public void TestSparrowInitialization()
        {
          
           World w = new World();

           List<Sparrow> sparrows = w.Sparrows;

           List<Sparrow> neigh = sparrows[2].getAllNeighbours(sparrows);

           Console.WriteLine(neigh.Count);

           int result = sparrows.Count;

            Assert.AreEqual(150, result);
           
        
        }
    }
}