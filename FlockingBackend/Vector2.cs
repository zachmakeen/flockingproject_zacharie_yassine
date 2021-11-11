using System;

namespace FlockingBackend
{
    ///<summary>
    ///This class is used to represent a vector.
    ///</summary>
    public struct Vector2
    {
        ///<summary>
        ///This constructor is used to initialize the properties and variables of the vector2 class
        ///</summary>
        ///<param name="vx">X value of a vector</param>
        ///<param name="vy">Y value of a vector</param>
        public Vector2(float vx, float vy)
        {
            Vx = vx;
            Vy = vy;
        }

        ///<value> Property <c>Vx</c> to store the x value of a vector.</value>
        public float Vx { get; }

        ///<value> Property <c>Vy</c> to store the y value of a vector.</value>
        public float Vy { get; }

        ///<summary>
        ///This method is used to add two vectors
        ///</summary>
        ///<param name="u">The first vector</param>
        ///<param name="v">The second vector</param>
        public static Vector2 operator +(Vector2 u, Vector2 v) => new Vector2(u.Vx + v.Vx, u.Vy + v.Vy);

        ///<summary>
        ///This method is used to subtract two vectors
        ///</summary>
        ///<param name="u">The first vector</param>
        ///<param name="v">The second vector</param>
        public static Vector2 operator -(Vector2 u, Vector2 v) => new Vector2(u.Vx - v.Vx, u.Vy - v.Vy);

        ///<summary>
        ///This method is used to divde a vector by a float
        ///</summary>
        ///<param name="u">The first vector</param>
        ///<param name="v">The float used to divide</param>
        public static Vector2 operator /(Vector2 u, float f) => new Vector2(u.Vx / f, u.Vy / f);

        ///<summary>
        ///This method is used to multiply a vector by a float
        ///</summary>
        ///<param name="u">The first vector</param>
        ///<param name="v">The float used to multiply</param>
        public static Vector2 operator *(Vector2 u, float f) => new Vector2(u.Vx * f, u.Vy * f);

        ///<summary>
        ///This method is used to calculate the distance squared of two vectors.
        ///</summary>
        ///<param name="u">The first vector</param>
        ///<param name="v">The second vector</param>
        public static float DistanceSquared(Vector2 u, Vector2 v) => (float) (Math.Pow(u.Vx - v.Vx, 2) + Math.Pow(u.Vy - v.Vy, 2));

        ///<summary>
        ///This method is used to normalizes a vector.
        ///</summary>
        ///<param name="u">The vector</param>
        public static Vector2 Normalize(Vector2 u)
        {
            float magnitude = (float) Math.Sqrt(Math.Pow(u.Vx, 2) + Math.Pow(u.Vy, 2));
            if (magnitude >0)
                return new Vector2(u.Vx / magnitude, u.Vy / magnitude);
            return new Vector2(u.Vx / 1, u.Vy / 1);     
        }
    }
}