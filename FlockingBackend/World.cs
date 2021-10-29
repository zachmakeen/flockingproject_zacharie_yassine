using System;
using System.Collections.Generic;
namespace FlockingBackend
{
    
    public class World
    {
        //Instance of flock obj
        private Flock flock;

        // Number of sparrows
        public static int InitialiCounts{ get;   }
        // Canvas width 
        public static int Width{ get; }

        // Canvas height 
        public static int Height{ get; }

        // Neighbour radius
        public static int NeighbourRadius{ get; }

        // Bird max speed 
        public static int MaxSpeed{ get; }

        // Avoidance radius
        public static int AvoidanceRadius{ get; }
        
        // Auto-property for sparoows list
        public List<Sparrow> Sparrows
        {
            get;
        }

        // Auto-property for Raven
        public Raven RavenBird
        {
            get;
        }

        // Static constructor 
        static World()
        {
            // Number of sparrows
            InitialiCounts = 150;
            Width = 1000;
            Height = 500;
            MaxSpeed = 4;
            NeighbourRadius = 100;
            AvoidanceRadius = 50;
        }

        // Instance constructor 

        public World() {
            
            flock = new Flock();

            Sparrows = new List<Sparrow>();

            InitializeAndSubscribeSparrows();

            RavenBird = new Raven();

            SubscribeRaven();

        }

        // Intialiaze and subscribe sparrows
        private void InitializeAndSubscribeSparrows() 
        
        {
            
            for (int i = 0; i < InitialiCounts; i++)
            {
                Sparrow s = new Sparrow();
                
                flock.Subscribe(s.CalculateBehaviour,s.Move,s.CalculateRavenAvoidance);    
                
                Sparrows.Add(s);
            }
        }

        // Subscribe raven
        private void SubscribeRaven() 
        
        {
            
            flock.Subscribe(RavenBird.CalculateBehaviour,RavenBird.Move);
   
        }

        public void Update() {
            flock.RaiseMoveEvents(Sparrows,RavenBird);
        }
    }
}
