
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlockingBackend;
using System.Collections.Generic;
namespace FlockingUnitTests
{
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

          // Test events when they change values
        [TestMethod]
        public void TestRaiseEvent()
        {

            Flock flock = new Flock();

            // Arrange
            List<Sparrow> sparrows = new List<Sparrow>();

            Sparrow s1 = new Sparrow( 6, 6, -3,4 );
            flock.Subscribe(s1.CalculateBehaviour,s1.Move,s1.CalculateRavenAvoidance);
            Sparrow s2 = new Sparrow( 2, 4, -2,1 );
            flock.Subscribe(s1.CalculateBehaviour,s1.Move,s1.CalculateRavenAvoidance);
            Sparrow s3 = new Sparrow( 1, 3, -1,1 );
            flock.Subscribe(s1.CalculateBehaviour,s1.Move,s1.CalculateRavenAvoidance);

            sparrows.Add(s1);
            sparrows.Add(s2);
            sparrows.Add(s3);
            
            // float expX = -0.083f;
            // float expY = -0.996f;
            //   float expX = -0.181f;
            //     float expY = -0.983f;
            //     float expX = -0.083f;
            //     float expY = -0.996f;
            Raven raven = new Raven();

            flock.RaiseMoveEvents(sparrows,raven);

        }


    }
}

