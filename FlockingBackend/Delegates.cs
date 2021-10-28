using System.Collections.Generic;
namespace FlockingBackend
{
    ///<summary>
    ///This class references delegates instances used to create events.
    ///</summary>
    public class Delegates
    {
        ///<summary>
        /// Delegate used to raise event to calculate movement
        /// for each Sparrow/Raven
        ///</summary>
        public delegate void CalculateMoveVector( List<Sparrow> sparrows);

        ///<summary>
        /// Delegate used to raise event to move Sparrow/Raven
        ///</summary>
        public delegate void MoveBird();

        ///<summary>
        /// Delegate used to raise event calculate the vector amount
        /// to steer the chasing raven.
        ///</summary>
        public delegate void CalculateRavenAvoidance(Raven raven);
    }
}    