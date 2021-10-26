using System;

namespace FlockingBackend
{
    public struct Vector2
    {
        //constructor to initialize the properties
        public Vector2(float vx, float vy)
        {
            Vx = vx;
            Vy = vy;
        }

        //properties to hold the x and y points of a vector
        public float Vx { get; }
        public float Vy { get; }

        //overloaded the operators to facilitate making calculations with vectors
        public static Vector2 operator +(Vector2 u, Vector2 v) => new Vector2(u.Vx + v.Vx, u.Vy + v.Vy);
        public static Vector2 operator -(Vector2 u, Vector2 v) => new Vector2(u.Vx - v.Vx, u.Vy - v.Vy);
        public static Vector2 operator /(Vector2 u, float f) => new Vector2(u.Vx / f, u.Vy / f);
        public static Vector2 operator *(Vector2 u, float f) => new Vector2(u.Vx * f, u.Vy * f);

        //calculates the distance squared of two vectors
        public static float DistanceSquared(Vector2 u, Vector2 v) => (float) (Math.Pow(u.Vx - v.Vx, 2) + Math.Pow(u.Vy - v.Vy, 2));

        //normalizes a vector
        public static Vector2 Normalize(Vector2 u)
        {
            float magnitude = (float) Math.Sqrt(Math.Pow(u.Vx, 2) + Math.Pow(u.Vy, 2));
            return new Vector2(u.Vx / magnitude, u.Vy / magnitude);
        }
    }
}