using System;
using System.Collections.Generic;

namespace FlockingBackend
{
    ///<summary>
    ///This abstract class is used to represent a single bird.
    ///</summary>
    public abstract class Bird
    {
        ///<value> field <c>amountToSteer</c> the amount to steer after after applying the flocking and raven fleeing rules.</value>
        protected Vector2 amountToSteer;

        ///<summary>
        ///This constructor is used to initialize the properties and variables of the bird class
        ///</summary>
        public Bird()
        {
            Random random = new Random();
            this.Position = new Vector2(random.Next(World.Width), random.Next(World.Height));
            this.Velocity = new Vector2(random.Next(-4, 5), random.Next(-4, 5));
            this.amountToSteer = new Vector2(0, 0);
        }

        ///<summary>
        ///This constructor is used to initialize the properties and variables of the bird class
        ///</summary>
        ///<param name="ux">X value of velocity</param>
        ///<param name="uy">Y value of velocity</param>
        ///<param name="vx">X value of posiiton</param>
        ///<param name="vy">Y value of posiiton</param>
        public Bird(float ux, float uy, float vx, float vy)
        {
            this.Position = new Vector2(ux, uy);
            this.Velocity = new Vector2(vx, vy);
            this.amountToSteer = new Vector2(0, 0);
        }

        ///<value> Property <c>Rotation</c> to rotate the bird to face the direction it is moving toward.</value>
        public float Rotation { get => (float) (Math.Atan2(this.Velocity.Vy, this.Velocity.Vx)); }

        ///<value> Property <c>Position</c> to calculate the velocity of the bird..</value>
        public Vector2 Position { get; protected set; }

        ///<value> Property <c>Velocity</c> to store the position of the bird.</value>
        public Vector2 Velocity { get; protected set; }

        ///<summary>
        ///This method is a private helper method to make birds reappear on the opposite edge if they go outside the bounds of the screen
        ///</summary>
        private void AppearOnOppositeSide()
        {
            if (this.Position.Vx > World.Width)
            {
                this.Position = new Vector2(0, this.Position.Vy);
            }
            else if (this.Position.Vx < 0)
            {
                this.Position = new Vector2(World.Width, this.Position.Vy);
            }
            if (this.Position.Vy > World.Height)
            {
                this.Position = new Vector2(this.Position.Vx, 0);
            }
            else if (this.Position.Vy < 0)
            {
                this.Position = new Vector2(this.Position.Vx, World.Height);
            }
        }

        ///<summary>
        ///This method is an event handler to calculate and set amountToSteer vector using the flocking algorithm rules
        ///</summary>
        ///<param name="sparrows">List of sparrows</param>
        public abstract void CalculateBehaviour(List<Sparrow> sparrows);

        ///<summary>
        ///This method is an event handler that updates the velocity and position of a bird.
        ///</summary>
        public void Move()
        {
            
            this.Velocity += this.amountToSteer;
            this.Position += this.Velocity;
            this.AppearOnOppositeSide();
        }
    }
}
