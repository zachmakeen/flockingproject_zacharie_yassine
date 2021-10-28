
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


    }
}

