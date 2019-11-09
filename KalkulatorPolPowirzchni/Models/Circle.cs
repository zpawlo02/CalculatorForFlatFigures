using System;
using KalkulatorPolPowirzchni.Models;

namespace KalkulatorPolPowirzchni.Models
{
    public class Circle : Figure
    {
        private const float pi = 3.14f;

        public Circle()
        {
        }

        public override float calculateArea(float a)
        {
            return pi * a * a;
        }

    }
}
