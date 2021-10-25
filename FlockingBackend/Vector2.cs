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
    }
}