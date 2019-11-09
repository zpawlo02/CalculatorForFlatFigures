using System;
namespace KalkulatorPolPowirzchni.Models
{
    public class Figure
    {
        public virtual float calculateArea(float a, float b)
        {
            return a * b;
        }

        public virtual float calculateArea(float a)
        {
            return a * a;
        }

        public virtual float calculateArea(float a, float b, float h)
        {
            return (a + b) * h * 0.5f;
        }
    }
}
