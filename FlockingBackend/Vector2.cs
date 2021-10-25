using System;

namespace FlockingBackend
{
    public struct Vector2
    {
        public Vector2(float vx, float vy)
        {
            Vx = vx;
            Vy = vy;
        }

        public float Vx { get; }
        public float Vy { get; }

        public static Vector2 operator +(Vector2 u, Vector2 v) => new Vector2(u.Vx + v.Vx, u.Vy + v.Vy);
        public static Vector2 operator -(Vector2 u, Vector2 v) => new Vector2(u.Vx - v.Vx, u.Vy - v.Vy);
        public static Vector2 operator /(Vector2 u, float f) => new Vector2(u.Vx / f, u.Vy / f);
        public static Vector2 operator *(Vector2 u, float f) => new Vector2(u.Vx * f, u.Vy * f);
    }
}