using System;
using System.Collections.Generic;

namespace FlockingBackend
{
    ///<summary>
    ///This class is the subscriber class that each bird subscribes to. The class also raises the events to calculate movement vector and move the birds.
    ///This class is just a starting point. Complete the TODO sections
    ///</summary>
    public class Flock
    {

        ///<value> event <c>CalcMovementEvent</c> Event to calculate movement for each Sparrow/Raven</value>
        private event Delegates.CalculateMoveVector CalcMovementEvent;

        ///<value> event <c>MoveEvent</c> Event to move Sparrow/Raven</value>
        private event Delegates.MoveBird  MoveEvent;

        ///<value> event <c>calcRavenFleeEven</c> Event to calculate the vector amountToSteer to flee the chasing Raven</value>
        private event Delegates.CalculateRavenAvoidance  CalcRavenFleeEvent;

        ///<summary>
        ///This method raises the calculate and move events
        ///</summary>
        ///<param name="sparrows">List of Sparrow objects</param>
        ///<param name="raven">A Raven object</param>

        public void RaiseMoveEvents(List<Sparrow> sparrows, Raven raven)
        {
            CalcMovementEvent?.Invoke(sparrows);
            MoveEvent?.Invoke();
            CalcRavenFleeEvent?.Invoke(raven);

        }

        ///<summary>
        ///This method subscribes the sparrows and raven to the events. 
        ///</summary>
        ///<param name="calculateMoveVector">CalculateMoveVector delegate instance</param>
        ///<param name="moveBird">MoveBird delegate instance</param>
        ///<param name="calculateRavenAvoidance">optional CalculateRavenAvoidance delegate instance for sparrows</param>
        public void Subscribe(Delegates.CalculateMoveVector calculateMoveVector, Delegates.MoveBird moveBird, Delegates.CalculateRavenAvoidance calculateRavenAvoidance = default)
        {
            CalcMovementEvent += calculateMoveVector;

            MoveEvent += moveBird;

            CalcRavenFleeEvent += calculateRavenAvoidance;

        }

        
    }
}