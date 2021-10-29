using System;
using System.Collections.Generic;

namespace FlockingBackend
{
    ///<summary>
    ///This class is used to represent a single sparrow. 
    ///</summary>
    public class Sparrow : Bird
    {
        //TODO: Add the constructor, properties and fields as specified in the instructions document.

        ///<summary>
        ///This constructor is used to initialize the properties and variables of the base class
        ///</summary>
        public Sparrow() : base()
        {
            //
        }

        ///<summary>
        ///This constructor is used to initialize the properties and variables of the base class
        ///</summary>
        ///<param name="ux">X value of velocity</param>
        ///<param name="uy">Y value of velocity</param>
        ///<param name="vx">X value of posiiton</param>
        ///<param name="vy">Y value of posiiton</param>
        public Sparrow(float ux, float uy, float vx, float vy) : base(ux, uy, vx, vy)
        {
            //
        }

        ///<summary>
        ///This method is an event handler to calculate and set amountToSteer vector using the flocking algorithm rules
        ///</summary>
        ///<param name="sparrows">List of sparrows</param>
        public override void CalculateBehaviour(List<Sparrow> sparrows) 
        {
            //TODO: Set the amountToSteer vector with the vectors returned by 
            //Cohesion, Alignment, Avoidance methods
            
        }

        ///<summary>
        ///This method is an event handler to calculate and update amountToSteer vector with the amount to steer to flee a chasing raven
        ///</summary>
        ///<param name="raven">A Raven object</param>
        public void CalculateRavenAvoidance(Raven raven)
        {
            
        }

        //TODO: Code the following private helper methods to implement the flocking algorithm rules. 
        //The method headers are declared below:
        private Vector2 Alignment (List<Sparrow> sparrows)
        {
            return new Vector2(0, 0);
        }

               private Vector2 Cohesion (List<Sparrow> sparrows)
        {
            return new Vector2(0, 0);
        }
        private Vector2 Avoidance (List<Sparrow> sparrows)
        {
            return new Vector2(0, 0);
        }
        private Vector2 FleeRaven(Raven raven)
        {
            return new Vector2(0, 0);
        }
    }
}
