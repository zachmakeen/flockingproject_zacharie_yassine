
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlockingBackend;
using System.Collections.Generic;
using System;
namespace FlockingUnitTests
{
    ///<summary>
    /// This class test if events are invoked.
    ///</summary>
    [TestClass]
    public class FlockSubscribeTest
    {

        // Test if event dont't throw exceptions when they are null
        [TestMethod]
        public void TestEventNull()
        {

            Flock flock = new Flock();

            List<Sparrow> sparrows = new List<Sparrow>();
            sparrows.Add(new Sparrow());
            Raven raven = new Raven();
            flock.RaiseMoveEvents(sparrows,raven);

        }

        // Test The invocation of events for one sparrow
        [TestMethod]
        public void TestRaiseEvent()
        {
            // Arrange
            Flock flock = new Flock();

            List<Sparrow> sparrows = new List<Sparrow>();

            Sparrow s1 = new Sparrow( 6, 6, -3,4 );
            flock.Subscribe(s1.CalculateBehaviour,s1.Move,s1.CalculateRavenAvoidance);
            Sparrow s2 = new Sparrow( 2, 4, -2,1 );
            flock.Subscribe(s2.CalculateBehaviour,s2.Move,s2.CalculateRavenAvoidance);
            Sparrow s3 = new Sparrow( 1, 3, -1,1 );
            flock.Subscribe(s3.CalculateBehaviour,s3.Move,s3.CalculateRavenAvoidance);

            sparrows.Add(s1);
            sparrows.Add(s2);
            sparrows.Add(s3);
       
            Raven raven = new Raven();

            float expX = -2.31f;
            float expY = 1.722f;
            
            // Act
            flock.RaiseMoveEvents(sparrows,raven);
            
            //Assert
            Assert.AreEqual(expX, s1.Velocity.Vx, 0.01);
            Assert.AreEqual(expY, s1.Velocity.Vy, 0.01);

        }


    }
}

