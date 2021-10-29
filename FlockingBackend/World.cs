using System;
using System.Collections.Generic;
namespace FlockingBackend
{
    
    public class World
    {
        //Instance of flock obj
        private Flock flock;

        // Number of sparrows
        public static int initialiCounts;
        // Canvas width 
        public static int width;

        // Canvas height 
        public static int height;

        // Neighbour radius
        public static int neighbourRadius;

        // Bird max speed 
        public static int maxSpeed;

           // Avoidance radius
        public static int avoidanceRadius;
        
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
            initialiCounts = 150;
            width = 1000;
            height = 500;
            maxSpeed = 4;
            neighbourRadius = 100;
            avoidanceRadius = 50;
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
            
            for (int i = 0; i < initialiCounts; i++)
            {
                Sparrow s = new Sparrow();
                
                // Subscribe To do ..    
                
                Sparrows.Add(s);
            }
        }

        // Subscribe raven
        private void SubscribeRaven() 
        
        {
            
            // To do
           
        }


    }
}
