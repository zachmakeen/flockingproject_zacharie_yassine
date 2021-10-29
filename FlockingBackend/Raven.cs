using System;
using System.Collections.Generic;

namespace FlockingBackend
{
    ///<summary>
    ///This class is used to represent a single raven. 
<<<<<<< HEAD
    ///This class is just a starting point. Complete the TODO sections
    ///</summary>
    public class Raven
    {
        //TODO: Add the constructor, properties and fields as specified in the instructions document.

        ///<value> Property <c>Rotation</c> to rotate the raven to face the direction it is moving toward.</value>
        public float Rotation
        {
            get 
            {
                return (float)Math.Atan2(this.velocity.Y, this.velocity.X); 
            }
        }

        ///<summary>
        ///This method is an event handler that updates the velocity and position of a raven.
        ///</summary>
        public void Move()
        {
            //TODO: 
        }
=======
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

>>>>>>> c4d503614c88f4df2251c9bcc3b97109e47c9bda
        ///<summary>
        ///This method is an event handler to calculate and set amountToSteer vector
        ///</summary>
        ///<param name="sparrows">List of sparrows</param>
<<<<<<< HEAD
        public void CalculateBehaviour(List<Sparrow> sparrows) 
=======
        public override void CalculateBehaviour(List<Sparrow> sparrows) 
>>>>>>> c4d503614c88f4df2251c9bcc3b97109e47c9bda
        {
            //TODO: Set the amountToSteer vector with the vector returned by the ChaseSparrow.
        }

        //TODO: Code the following private helper methods to implement chase sparrows.
        //The method header are declared below:
<<<<<<< HEAD
        private Vector2 ChaseSparrow (List<Sparrow> sparrows);
        
       
       ///<summary>
        ///This method is a private helper method to make sparrows reappear on the opposite edge if they go outside the bounds of the screen
        ///</summary>
       private void AppearOnOppositeSide()
       {
           if (this.Position.X > World.Width)
            {
                this.Position = new Vector2(0, this.Position.Y);
            }
            else if(this.Position.X < 0)
            {
                 this.Position = new Vector2(World.Width, this.Position.Y);
            }
            if (this.Position.Y > World.Height)
            {
                this.Position = new Vector2(this.Position.X, 0);
            }
            else if(this.position.Y < 0)
            {
                this.Position= new Vector2(this.Position.X, World.Height);
            }
       }
=======
        private Vector2 ChaseSparrow (List<Sparrow> sparrows)
        {
            return new Vector2(0, 0);
        }
>>>>>>> c4d503614c88f4df2251c9bcc3b97109e47c9bda
    }
}