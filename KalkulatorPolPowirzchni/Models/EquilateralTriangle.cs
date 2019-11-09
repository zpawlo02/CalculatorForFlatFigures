using System;
using KalkulatorPolPowirzchni.Models;

namespace KalkulatorPolPowirzchni.Models
{
    public class EquilateralTriangle : Figure
    {
        public EquilateralTriangle()
        {
        }

        public override float calculateArea(float a)
        {
            return (float)(a * a * Math.Sqrt(3.0f) * 0.25f);
        }
    }
}
