using System;
using System.Collections.Generic;

namespace FlockingBackend
{
    ///<summary>
    ///This class is used to represent a single sparrow. 
    ///</summary>
    public class Sparrow : Bird
    {
        
        ///<summary>
        ///This constructor is used to initialize the properties and variables of the base class
        ///</summary>
        public Sparrow() : base()
        {
            // Inherits all fields from base class
        }

        ///<summary>
        ///This constructor is used to initialize the properties and variables of the base class.
        /// Used for testing.
        ///</summary>
        ///<param name="ux">X value of velocity</param>
        ///<param name="uy">Y value of velocity</param>
        ///<param name="vx">X value of posiiton</param>
        ///<param name="vy">Y value of posiiton</param>
        public Sparrow(float ux, float uy, float vx, float vy) : base(ux, uy, vx, vy)
        {
            // Inherits all fields from base class.
        }

        ///<summary>
        ///This method is an event handler to calculate and set amountToSteer
        /// vector using the flocking algorithm rules.
        /// It uses helper methods to achieve this.
        ///</summary>
        ///<param name="sparrows">List of sparrows</param>
        public override void CalculateBehaviour(List<Sparrow> sparrows) 
        {
            // Alignment
            Vector2 alignementVector = this.Alignment(sparrows);
            // Cohesion
            Vector2 cohesionVector = this.Cohesion(sparrows);
            // Avoidance
            Vector2 avoidanceVector = this.Avoidance(sparrows);
            // Set the sum of the above vectors to amountToSteer            
            base.amountToSteer = alignementVector + cohesionVector + avoidanceVector;
            
        }

        ///<summary>
        ///This method is an event handler to calculate and update amountToSteer vector with the amount to steer to flee a chasing raven
        ///</summary>
        ///<param name="raven">A Raven object</param>
        public void CalculateRavenAvoidance(Raven raven)
        {
            Vector2 fleeRavenVector = this.FleeRaven(raven);
            base.amountToSteer += fleeRavenVector;
        }

        ///<summary>
        /// This method defines the first rule of boids algorithm (Alignment).
        /// It uses helper method to calculate the vector that will be set
        /// to amount to steer.
        /// Method is public for test purposes
        ///</summary>
        ///<param name="sparrows">Sparrows list</param>
        public Vector2 Alignment (List<Sparrow> sparrows)
        {

            List<Sparrow> neighbours = this.getAllNeighbours(sparrows, World.NeighbourRadius);
            
            Vector2 averageVelocity = this.calculateAverageVelocity(neighbours) ;

            // Return when velocity is zero
            if(averageVelocity.Vx == 0.0f && averageVelocity.Vy == 0.0f){
                return averageVelocity;
            }
            
            Vector2 normalizedAverageVelocity = (Vector2.Normalize(averageVelocity)) * World.MaxSpeed;

            normalizedAverageVelocity = normalizedAverageVelocity - this.Velocity ;

            Vector2 normalizedAlignVelocity = (Vector2.Normalize(normalizedAverageVelocity));

            return normalizedAlignVelocity;

        }
        ///<summary>
        /// Helper method calculates the average velocity of the neighbours.
        /// returns the average velocity or zero vector velocity.
        ///</summary>
        ///<param name="sparrows">Neighbours list</param>

        private Vector2 calculateAverageVelocity(List<Sparrow> neighbours)
        {
                
            Vector2 velocitySum = new Vector2(0.0f,0.0f);

            foreach(Sparrow s in neighbours)
            {
               velocitySum += s.Velocity;
            }

            //return VelocityZero or velocity average
            return neighbours.Count > 0 ? velocitySum/neighbours.Count : velocitySum;
            
        }

        ///<summary>
        /// Helper method returns a list of sparrow thar are neighouberd with this sparrow.
        ///</summary>
        ///<param name="sparrows">Sparrows listt</param>
        ///<param name="radius">radius  neighbour</param>
        private List<Sparrow> getAllNeighbours(List<Sparrow> sparrows, int radius)

        {
            List<Sparrow> neighbours = new List<Sparrow>(); 

            foreach(Sparrow s in sparrows)
            {
                if (this != s && radius * radius > Vector2.DistanceSquared(this.Position, s.Position))
                {
                    neighbours.Add(s);
                }
            }

            return neighbours;
        }

        ///<summary>
        /// This method defines the second rule of boids algorithm (Cohesion).
        /// It uses helper method to calculate the vector that will be added
        /// to amount to steer.
        /// Method is public for test purposes
        ///</summary>
        ///<param name="sparrows">Sparrows list</param>
        public Vector2 Cohesion (List<Sparrow> sparrows)
        {
            List<Sparrow> neighbours = this.getAllNeighbours(sparrows, World.NeighbourRadius);
            
            Vector2 averagePosition = this.calculateAveragePosition(neighbours) ;

            // Return when velocity is zero
            if(averagePosition.Vx == 0.0f && averagePosition.Vy == 0.0f){
                return averagePosition;
            }

            averagePosition = averagePosition - this.Position ;

            Vector2 normalizedDisplacementVector = (Vector2.Normalize(averagePosition)) * World.MaxSpeed;

            Vector2 sparrowVelcity = Vector2.Normalize(normalizedDisplacementVector - this.Velocity) ;
            
            return sparrowVelcity;
        }

        ///<summary>
        /// Helper method calculates the average position of the neighbours.
        /// Returns the average position or Zero vector.
        ///</summary>
        ///<param name="sparrows">Neighbours list</param>
         private Vector2 calculateAveragePosition(List<Sparrow> neighbours)
        {
                
            Vector2 positionSum = new Vector2(0.0f,0.0f);

            foreach(Sparrow s in neighbours)
            {
               positionSum += s.Position;
            }

            //return positionZero or position average vector
            return neighbours.Count > 0 ? positionSum/neighbours.Count : positionSum;
            
        }

        ///<summary>
        /// This method defines the third rule of boids algorithm (avoidance).
        /// It uses helper method to calculate the vector that will be added
        /// to amount to steer.
        /// Method is public for test purposes
        ///</summary>
        ///<param name="sparrows">Sparrows list</param>
        public Vector2 Avoidance (List<Sparrow> sparrows)
        {
            List<Sparrow> neighbours = this.getAllNeighbours(sparrows, World.AvoidanceRadius);

            Vector2 avoidonceAverage = CalculateAverageAvoidance(neighbours);

            // Return when average is zero
            if(avoidonceAverage.Vx == 0.0f && avoidonceAverage.Vy == 0.0f){
                return avoidonceAverage;
            }

            Vector2 normalizedAverageAvoidance = (Vector2.Normalize(avoidonceAverage)) * World.MaxSpeed;

            normalizedAverageAvoidance = normalizedAverageAvoidance - this.Velocity ;

            Vector2 avoidanceVector = (Vector2.Normalize(normalizedAverageAvoidance));

            return avoidanceVector;

        }

         ///<summary>
        /// Helper method returns the average vector for avoidance rule
        ///</summary>
        ///<param name="sparrows">Sparrows listt</param>
        private Vector2 CalculateAverageAvoidance(List<Sparrow> neighbours)
        {
            Vector2 avoidanceVelocity = new Vector2(0.0f,0.0f);

            foreach(Sparrow s in neighbours)
            {
               float distance  = (Vector2.DistanceSquared(this.Position, s.Position));

               Vector2 differnce = this.Position - s.Position;
               
               differnce /= distance;

               avoidanceVelocity += differnce;
            }

            //Return positionZero or position average
            return neighbours.Count > 0 ? avoidanceVelocity/neighbours.Count : avoidanceVelocity;

        }
        ///<summary>
        /// Helper method returns the a vector that represt the amount to steer
        /// to flee a raven
        /// method is public for unit test purposes
        ///</summary>
        ///<param name="raven">Raven bird</param>
        public Vector2 FleeRaven(Raven raven)
        {
            float distance = Vector2.DistanceSquared(this.Position, raven.Position);
        
            if ( distance == 0){
                return Vector2.Normalize(this.Velocity);
            }
            
            if(distance < World.AvoidanceRadius * World.AvoidanceRadius)
            {
                Vector2 diff = this.Position - raven.Position;
                diff /= distance;
                Vector2 normalizeFleeRavenVector = Vector2.Normalize(diff) * World.MaxSpeed;
                return normalizeFleeRavenVector;
            }
            
            return new Vector2(0, 0);
        
        }
        
    }
}
