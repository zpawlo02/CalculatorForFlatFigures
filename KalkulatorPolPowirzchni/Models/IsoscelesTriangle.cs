using System;
using KalkulatorPolPowirzchni.Models;

namespace KalkulatorPolPowirzchni.Models
{
    public class IsoscelesTriangle : Figure
    {
        public IsoscelesTriangle()
        {

        }

        public override float calculateArea(float a)
        {
            return  (0.5f * a * a * (float)(Math.Sqrt(2.0)/2.0));
        }
    }
    
}
