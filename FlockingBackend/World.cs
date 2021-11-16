using System;
using System.Collections.Generic;
namespace FlockingBackend
{
    ///<summary>
    ///This class is the access to the flock world.
    ///</summary>
    public class World
    {
        ///<value> flock <c>Flock</c> Instance of flock obj</value>
        private Flock flock;

        // Number of sparrows
        public static int InitialiCounts { get; }

        // Canvas width 
        public static int Width { get; }

        // Canvas height 
        public static int Height { get; }

        // Neighbour radius
        public static int NeighbourRadius { get; }

        // Bird max speed 
        public static int MaxSpeed { get; }

        // Avoidance radius
        public static int AvoidanceRadius { get; }

        // Auto-property for sparrows list
        public List<Sparrow> Sparrows { get; }

        // Auto-property for Raven
        public Raven RavenBird { get; }

        ///<summary>
        /// Static constructor for static fields 
        ///</summary> 
        static World()
        {
            InitialiCounts = 150;
            Width = 1000;
            Height = 500;
            MaxSpeed = 4;
            NeighbourRadius = 100;
            AvoidanceRadius = 50;
        }

        ///<summary>
        /// Instance constructor initializes the world fields
        ///</summary>
        public World()
        {
            flock = new Flock();
            Sparrows = new List<Sparrow>();
            InitializeAndSubscribeSparrows();
            RavenBird = new Raven();
            SubscribeRaven();
        }

        ///<summary>
        /// Helper method Initialize and add sparrow to the list.
        /// Also subscribe each sparrow. 
        ///</summary>
        private void InitializeAndSubscribeSparrows()
        {
            for (int i = 0; i < InitialiCounts; i++)
            {
                Sparrow s = new Sparrow();
                flock.Subscribe(s.CalculateBehaviour, s.Move, s.CalculateRavenAvoidance);
                Sparrows.Add(s);
            }
        }

        ///<summary>
        ///Helper method subscribe the raven. 
        ///</summary>
        private void SubscribeRaven()
        {
            flock.Subscribe(RavenBird.CalculateBehaviour, RavenBird.Move);
        }

        ///<summary>
        ///This method raise the events . 
        ///</summary>
        public void Update()
        {
            flock.RaiseMoveEvents(Sparrows, RavenBird);
        }
    }
}
