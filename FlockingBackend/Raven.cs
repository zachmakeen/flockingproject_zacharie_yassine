using System;
using System.Collections.Generic;

namespace FlockingBackend
{
    ///<summary>
    ///This class is used to represent a single raven. 
    ///</summary>
    public class Raven : Bird
    {
        ///<summary>
        ///This constructor is used to initialize the properties and variables of the base class
        ///</summary>
        public Raven() : base()
        {
            //Inherits all fields from base class
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
            //Inherits all fields from base class
        }

        ///<summary>
        ///This method is an event handler to calculate and set amountToSteer vector
        ///</summary>
        ///<param name="sparrows">List of sparrows</param>
        public override void CalculateBehaviour(List<Sparrow> sparrows) 
        {
            this.amountToSteer = ChaseSparrow(sparrows);
        }

        ///<summary>
        ///This method is a helper method to calculate determine where the closest sparrow us
        ///</summary>
        ///<param name="sparrows">List of sparrows</param>
        public Vector2 ChaseSparrow (List<Sparrow> sparrows) //change back to private
        {
            Sparrow nearestSparrow = null;
            float shortestDistance = float.MaxValue;
            
            //Find the sparrow closest to the raven
            foreach (Sparrow sparrow in sparrows)
            {
                float distance = Vector2.DistanceSquared(this.Position, sparrow.Position);
                
                if (distance < Math.Pow(World.AvoidanceRadius, 2) && distance < shortestDistance)
                {
                    shortestDistance = distance;
                    nearestSparrow = sparrow;
                }
            }

            //Return the difference between the nearest sparrow and the raven
            return nearestSparrow != null ? (nearestSparrow.Position - this.Position) : new Vector2(0, 0);
        }

        ///<summary>
        ///This method is an event handler that updates the velocity and position of a bird.
        ///</summary>
        public override void Move()
        {
            this.Velocity += this.amountToSteer;
            this.Velocity = Vector2.Normalize(this.Velocity) * World.MaxSpeed;
            this.Position += this.Velocity;
            this.AppearOnOppositeSide();
        }
    }
}
