using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlockingBackend;
using System;
using System.Collections.Generic;

namespace FlockingUnitTests
{

     ///<summary>
    /// This class test the boids rules of the raven class.
    ///</summary>
    [TestClass]
    public class RavenUnitTest
    {
        [TestMethod]
        public void ChaseSparrow_ReturnsVectorDistanceToNearestSparrow()
        {
            Raven raven = new Raven(50, 25, 2, 1);
            List<Sparrow> list = GenerateSparrows();
            list.Add(new Sparrow(50, 73, -1, 2));
            Vector2 result = raven.ChaseSparrow(list);

            Vector2 expected = new Vector2(0, 48);

            Assert.AreEqual(expected.Vx, result.Vx, $"The new vector's x ({result.Vx}) does not equal to {expected.Vx}");
            Assert.AreEqual(expected.Vy, result.Vy, $"The new vector's x ({result.Vy}) does not equal to {expected.Vy}");
        }

        [TestMethod]
        public void ChaseSparrow_ReturnsZeroVector()
        {
            Raven raven = new Raven(50, 25, 2, 1);
            List<Sparrow> list = GenerateSparrows();
            Vector2 result = raven.ChaseSparrow(list);

            Vector2 expected = new Vector2(0, 0);

            Assert.AreEqual(expected.Vx, result.Vx, $"The new vector's x ({result.Vx}) does not equal to 0");
            Assert.AreEqual(expected.Vy, result.Vy, $"The new vector's x ({result.Vy}) does not equal to 0");
        }
        private List<Sparrow> GenerateSparrows()
        {
            List<Sparrow> list = new List<Sparrow>();
            list.Add(new Sparrow(10, 68, 0, -3));
            list.Add(new Sparrow(3, 59, 3, 1));
            return list;
        }
    }
}