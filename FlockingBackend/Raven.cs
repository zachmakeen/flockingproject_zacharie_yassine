using System;
using System.Collections.Generic;

namespace FlockingBackend
{
    ///<summary>
    ///This class is used to represent a single raven. 
    ///</summary>
    public class Raven : Bird
    {
        //TODO: Add the constructor, properties and fields as specified in the instructions document.

        ///<summary>
        ///This constructor is used to initialize the properties and variables of the base class
        ///</summary>
        public Raven() : base()
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
        public Raven(float ux, float uy, float vx, float vy) : base(ux, uy, vx, vy)
        {
            //
        }

        ///<summary>
        ///This method is an event handler to calculate and set amountToSteer vector
        ///</summary>
        ///<param name="sparrows">List of sparrows</param>
        public override void CalculateBehaviour(List<Sparrow> sparrows) 
        {
            //TODO: Set the amountToSteer vector with the vector returned by the ChaseSparrow.
        }

        //TODO: Code the following private helper methods to implement chase sparrows.
        //The method header are declared below:
        private Vector2 ChaseSparrow (List<Sparrow> sparrows)
        {
            return new Vector2(0, 0);
        }
    }
}