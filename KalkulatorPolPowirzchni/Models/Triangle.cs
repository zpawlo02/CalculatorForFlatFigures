using System;
using KalkulatorPolPowirzchni.Models;

namespace KalkulatorPolPowirzchni.Models
{
    public class Triangle : Figure
    {

        public override float calculateArea(float a, float b)
        {
            return (a * b) * 0.5f;
            
           
        }

        public Triangle()
        {

        }

     
    }
}
