using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlockingBackend;
using System;

namespace FlockingUnitTests
{

     ///<summary>
    /// This class test Vector2 arithmetic methods.
    ///</summary>
    [TestClass]
    public class Vector2UnitTest
    {
        [TestMethod]
        public void Addition_ReturnsBothVectorsAdded()
        {
            // Arrange
            float ux = 2f;
            float uy = -8f;
            Vector2 u = new Vector2(ux, uy);
            float vx = -1f;
            float vy = 4f;
            Vector2 v = new Vector2(vx, vy);

            //Act
            Vector2 w = u + v;

            //Assert
            Assert.AreEqual(ux + vx, w.Vx, $"The new vector's x={w.Vx} is not equal to {ux + vx}");
            Assert.AreEqual(uy + vy, w.Vy, $"The new vector's y={w.Vy} is not equal to {uy + vy}");
        }
        [TestMethod]
        public void Addition()
        {
            // Arrange
            float ux = 2;
            float uy = 2;
            Vector2 u = new Vector2(ux, uy);

            //Act
            Vector2 w = u / 2;

            //Assert
            Assert.AreEqual(1,w.Vx);
            Assert.AreEqual(1,w.Vy);
        }

        [TestMethod]
        public void Subtraction_ReturnsBothVectorsSubtracted()
        {
            // Arrange
            float ux = 2f;
            float uy = -8f;
            Vector2 u = new Vector2(ux, uy);

            float vx = -1f;
            float vy = 4f;
            Vector2 v = new Vector2(vx, vy);

            //Act
            Vector2 w = u - v;

            //Assert
            Assert.AreEqual(ux - vx, w.Vx, $"The new vector's x={w.Vx} is not equal to {ux - vx}");
            Assert.AreEqual(uy - vy, w.Vy, $"The new vector's y={w.Vy} is not equal to {uy - vy}");
        }

        [TestMethod]
        public void Divide_ReturnsVectorDividedByFloat()
        {
            // Arrange
            float ux = 2f;
            float uy = -8f;
            Vector2 u = new Vector2(ux, uy);

            float f = 2f;

            //Act
            Vector2 w = u / f;

            float expectedx = ux / f;
            float expectedy = uy / f;

            //Assert
            Assert.AreEqual(expectedx, w.Vx, $"The new vector's x={w.Vx} is not equal to {expectedx}");
            Assert.AreEqual(expectedy, w.Vy, $"The new vector's y={w.Vy} is not equal to {expectedy}");
        }

        [TestMethod]
        public void Multiply_ReturnsVectorMultipliedByFloat()
        {
            // Arrange
            float ux = 2f;
            float uy = -8f;
            Vector2 u = new Vector2(ux, uy);

            float f = 2f;

            //Act
            Vector2 w = u * f;

            float expectedx = ux * f;
            float expectedy = uy * f;

            //Assert
            Assert.AreEqual(expectedx, w.Vx, $"The new vector's x={w.Vx} is not equal to {expectedx}");
            Assert.AreEqual(expectedy, w.Vy, $"The new vector's y={w.Vy} is not equal to {expectedy}");
        }

        [TestMethod]
        public void DistanceSquared_ReturnsTheDistanceSquaredOfTwoVectors()
        {
            // Arrange
            float ux = 2f;
            float uy = -8f;
            Vector2 u = new Vector2(ux, uy);

            float vx = -1f;
            float vy = 4f;
            Vector2 v = new Vector2(vx, vy);

            //Act
            float f = Vector2.DistanceSquared(u, v);

            float expected = (float)(Math.Pow(u.Vx - v.Vx, 2) + Math.Pow(u.Vy - v.Vy, 2));

            //Assert
            Assert.AreEqual(expected, f, $"The distance squared of both vector's is {f} and it is not equal to {expected}");
        }

        [TestMethod]
        public void Normalize_ReturnsANormalizedVector()
        {
            // Arrange
            float ux = 2f;
            float uy = -8f;
            Vector2 u = new Vector2(ux, uy);

            //Act
            Vector2 w = Vector2.Normalize(u);

            float magnitude = (float) Math.Sqrt(Math.Pow(u.Vx, 2) + Math.Pow(u.Vy, 2));
            Vector2 expected = new Vector2(u.Vx / magnitude, u.Vy / magnitude);

            //Assert
            Assert.AreEqual(expected.Vx, w.Vx, $"The new vector's x={w.Vx} is not equal to {expected.Vx}");
            Assert.AreEqual(expected.Vy, w.Vy, $"The new vector's y={w.Vy} is not equal to {expected.Vy}");
        }
    }
}