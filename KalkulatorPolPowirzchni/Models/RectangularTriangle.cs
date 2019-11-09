using System;
namespace KalkulatorPolPowirzchni.Models
{
    public class RectangularTriangle : Figure
    {
        public RectangularTriangle()
        {
        }

        public override float calculateArea(float a, float b)
        {
            return base.calculateArea(a, b) / 2.0f;
        }
    }
}
