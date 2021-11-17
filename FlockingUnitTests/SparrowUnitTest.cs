using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlockingBackend;
using System.Collections.Generic;
using System;
namespace FlockingUnitTests
{
    ///<summary>
    /// This class test the boids rules of the sparrow class.
    ///</summary>
    [TestClass]
    public class SparrowUnitTest
    {
        // Test if alignment returns a zero vector ( NO NEIGHBOURS)
        [TestMethod]
        public void TestAlignmentZeroVector()
        {
            // Arrange
            List<Sparrow> sparrows = new List<Sparrow>();

            Sparrow s1 = new Sparrow( 6, 6, -3,4 );
            Sparrow s2 = new Sparrow( 105,108 , -2,1 );
            Sparrow s3 = new Sparrow( 108, 106, -1,1 );

            sparrows.Add(s1);
            sparrows.Add(s2);
            sparrows.Add(s3);
            
            float expX = 0.0f;
            float expY = 0.0f;

            //Act
            Vector2 result = s1.Alignment(sparrows);

            //Assert
            Assert.AreEqual(expX, result.Vx, 0.01);
            Assert.AreEqual(expY, result.Vy, 0.01);
        }
        // Test if alignment returns valid alignment vector with nearest neighbours   
        [TestMethod]
        public void TestAlignmentSmallDistance()
        {
            // Arrange
            List<Sparrow> sparrows = new List<Sparrow>();

            Sparrow s1 = new Sparrow( 6, 6, -3,4 );
            Sparrow s2 = new Sparrow( 2, 4, -2,1 );
            Sparrow s3 = new Sparrow( 1, 3, -1,1 );

            sparrows.Add(s1);
            sparrows.Add(s2);
            sparrows.Add(s3);
            
            float expX = -0.181f;
            float expY = -0.983f;
            

            //Act
            Vector2 result = s1.Alignment(sparrows);

            //Assert
            Assert.AreEqual(expX, result.Vx, 0.01);
            Assert.AreEqual(expY, result.Vy, 0.01);
        }

        // Test if alignment returns valid alignment vector with farthest neighbours    
        [TestMethod]
        public void TestAlignmentLargeDistance()
        {
            // Arrange
            List<Sparrow> sparrows = new List<Sparrow>();

            Sparrow s1 = new Sparrow(  400,200, -3,4 );
            Sparrow s2 = new Sparrow(  400,101, -2,1 );
            Sparrow s3 = new Sparrow(  499,200, -1,1 );
            Sparrow s4 = new Sparrow(  400,299, -1,3 );
            Sparrow s5 = new Sparrow(  400,101,  1,4 );
            Sparrow s6 = new Sparrow(  400,299,  -4,4 );
            Sparrow s7 = new Sparrow(  308,200, 0,3 );
            Sparrow s8 = new Sparrow(  315,200,  -3,3 );
            Sparrow s9 = new Sparrow(  302, 200, 1,2 );

            sparrows.Add(s1);
            sparrows.Add(s2);
            sparrows.Add(s3);
            sparrows.Add(s4);
            sparrows.Add(s5);
            sparrows.Add(s6);
            sparrows.Add(s7);
            sparrows.Add(s8);
            sparrows.Add(s9);

            float expX = 0.975f;
            float expY = -0.221f;

            // //Act
            
            Vector2 result = s1.Alignment(sparrows);
            // //Assert
            Assert.AreEqual(expX, result.Vx, 0.01);
            Assert.AreEqual(expY, result.Vy, 0.01);
        }
        // Test if cohesion returns a zero vector ( NO NEIGHBOURS)
        [TestMethod]
        public void TestCohesionZeroVector()
        {
            // Arrange
            List<Sparrow> sparrows = new List<Sparrow>();

            Sparrow s1 = new Sparrow( 6, 6, -3,4 );
            Sparrow s2 = new Sparrow( 105,108 , -2,1 );
            Sparrow s3 = new Sparrow( 108, 106, -1,1 );

            sparrows.Add(s1);
            sparrows.Add(s2);
            sparrows.Add(s3);
            
            float expX = 0.0f;
            float expY = 0.0f;

            //Act
            Vector2 result = s1.Cohesion(sparrows);

            //Assert
            Assert.AreEqual(expX, result.Vx, 0.01);
            Assert.AreEqual(expY, result.Vy, 0.01);
        }

        // Test if cohesion returns valid alignment vector with nearest neighbours   
        [TestMethod]
        public void TestCohesionSmallDistance()
        {
            // Arrange
            List<Sparrow> sparrows = new List<Sparrow>();

            Sparrow s1 = new Sparrow( 6, 6, -3,4 );
            Sparrow s2 = new Sparrow( 2, 4, -2,1 );
            Sparrow s3 = new Sparrow( 1, 3, -1,1 );

            sparrows.Add(s1);
            sparrows.Add(s2);
            sparrows.Add(s3);
            
            float expX = -0.083f;
            float expY = -0.996f;

            //Act
            Vector2 result = s1.Cohesion(sparrows);

            //Assert
            Assert.AreEqual(expX, result.Vx, 0.01);
            Assert.AreEqual(expY, result.Vy, 0.01);
        }
        // Test if cohesion returns valid alignment vector with farthest neighbours    
        [TestMethod]
        public void TestCohesionLargeDistance()
        {
            // Arrange
            List<Sparrow> sparrows = new List<Sparrow>();

            Sparrow s1 = new Sparrow( 400,200, -3,4);
            Sparrow s2 = new Sparrow( 400,101, -2,1);
            Sparrow s3 = new Sparrow( 499,200, -1,1);
            Sparrow s4 = new Sparrow( 400,299, -1,3);
            Sparrow s5 = new Sparrow( 400,101,  1,4);
            Sparrow s6 = new Sparrow( 400,299,  -4,4);
            Sparrow s7 = new Sparrow( 308,200, 0,3);
            Sparrow s8 = new Sparrow( 315,200,  -3,3);
            Sparrow s9 = new Sparrow( 302, 200, 1,2);

            sparrows.Add(s1);
            sparrows.Add(s2);
            sparrows.Add(s3);
            sparrows.Add(s4);
            sparrows.Add(s5);
            sparrows.Add(s6);
            sparrows.Add(s7);
            sparrows.Add(s8);
            sparrows.Add(s9);
        

            float expX = -0.242f;
            float expY = -0.970f;

            //Act
            Vector2 result = s1.Cohesion(sparrows);
            
            //Assert
            Assert.AreEqual(expX, result.Vx, 0.01);
            Assert.AreEqual(expY, result.Vy, 0.01);
            
        }

        // Test if avoidance returns a zero vector ( NO NEIGHBOURS)
        [TestMethod]
        public void TestAvoidanceZeroVector()
        {
            // Arrange
            List<Sparrow> sparrows = new List<Sparrow>();

            Sparrow s1 = new Sparrow( 6, 6, -3,4 );
            Sparrow s2 = new Sparrow( 69,108 , -2,1 );
            Sparrow s3 = new Sparrow( 90, 80, -1,1 );

            sparrows.Add(s1);
            sparrows.Add(s2);
            sparrows.Add(s3);
            
            float expX = 0.0f;
            float expY = 0.0f;

            //Act
            Vector2 result = s1.Avoidance(sparrows);

            //Assert
            Assert.AreEqual(expX, result.Vx, 0.01);
            Assert.AreEqual(expY, result.Vy, 0.01);
        }

        // Test if avoidance returns valid alignment vector with nearest neighbours   
        [TestMethod]
        public void TestAvoidanceSmallDistance()
        {
            // Arrange
            List<Sparrow> sparrows = new List<Sparrow>();

            Sparrow s1 = new Sparrow( 6, 6, -3,4 );
            Sparrow s2 = new Sparrow( 2, 4, -2,1 );
            Sparrow s3 = new Sparrow( 1, 3, -1,1 );

            sparrows.Add(s1);
            sparrows.Add(s2);
            sparrows.Add(s3);
            
            float expX = 0.954f;
            float expY = -0.299f;

            //Act
            Vector2 result = s1.Avoidance(sparrows);

            //Assert
            Assert.AreEqual(expX, result.Vx, 0.01);
            Assert.AreEqual(expY, result.Vy, 0.01);
        }

        // Test flee raven result vector   
        [TestMethod]
        public void TestFleeRaven()
        {
            // Arrange
            Raven raven = new Raven(4,4,-3,4);

            Sparrow s1 = new Sparrow( 6, 6, -3,4 );
        

            //Act
            Vector2 result = s1.FleeRaven(raven);

            float expX = 2.832f;
            float expY = 2.832f;

            //Assert
            Assert.AreEqual(expX, result.Vx, 0.01);
            Assert.AreEqual(expY, result.Vy, 0.01);
        }

        // Test flee raven result zero vector  
        [TestMethod]
        public void TestFleeRavenZero()
        {
            // Arrange
            Raven raven = new Raven(4,4,-3,4);

            Sparrow s1 = new Sparrow( 100, 100, -3,4 );
        

            //Act
            Vector2 result = s1.FleeRaven(raven);

            float expX = 0.0f;
            float expY = 0.0f;

            //Assert
            Assert.AreEqual(expX, result.Vx, 0.01);
            Assert.AreEqual(expY, result.Vy, 0.01);
        }

        // Test flee raven result distance zero 
        [TestMethod]
        public void TestFleeDistanceZero()
        {
            // Arrange
            Raven raven = new Raven(4,4,-3,4);

            Sparrow s1 = new Sparrow(4,4, -3,4 );
        

            //Act
            Vector2 result = s1.FleeRaven(raven);

            // Normalized points
            float expX = -0.600f;
            float expY = 0.800f;

            //Assert
            Assert.AreEqual(expX, result.Vx, 0.01);
            Assert.AreEqual(expY, result.Vy, 0.01);
        }

    }
    
}
